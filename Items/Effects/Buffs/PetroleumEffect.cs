using Terraria;
using Terraria.ModLoader;

namespace MassDestruction.Items.Effects.Buffs
{
    public class PetroleumEffect : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Petroleum Overdose");
            Description.SetDefault("Speeds player up way more then speed potion.");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.moveSpeed += 3;
        }
    }
}