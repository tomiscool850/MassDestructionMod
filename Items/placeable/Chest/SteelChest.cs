using MassDestruction.Items.placeable.Bar;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.placeable.Chest
{
	public class SteelChest : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("fits the same no more storage.");
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
			item.value = 5000;
			item.createTile = ModContent.TileType<tiles.chests.SteelChestTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Chest);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 3);
			recipe.AddIngredient(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}