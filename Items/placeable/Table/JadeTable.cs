using Terraria.ID;
using Terraria.ModLoader;
using MassDestruction.Items.tiles.furniture.tables;
using MassDestruction.Items.placeable.Bar;

namespace MassDestruction.Items.placeable.Table
{
	public class JadeTable : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Jade Table.");
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
			item.value = 150000;
			item.createTile = ModContent.TileType<Items.tiles.furniture.tables.JadeTableTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodenTable);
			recipe.AddIngredient(ModContent.ItemType<JadeBar>(), 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}