using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.Materials
{
	public class EraserDust : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("this this from eraser powder.");
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
			recipe.AddIngredient(ModContent.ItemType<EraserPowder>());
			recipe.SetResult(this, 5);
			recipe.AddRecipe();

		}
	}
}