using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Recipes
{
	public class PicsawRecipe : ModItem
	{

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PickaxeAxe);
			recipe.AddIngredient(ItemID.BeetleHusk, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.Picksaw);
			recipe.AddRecipe();
		}
	}
}