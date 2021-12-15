using Terraria.ID;
using Terraria.ModLoader;
using MassDestruction.Items.tiles.furniture.tables;
using MassDestruction.Items.placeable.Bar;

namespace MassDestruction.Items.placeable.Table
{
	public class CobaltTable : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Cobalt Table.");
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
			item.value = 2500;
			item.createTile = ModContent.TileType<Items.tiles.furniture.tables.CobaltTableTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}