using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.Materials
{
	public class EraserPowder : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("this is for eraser dust.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 1000;
			item.rare = ItemRarityID.Pink;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PurificationPowder);
			recipe.AddIngredient(ItemID.PinkDye);
			recipe.AddIngredient(ItemID.LunarBar, 2);
			recipe.AddTile(TileID.Bottles);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}