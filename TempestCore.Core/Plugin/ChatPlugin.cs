using TempestCore.Core.Network;

namespace TempestCore.Core.Plugin
{
    public abstract class ChatPlugin
    {
        public abstract bool HandlePacket(TcpSession session, Packet packet);
    }
}
