using System;

namespace Framework.Network.Events
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
