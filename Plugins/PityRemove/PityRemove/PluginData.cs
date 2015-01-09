using System.ComponentModel.Composition;
using Framework.Data;
using Framework.Plugin;

namespace PityRemove
{
    [Export(typeof(GamePlugin))]
    public class PluginData : GamePlugin
    {
        public PluginData()
        {
            Name = "PityRemove";
        }
        public override bool OnCreateRoom(Player plr, Room room)
        {
            room.IsBalanced = false;
            return false;
        }
    }
}
