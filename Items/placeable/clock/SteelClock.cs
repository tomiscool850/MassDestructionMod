using MassDestruction.Items.placeable.Bar;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.placeable.clock
{
	public class SteelClock : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("a clock that tells time, BUT ITS STEEL.");
		}

		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 22;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 20000;
			item.createTile = ModContent.TileType<Items.tiles.furniture.Clocks.SteelClockTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GrandfatherClock);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 5);
			recipe.AddIngredient(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}