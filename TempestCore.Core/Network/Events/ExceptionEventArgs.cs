using System;

namespace TempestCore.Core.Network.Events
{
    public class ExceptionEventArgs : EventArgs
    {
        public Exception Exception { get; private set; }

        public ExceptionEventArgs()
        {

        }
        public ExceptionEventArgs(Exception ex)
        {
            Exception = ex;
        }
    }
}
