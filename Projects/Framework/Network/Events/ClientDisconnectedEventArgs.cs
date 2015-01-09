using System;

namespace Framework.Network.Events
{
    public class ClientDisconnectedEventArgs : EventArgs
    {
        public TcpSession Session { get; private set; }

        public ClientDisconnectedEventArgs()
        {

        }
        public ClientDisconnectedEventArgs(TcpSession session)
        {
            Session = session;
        }
    }
}
