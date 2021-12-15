using MassDestruction.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Recipes
{
	public class BlowpipeRecipe : ModItem
	{

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<BlowpipeCore>());
			recipe.AddIngredient(ItemID.Wood, 12);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(ItemID.Blowpipe);
			recipe.AddRecipe();
		}
	}
}