using TempestCore.Core.Network;

namespace TempestCore.Core.Plugin
{
    public abstract class RelayPlugin
    {
        public abstract bool HandlePacket(TcpSession session, Packet packet);
    }
}
