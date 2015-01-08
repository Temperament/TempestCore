using System.Collections.Generic;
using System.ComponentModel.Composition;
using TempestCore.Core.Data;
using TempestCore.Core.Plugin;

namespace RemoveStats
{
    [Export(typeof(GamePlugin))]
    public class PluginData : GamePlugin
    {
        public PluginData()
        {
            Name = "RemoveStats";
        }

        public override void OnBuyItem(Player plr, List<Item> itemsToBuy)
        {
            foreach (var item in itemsToBuy)
                item.EffectID = 0;
        }
    }
}
