using Cattv.ShutdownWindows.Internal;
using System;
using System.ComponentModel;
using Windows.Win32;
using Windows.Win32.Foundation;
using Windows.Win32.System.Shutdown;

namespace Cattv.ShutdownWindows
{
    /// <summary>
    /// Provides a set of <code>static</code> (<code>Shared</code> in Visual Basic) methods for starting or aborting a Windows shutdown or restart.
    /// </summary>
    public static class ShutdownWindows
    {
        private static void ThrowShutdownException(string function)
        {
            var exception = new Win32Exception();
            throw new ShutdownException($"{function} failed: {exception.Message}", exception);
        }

        /// <summary>
        /// Abort a pending shutdown or reboot.
        /// </summary>
        /// <exception cref="ShutdownException">An error occurred when attempting the shutdown.</exception>
        public static void Abort()
        {
            using var privilege = ShutdownPrivilege.AcquirePrivilege();

            var result = PInvoke.AbortSystemShutdown(null);
            if (!result)
            {
                ThrowShutdownException("AbortSystemShutdown");
            }
        }

        /// <summary>
        /// Initiate a shutdown or restart.
        /// If <paramref name="delay"/> is greater than zero,
        /// the shutdown or restart can be aborted with <see cref="Abort"/>.
        /// </summary>
        /// <param name="message">Message that will be displayed to the user.</param>
        /// <param name="delay">Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second.</param>
        /// <param name="force">
        /// Force the shutdown or restart.
        /// </param>
        /// <param name="restart">Restart instead of shutting down.</param>
        /// <param name="reason">The shutdown reason that will be logged.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the shutdown.</exception>
        public static void Shutdown(string? message, TimeSpan delay, bool force, bool restart, ShutdownReason reason)
        {
            if (delay < TimeSpan.Zero)
            {
                throw new ArgumentOutOfRangeException(nameof(delay), delay, "Must be zero or greater");
            }
            using var privilege = ShutdownPrivilege.AcquirePrivilege();
            unsafe
            {
                using var messagePtr = SafeWChar.Create(message);

                var result = PInvoke.InitiateSystemShutdownEx(
                    new PWSTR(null),
                    messagePtr.DangerousAsPWSTR(),
                    (uint)Math.Round(delay.TotalSeconds),
                    force,
                    restart,
                    (SHUTDOWN_REASON)reason
                    );
                if (!result)
                {
                    ThrowShutdownException("InitiateSystemShutdownEx");
                }
            }
        }

        #region Shutdown overloads

        /// <summary>
        /// Initiate a shutdown.
        /// If <paramref name="delay"/> is greater than zero,
        /// the shutdown can be aborted with <see cref="Abort"/>.
        /// </summary>
        /// <param name="message">Message that will be displayed to the user.</param>
        /// <param name="delay">Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second.</param>
        /// <param name="force">Force the shutdown.</param>
        /// <param name="reason">The shutdown reason that will be logged.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the shutdown.</exception>
        public static void Shutdown(string message, TimeSpan delay, bool force, ShutdownReason reason)
        {
            Shutdown(message, delay, force, false, reason);
        }

        /// <summary>
        /// Initiate a shutdown.
        /// If <paramref name="delay"/> is greater than zero,
        /// the shutdown can be aborted with <see cref="Abort"/>.
        /// </summary>
        /// <param name="delay">Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second.</param>
        /// <param name="force">Force the shutdown.</param>
        /// <param name="reason">The shutdown reason that will be logged.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the shutdown.</exception>
        public static void Shutdown(TimeSpan delay, bool force, ShutdownReason reason)
        {
            Shutdown(null, delay, force, false, reason);
        }

        /// <summary>
        /// Initiate an immediate shutdown.
        /// </summary>
        /// <param name="message">Message that will be displayed to the user.</param>
        /// <param name="force">Force the shutdown.</param>
        /// <param name="reason">The shutdown reason that will be logged.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the shutdown.</exception>
        public static void Shutdown(string message, bool force, ShutdownReason reason)
        {
            Shutdown(message, TimeSpan.Zero, force, false, reason);
        }

