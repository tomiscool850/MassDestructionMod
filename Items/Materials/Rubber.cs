using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.Materials
{
	public class Rubber : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("rubber.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 1000;
			item.rare = ItemRarityID.Red;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RedDye);
			recipe.AddIngredient(ModContent.ItemType<Plastic>());
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();


		}
	}
}