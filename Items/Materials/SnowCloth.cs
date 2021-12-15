
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.Materials
{
	public class SnowCloth : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Cloth made of snow.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 100;
			item.rare = ItemRarityID.Cyan;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk);
			recipe.AddIngredient(ItemID.SnowBlock, 2);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}