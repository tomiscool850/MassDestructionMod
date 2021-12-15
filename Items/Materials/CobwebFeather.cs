
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.Materials
{
	public class CobwebFeather : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A feather made of cobwebs.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 1000;
			item.rare = ItemRarityID.Gray;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Feather);
			recipe.AddIngredient(ItemID.Cobweb, 2);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}