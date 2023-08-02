using System;
using System.Runtime.InteropServices;
using Windows.Win32.Foundation;

namespace Cattv.ShutdownWindows.Internal
{
    internal class SafeWStr : IDisposable
    {
        private bool _disposed;

        private readonly PWSTR _ptr;

        public PWSTR DangerousStr => _ptr;

        public SafeWStr(PWSTR ptr)
        {
            _ptr = ptr;
        }

        public unsafe static SafeWStr Create(string? str)
        {
            var ptr = (char*)Marshal.StringToHGlobalUni(str);
            return new SafeWStr(ptr);
        }

        protected unsafe virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                Marshal.FreeHGlobal((IntPtr)(char*)_ptr);
                _disposed = true;
            }
        }

        ~SafeWStr()
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
