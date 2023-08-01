using Cattv.ShutdownWindows;
using System;
using System.Threading;

namespace Cattv.ShutdownWindows.Tests.Utilities.AbortTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            TimeSpan timeout = TimeSpan.FromSeconds(10);
            TimeSpan abortTime = TimeSpan.FromSeconds(5);

            Console.WriteLine("Intiating shutdown");
            ShutdownWindows.Restart("This shutdown will be aborted", timeout, false, ShutdownReason.ApplicationMaintenancePlanned);
            Thread.Sleep(abortTime);
            Console.WriteLine("Aborting shutdown");
            ShutdownWindows.Abort();
        }
    }
}