        /// <summary>
        /// Initiate a shutdown.
        /// If <paramref name="delay"/> is greater than zero,
        /// the shutdown can be aborted with <see cref="Abort"/>.
        /// </summary>
        /// <param name="message">Message that will be displayed to the user.</param>
        /// <param name="delay">Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second.</param>
        /// <param name="reason">The shutdown reason that will be logged.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the shutdown.</exception>
        public static void Shutdown(string message, TimeSpan delay, ShutdownReason reason)
        {
            Shutdown(message, delay, false, false, reason);
        }

        /// <summary>
        /// Initiate a shutdown.
        /// If <paramref name="delay"/> is greater than zero,
        /// the shutdown can be aborted with <see cref="Abort"/>.
        /// </summary>
        /// <param name="message">Message that will be displayed to the user.</param>
        /// <param name="delay">Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second.</param>
        /// <param name="force">Force the shutdown.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the shutdown.</exception>
        public static void Shutdown(string message, TimeSpan delay, bool force)
        {
            Shutdown(message, delay, force, false, ShutdownReason.OtherUnplanned);
        }

        /// <summary>
        /// Initiate a shutdown.
        /// If <paramref name="delay"/> is greater than zero,
        /// the shutdown can be aborted with <see cref="Abort"/>.
        /// </summary>
        /// <param name="message">Message that will be displayed to the user.</param>
        /// <param name="delay">Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the shutdown.</exception>
        public static void Shutdown(string message, TimeSpan delay)
        {
            Shutdown(message, delay, false, false, ShutdownReason.OtherUnplanned);
        }

        /// <summary>
        /// Initiate an immediate shutdown.
        /// </summary>
        /// <param name="message">Message that will be displayed to the user.</param>
        /// <param name="force">Force the shutdown.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the shutdown.</exception>
        public static void Shutdown(string message, bool force)
        {
            Shutdown(message, TimeSpan.Zero, force, false, ShutdownReason.OtherUnplanned);
        }

        /// <summary>
        /// Initiate an immediate shutdown.
        /// </summary>
        /// <param name="message">Message that will be displayed to the user.</param>
        /// <param name="reason">The shutdown reason that will be logged.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the shutdown.</exception>
        public static void Shutdown(string message, ShutdownReason reason)
        {
            Shutdown(message, TimeSpan.Zero, false, false, reason);
        }

        /// <summary>
        /// Initiate a shutdown.
        /// If <paramref name="delay"/> is greater than zero,
        /// the shutdown can be aborted with <see cref="Abort"/>.
        /// </summary>
        /// <param name="delay">Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second.</param>
        /// <param name="force">Force the shutdown.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the shutdown.</exception>
        public static void Shutdown(TimeSpan delay, bool force)
        {
            Shutdown(null, delay, force, false, ShutdownReason.OtherUnplanned);
        }

        /// <summary>
        /// Initiate a shutdown.
        /// If <paramref name="delay"/> is greater than zero,
        /// the shutdown can be aborted with <see cref="Abort"/>.
        /// </summary>
        /// <param name="delay">Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second.</param>
        /// <param name="reason">The shutdown reason that will be logged.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the shutdown.</exception>
        public static void Shutdown(TimeSpan delay, ShutdownReason reason)
        {
            Shutdown(null, delay, false, false, reason);
        }

        /// <summary>
        /// Initiate an immediate shutdown.
        /// </summary>
        /// <param name="force">Force the shutdown.</param>
        /// <param name="reason">The shutdown reason that will be logged.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the shutdown.</exception>
        public static void Shutdown(bool force, ShutdownReason reason)
        {
            Shutdown(null, TimeSpan.Zero, force, false, ShutdownReason.OtherUnplanned);
        }

        /// <summary>
        /// Initiate an immediate shutdown.
        /// </summary>
        /// <param name="message">Message that will be displayed to the user.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the shutdown.</exception>
        public static void Shutdown(string message)
        {
            Shutdown(message, TimeSpan.Zero, false, false, ShutdownReason.OtherUnplanned);
        }

