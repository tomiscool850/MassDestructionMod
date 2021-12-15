using MassDestruction.Items.placeable.Bar;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.placeable.clock
{
	public class CobaltClock : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("a clock that tells time, BUT ITS COBALT.");
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
			item.createTile = ModContent.TileType<Items.tiles.furniture.Clocks.CobaltClockTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GrandfatherClock);
			recipe.AddIngredient(ItemID.CobaltBar, 5);
			recipe.AddIngredient(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}