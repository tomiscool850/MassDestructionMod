using Terraria.ModLoader;
using Terraria.ID;
using MassDestruction.Items;
using MassDestruction.Items.tiles.walls;
using MassDestruction.Items.placeable.Block;

namespace MassDestruction.Items.placeable.Wall
{
	public class AdamantitePlatingWall : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Adamantite Plating Wall.");
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
			item.createWall = ModContent.WallType<Items.tiles.walls.AdamantitePlatingWallTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<AdamantitePlating>());
			recipe.SetResult(this, 4);
			recipe.AddRecipe();
		}
	}
}