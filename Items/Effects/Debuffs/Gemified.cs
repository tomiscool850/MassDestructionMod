using Terraria;
using Terraria.ModLoader;

namespace MassDestruction.Items.Effects.Debuffs
{
    public class Gemified : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Gemified");
            Description.SetDefault("Your being damaged by crystals perircing your skin.");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = false;
            Main.debuff[Type] = true;
            Main.pvpBuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.dpsDamage = 2;
        }
    }
}