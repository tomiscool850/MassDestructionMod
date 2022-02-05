using MassDestruction.Items.tiles;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MassDestruction.Items.tiles.banners;
using MassDestruction.Items.assesories.Everyone;

namespace MassDestruction.Items.placeable.Banner
{
	public class GoblinManBanner : ModItem
	{
		// The tooltip for this item is automatically assigned from .lang files
		public override void SetDefaults()
		{
			item.width = 10;
			item.height = 24;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.rare = ItemRarityID.Red;
			item.value = Item.buyPrice(0, 0, 10, 0);
			item.createTile = ModContent.TileType<GoblinManBannerTile>();
			item.placeStyle = 0;
		}
			public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<BlankBanner>());
			recipe.AddIngredient(ModContent.ItemType<GoblinCape>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}