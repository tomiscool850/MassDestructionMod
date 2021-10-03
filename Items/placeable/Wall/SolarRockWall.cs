using Terraria.ModLoader;
using Terraria.ID;
using MassDestruction.Items.placeable.Block;

namespace MassDestruction.Items.placeable.Wall
{
	public class SolarRockWall : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Solar now wall.");
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.createWall = ModContent.WallType<tiles.walls.SolarRockWallTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SolarRock>());
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
		}
	}
}