using Framework.Network;

namespace Framework.Plugin
{
    public abstract class ChatPlugin
    {
        public abstract bool HandlePacket(TcpSession session, Packet packet);
    }
}
