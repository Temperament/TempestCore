using Framework.Network;

namespace Framework.Plugin
{
    public abstract class RelayPlugin
    {
        public abstract bool HandlePacket(TcpSession session, Packet packet);
    }
}
