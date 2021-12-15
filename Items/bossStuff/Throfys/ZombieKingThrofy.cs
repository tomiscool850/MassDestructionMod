using MassDestruction.Items.tiles.BossTiles.Throfy;
using Terraria.ModLoader;
using Terraria.ID;

namespace MassDestruction.Items.bossStuff.Throfys
{
	public class ZombieKingThrofy : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 30;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 50000;
			item.rare = ItemRarityID.Green;
			item.createTile = ModContent.TileType<ZombieKingThrofyTile>();
			item.placeStyle = 0;
		}
	}
}