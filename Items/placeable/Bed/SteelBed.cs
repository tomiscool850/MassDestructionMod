
using MassDestruction.Items.placeable.Bar;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.placeable.Bed
{
	public class SteelBed : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("must be hard to sleep at night on this.");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 20;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 10000;
			item.createTile = ModContent.TileType<tiles.furniture.Beds.SteelBedTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bed);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 12);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}