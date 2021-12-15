using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.Materials
{
	public class TrueTissuesSamples : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("tissues but like better.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 100000;
			item.rare = ItemRarityID.Red;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TissueSample, 3);
			recipe.AddIngredient(ModContent.ItemType<ReinforcedSoul>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this, 3);
			recipe.AddRecipe();

		}
	}
}