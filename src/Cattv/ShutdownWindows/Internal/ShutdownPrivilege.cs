using Microsoft.Win32.SafeHandles;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.Security;

namespace Cattv.ShutdownWindows.Internal
{
    internal unsafe class ShutdownPrivilege : IDisposable
    {
        private bool _released = false;

        private SafeFileHandle _processToken;
        private TOKEN_PRIVILEGES* _previousPrivilegesPtr;
        private bool _disposed;

        private ShutdownPrivilege(SafeFileHandle processToken, TOKEN_PRIVILEGES* oldPrivilegesPtr)
        {
            _processToken = processToken;
            _previousPrivilegesPtr = oldPrivilegesPtr;
        }

        public static ShutdownPrivilege AcquirePrivilege()
        {
            var processToken = GetCurrentProcessToken();
            try
            {
                var tokenPrivileges = GetTokenPrivileges();
                var oldPrivilegesPtr = ModifyPrivileges(processToken, tokenPrivileges);
                try
                {
                    return new ShutdownPrivilege(processToken, oldPrivilegesPtr);
                }
                catch
                {
                    Marshal.FreeHGlobal((IntPtr)oldPrivilegesPtr);
                    throw;
                }
            }
            catch
            {
                processToken.Dispose();
                throw;
            }
        }

        public unsafe void ReleasePrivilege()
        {
            if (_released)
            {
                throw new ShutdownException("Privileges already returned to previous state");
            }

            var result = PInvoke.AdjustTokenPrivileges(
                    _processToken,
                    false,
                    *_previousPrivilegesPtr,
                    0,
                    null,
                    null
                    );
            if (!result)
            {
                throw new ShutdownException("AdjustTokenPrivileges failed to restore previous privileges", new Win32Exception());
            }
            _released = true;
        }

        private static SafeFileHandle GetCurrentProcessToken()
        {
            var result = PInvoke.OpenProcessToken(
                PInvoke.GetCurrentProcess_SafeHandle(),
                TOKEN_ACCESS_MASK.TOKEN_QUERY | TOKEN_ACCESS_MASK.TOKEN_ADJUST_PRIVILEGES,
                out var handle
                );
            if (!result)
            {
                throw new ShutdownException("GetCurrentProcessToken failed", new Win32Exception());
            }
            return handle;
        }

        private static TOKEN_PRIVILEGES GetTokenPrivileges()
        {
            var luid = GetLuidForPrivilege(PInvoke.SE_SHUTDOWN_NAME);
            var luidAndAttributes = new LUID_AND_ATTRIBUTES()
            {
                Luid = luid,
                Attributes = TOKEN_PRIVILEGES_ATTRIBUTES.SE_PRIVILEGE_ENABLED
            };
            var tokenPrivileges = new TOKEN_PRIVILEGES()
            {
                PrivilegeCount = 1,
                Privileges = new __LUID_AND_ATTRIBUTES_1() { _0 = luidAndAttributes }
            };
            return tokenPrivileges;
        }

        private static LUID GetLuidForPrivilege(string name)
        {
            var result = PInvoke.LookupPrivilegeValue(
                null,
                name,
                out LUID luid
                );
            if (!result)
            {
                throw new ShutdownException("LookupPrivilegeValue failed", new Win32Exception());
            }
            return luid;
        }

        private unsafe static TOKEN_PRIVILEGES* ModifyPrivileges(SafeFileHandle processToken, TOKEN_PRIVILEGES tokenPrivileges)
        {
            uint bufferLength = 0;
            // first call doesn't change anything, but gives us needed buffer size
            PInvoke.AdjustTokenPrivileges(
                        processToken,
                        false,
                        tokenPrivileges,
                        0,
                        (TOKEN_PRIVILEGES*)-1,
                        &bufferLength
                        );
            if (!(Marshal.GetLastWin32Error() != (int)WIN32_ERROR.ERROR_NOT_ALL_ASSIGNED))
            {
                throw new ShutdownException("AdjustTokenPrivileges failed to get buffer size", new Win32Exception());
            }

            TOKEN_PRIVILEGES* oldPrivilegesPtr = (TOKEN_PRIVILEGES*)Marshal.AllocHGlobal((int)bufferLength);
            var result = PInvoke.AdjustTokenPrivileges(
                        processToken,
                        false,
                        tokenPrivileges,
                        bufferLength,
                        oldPrivilegesPtr,
                        &bufferLength // will fail without a valid pointer here
                        );
            if (!result)
            {
                throw new ShutdownException("AdjustTokenPrivileges failed to acquire shutdown privilege", new Win32Exception());
            }
            return oldPrivilegesPtr;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (!_released)
                    {
                        ReleasePrivilege();
                    }
                    _processToken.Dispose();
                }

                Marshal.FreeHGlobal((IntPtr)_previousPrivilegesPtr);

                _disposed = true;
            }
        }

        ~ShutdownPrivilege()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
