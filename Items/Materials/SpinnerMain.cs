using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.Materials
{
	public class SpinnerMain : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("used to spin weapons.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 1000;
			item.rare = ItemRarityID.White;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar);
			recipe.AddIngredient(TileID.Anvils);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
			recipe.AddIngredient(ItemID.IronBar);
			recipe.AddIngredient(TileID.Anvils);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();


		}
	}
}