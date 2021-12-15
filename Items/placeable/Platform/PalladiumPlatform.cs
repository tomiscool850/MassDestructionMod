using Terraria.ModLoader;
using Terraria.ID;
using MassDestruction.Items.tiles.platforms;
using MassDestruction.Items.placeable.Bar;

namespace MassDestruction.Items.placeable.Platform
{
	public class PalladiumPlatform : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Palladium yes plat.");
		}

		public override void SetDefaults()
		{
			item.width = 8;
			item.height = 10;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.createTile = ModContent.TileType<tiles.platforms.PalladiumPlatformTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PalladiumBar);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}
}