        /// <summary>
        /// Initiate a shutdown.
        /// If <paramref name="delay"/> is greater than zero,
        /// the shutdown can be aborted with <see cref="Abort"/>.
        /// </summary>
        /// <param name="delay">Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the shutdown.</exception>
        public static void Shutdown(TimeSpan delay)
        {
            Shutdown(null, delay, false, false, ShutdownReason.OtherUnplanned);
        }

        /// <summary>
        /// Initiate an immediate shutdown.
        /// </summary>
        /// <param name="force">Force the shutdown.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the shutdown.</exception>
        public static void Shutdown(bool force)
        {
            Shutdown(null, TimeSpan.Zero, force, false, ShutdownReason.OtherUnplanned);
        }

        /// <summary>
        /// Initiate an immediate shutdown.
        /// </summary>
        /// <param name="reason">The shutdown reason that will be logged.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the shutdown.</exception>
        public static void Shutdown(ShutdownReason reason)
        {
            Shutdown(null, TimeSpan.Zero, false, false, reason);
        }

        /// <summary>
        /// Initiate an immediate shutdown.
        /// </summary>
        /// <exception cref="ShutdownException">An error occurred when attempting the shutdown.</exception>
        public static void Shutdown()
        {
            Shutdown(null, TimeSpan.Zero, false, false, ShutdownReason.OtherUnplanned);
        }

        #endregion

        #region Restart overloads

        /// <summary>
        /// Initiate a restart.
        /// If <paramref name="delay"/> is greater than zero,
        /// the restart can be aborted with <see cref="Abort"/>.
        /// </summary>
        /// <param name="message">Message that will be displayed to the user.</param>
        /// <param name="delay">Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second.</param>
        /// <param name="force">Force the restart.</param>
        /// <param name="reason">The shutdown reason that will be logged.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the restart.</exception>
        public static void Restart(string message, TimeSpan delay, bool force, ShutdownReason reason)
        {
            Shutdown(message, delay, force, true, reason);
        }

        /// <summary>
        /// Initiate a restart.
        /// If <paramref name="delay"/> is greater than zero,
        /// the restart can be aborted with <see cref="Abort"/>.
        /// </summary>
        /// <param name="delay">Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second.</param>
        /// <param name="force">Force the restart.</param>
        /// <param name="reason">The shutdown reason that will be logged.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the restart.</exception>
        public static void Restart(TimeSpan delay, bool force, ShutdownReason reason)
        {
            Shutdown(null, delay, force, true, reason);
        }

        /// <summary>
        /// Initiate an immediate restart.
        /// </summary>
        /// <param name="message">Message that will be displayed to the user.</param>
        /// <param name="force">Force the restart.</param>
        /// <param name="reason">The shutdown reason that will be logged.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the restart.</exception>
        public static void Restart(string message, bool force, ShutdownReason reason)
        {
            Shutdown(message, TimeSpan.Zero, force, true, reason);
        }

        /// <summary>
        /// Initiate a restart.
        /// If <paramref name="delay"/> is greater than zero,
        /// the restart can be aborted with <see cref="Abort"/>.
        /// </summary>
        /// <param name="message">Message that will be displayed to the user.</param>
        /// <param name="delay">Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second.</param>
        /// <param name="reason">The shutdown reason that will be logged.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the restart.</exception>
        public static void Restart(string message, TimeSpan delay, ShutdownReason reason)
        {
            Shutdown(message, delay, false, true, reason);
        }

        /// <summary>
        /// Initiate a restart.
        /// If <paramref name="delay"/> is greater than zero,
        /// the restart can be aborted with <see cref="Abort"/>.
        /// </summary>
        /// <param name="message">Message that will be displayed to the user.</param>
        /// <param name="delay">Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second.</param>
        /// <param name="force">Force the restart.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the restart.</exception>
        public static void Restart(string message, TimeSpan delay, bool force)
        {
            Shutdown(message, delay, force, true, ShutdownReason.OtherUnplanned);
        }

