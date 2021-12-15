using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Recipes
{
	public class CobaltSheildRecipe : ModItem
	{

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltBar, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.CobaltShield);
			recipe.AddRecipe();
		}
	}
}