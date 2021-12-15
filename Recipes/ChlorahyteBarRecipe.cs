using MassDestruction.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Recipes
{
	public class ChlorahyteBarRecipe : ModItem
	{

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LifeFruit);
			recipe.AddIngredient(ItemID.HallowedBar, 5);
			recipe.SetResult(ItemID.ChlorophyteBar, 5);
			recipe.AddRecipe();
		}
	}
}