        /// <summary>
        /// Initiate a restart.
        /// If <paramref name="delay"/> is greater than zero,
        /// the restart can be aborted with <see cref="Abort"/>.
        /// </summary>
        /// <param name="message">Message that will be displayed to the user.</param>
        /// <param name="delay">Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the restart.</exception>
        public static void Restart(string message, TimeSpan delay)
        {
            Shutdown(message, delay, false, true, ShutdownReason.OtherUnplanned);
        }

        /// <summary>
        /// Initiate an immediate restart.
        /// </summary>
        /// <param name="message">Message that will be displayed to the user.</param>
        /// <param name="force">Force the restart.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the restart.</exception>
        public static void Restart(string message, bool force)
        {
            Shutdown(message, TimeSpan.Zero, force, true, ShutdownReason.OtherUnplanned);
        }

        /// <summary>
        /// Initiate an immediate restart.
        /// </summary>
        /// <param name="message">Message that will be displayed to the user.</param>
        /// <param name="reason">The shutdown reason that will be logged.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the restart.</exception>
        public static void Restart(string message, ShutdownReason reason)
        {
            Shutdown(message, TimeSpan.Zero, false, true, reason);
        }

        /// <summary>
        /// Initiate a restart.
        /// If <paramref name="delay"/> is greater than zero,
        /// the restart can be aborted with <see cref="Abort"/>.
        /// </summary>
        /// <param name="delay">Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second.</param>
        /// <param name="force">Force the restart.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the restart.</exception>
        public static void Restart(TimeSpan delay, bool force)
        {
            Shutdown(null, delay, force, true, ShutdownReason.OtherUnplanned);
        }

        /// <summary>
        /// Initiate a restart.
        /// If <paramref name="delay"/> is greater than zero,
        /// the restart can be aborted with <see cref="Abort"/>.
        /// </summary>
        /// <param name="delay">Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second.</param>
        /// <param name="reason">The shutdown reason that will be logged.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the restart.</exception>
        public static void Restart(TimeSpan delay, ShutdownReason reason)
        {
            Shutdown(null, delay, false, true, reason);
        }

        /// <summary>
        /// Initiate an immediate restart.
        /// </summary>
        /// <param name="force">Force the restart.</param>
        /// <param name="reason">The shutdown reason that will be logged.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the restart.</exception>
        public static void Restart(bool force, ShutdownReason reason)
        {
            Shutdown(null, TimeSpan.Zero, force, true, ShutdownReason.OtherUnplanned);
        }

        /// <summary>
        /// Initiate an immediate restart.
        /// </summary>
        /// <param name="message">Message that will be displayed to the user.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the restart.</exception>
        public static void Restart(string message)
        {
            Shutdown(message, TimeSpan.Zero, false, true, ShutdownReason.OtherUnplanned);
        }

        /// <summary>
        /// Initiate a restart.
        /// If <paramref name="delay"/> is greater than zero,
        /// the restart can be aborted with <see cref="Abort"/>.
        /// </summary>
        /// <param name="delay">Delay between displaying the message and the actual shutdown or restart. Rounded to the nearest second.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the restart.</exception>
        public static void Restart(TimeSpan delay)
        {
            Shutdown(null, delay, false, true, ShutdownReason.OtherUnplanned);
        }

        /// <summary>
        /// Initiate an immediate restart.
        /// </summary>
        /// <param name="force">Force the restart.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the restart.</exception>
        public static void Restart(bool force)
        {
            Shutdown(null, TimeSpan.Zero, force, true, ShutdownReason.OtherUnplanned);
        }

        /// <summary>
        /// Initiate an immediate restart.
        /// </summary>
        /// <param name="reason">The shutdown reason that will be logged.</param>
        /// <exception cref="ShutdownException">An error occurred when attempting the restart.</exception>
        public static void Restart(ShutdownReason reason)
        {
            Shutdown(null, TimeSpan.Zero, false, true, reason);
        }

        /// <summary>
        /// Initiate an immediate restart.
        /// </summary>
        /// <exception cref="ShutdownException">An error occurred when attempting the restart.</exception>
        public static void Restart()
        {
            Shutdown(null, TimeSpan.Zero, false, true, ShutdownReason.OtherUnplanned);
        }

        #endregion
    }
}
