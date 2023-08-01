using System;
using System.Runtime.InteropServices;
using Windows.Win32.Foundation;

namespace Cattv.ShutdownWindows.Internal
{
    internal unsafe class SafeWChar : IDisposable
    {
        private bool _disposed;
        private readonly char* _ptr;

        private SafeWChar(char* ptr)
        {
            _ptr = ptr;
        }

        public static SafeWChar Create(string? str)
        {
            var ptr = (char*)Marshal.StringToHGlobalUni(str);
            return new SafeWChar(ptr);
        }

        public PWSTR DangerousAsPWSTR()
        {
            return new PWSTR(_ptr);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                Marshal.FreeHGlobal((IntPtr)_ptr);
                _disposed = true;
            }
        }

        ~SafeWChar()
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
