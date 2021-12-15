using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.Materials
{
	public class DolarBills : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Money but like real.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 10000;
			item.rare = ItemRarityID.Lime;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldCoin);
			recipe.AddIngredient(ModContent.ItemType<Paper>());
			recipe.AddTile(TileID.Tables);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}