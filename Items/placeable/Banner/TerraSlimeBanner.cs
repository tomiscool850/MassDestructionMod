using MassDestruction.Items.tiles;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MassDestruction.Items.tiles.banners;

namespace MassDestruction.Items.placeable.Banner
{
	public class TerraSlimeBanner : ModItem
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
			item.rare = ItemRarityID.Blue;
			item.value = Item.buyPrice(0, 0, 10, 0);
			item.createTile = ModContent.TileType<TerraSlimeBannerTile>();
			item.placeStyle = 0;
		}
	}
}