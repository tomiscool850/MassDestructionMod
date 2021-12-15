using MassDestruction.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Recipes
{
	public class DemoniteBarRecipe : ModItem
	{

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrimtaneBar);
			recipe.SetResult(ItemID.DemoniteBar);
			recipe.AddRecipe();
		}
	}
}