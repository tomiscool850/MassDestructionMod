using Terraria;
using Terraria.ModLoader;

namespace MassDestruction.Items.mounts.MountBuff
{
	public class FordFocusSEBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Ford Focus SE");
			Description.SetDefault("Leather seats, 4 cup holders, and can survive any crash");
			Main.buffNoTimeDisplay[Type] = true;
			Main.buffNoSave[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.mount.SetMount(ModContent.MountType<Items.mounts.mount.FordFocusSE>(), player);
			player.buffTime[buffIndex] = 10;
		}
	}
}