using Framework.Network;

namespace Framework.Plugin
{
    public abstract class AuthPlugin
    {
        public abstract bool HandlePacket(TcpSession session, Packet packet);
    }
}
