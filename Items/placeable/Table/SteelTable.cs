using Terraria.ID;
using Terraria.ModLoader;
using MassDestruction.Items.tiles.furniture.tables;
using MassDestruction.Items.placeable.Bar;

namespace MassDestruction.Items.placeable.Table
{
	public class SteelTable : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Steel Table.");
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
			item.value = 15000;
			item.createTile = ModContent.TileType<Items.tiles.furniture.tables.SteelTableTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 8);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}