using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace IDisposableDemo
{
    class Disposable
    {
        public class MyResource : IDisposable
        {
            private bool disposed = false;
            SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }
            protected virtual void Dispose(bool disposing)
            {
                if (disposed)
                    return;

                if (disposing)
                {
                    handle.Dispose();
                }
                disposed = true;
            }

            public static void Main(string[] args)
            {

            }
        }
    }
}