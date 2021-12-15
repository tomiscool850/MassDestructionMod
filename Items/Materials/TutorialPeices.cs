using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.Materials
{
	public class TutorialPeices : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Droped from tutorial and used to craft tutorial stuff.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 100;
			item.rare = ItemRarityID.LightRed;
		}
	}
}
