using MassDestruction;
using Terraria;
using Terraria.ModLoader;

namespace MassDestruction.Items.Effects.Debuffs
{
	public class CyanBlaze : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Cyan Blaze");
			Description.SetDefault("you on super fire");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = true;
			Main.buffNoSave[Type] = true;
			longerExpertDebuff = true;
		}
	}
}