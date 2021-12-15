using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.Materials
{
	public class Toys : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("what are you a child.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 1000;
			item.rare = ItemRarityID.Blue;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TatteredCloth, 12);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 5);
			recipe.AddRecipe();

		}
	}
}