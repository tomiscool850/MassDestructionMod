
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.Materials
{
	public class EmeraldCloth : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("can be used for the future mabey to make cloths or something.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 1000;
			item.rare = ItemRarityID.Green;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 5);
			recipe.AddIngredient(ItemID.Emerald, 2);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 3);
			recipe.AddRecipe();

		}
	}
}