using Terraria.ID;
using Terraria.ModLoader;
using MassDestruction.Items.tiles.furniture.tables;
using MassDestruction.Items.placeable.Bar;

namespace MassDestruction.Items.placeable.Table
{
	public class FeatherTable : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Feather Table.");
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 30;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 1500;
			item.createTile = ModContent.TileType<Items.tiles.furniture.tables.FeatherTableTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Feather, 15);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}