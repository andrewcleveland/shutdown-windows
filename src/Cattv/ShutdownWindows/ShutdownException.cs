using System;
using System.Runtime.Serialization;

namespace Cattv.ShutdownWindows
{
    /// <summary>
    /// The exception thrown when a shutdown, restart or abort operation fails.
    /// </summary>
    public class ShutdownException : Exception
    {
        internal ShutdownException()
        {
        }

        internal ShutdownException(string message) : base(message)
        {
        }

        internal ShutdownException(string message, Exception innerException) : base(message, innerException)
        {
        }

        internal ShutdownException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
