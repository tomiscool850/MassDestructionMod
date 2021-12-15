using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.placeable.CraftingStation
{
	public class CutterStation : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Cuts stuff up like swords.");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 14;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 150;
			item.createTile = ModContent.TileType<Items.tiles.CraftingStations.CutterStationTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WorkBench);
			recipe.AddIngredient(ItemID.IronBar, 2);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WorkBench);
			recipe.AddIngredient(ItemID.LeadBar, 2);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}