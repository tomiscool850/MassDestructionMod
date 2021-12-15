using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.Materials
{
	public class RainbowString : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("String of rainbow.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 1000;
			item.rare = -12;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BlackString);
			recipe.AddIngredient(ItemID.RainbowDye);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}