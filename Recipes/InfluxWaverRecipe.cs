using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Recipes
{
	public class InfluxWaverRecipe : ModItem
	{

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MartianSaucerTrophy);
			recipe.AddIngredient(ItemID.TerraBlade);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(ItemID.InfluxWaver);
			recipe.AddRecipe();
		}
	}
}