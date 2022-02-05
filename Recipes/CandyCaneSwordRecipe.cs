using MassDestruction.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Recipes
{
	public class CandyCaneSwordRecipe : ModItem
	{

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CandyCaneBlock, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CandyCaneSword);
			recipe.AddRecipe();
		}
	}
}