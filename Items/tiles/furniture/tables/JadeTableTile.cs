using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace MassDestruction.Items.tiles.furniture.tables
{
	public class JadeTableTile : ModTile
	{
		public override void SetDefaults()
		{
			{
				// Properties
				Main.tileTable[Type] = true;
				Main.tileSolidTop[Type] = true;
				Main.tileNoAttach[Type] = true;
				Main.tileLavaDeath[Type] = false;
				Main.tileFrameImportant[Type] = true;


				// Placement
				TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
				TileObjectData.newTile.StyleHorizontal = true;
				TileObjectData.newTile.CoordinateHeights = new[] { 16, 18 };
				TileObjectData.addTile(Type);

				AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);

				// Etc
				ModTranslation name = CreateMapEntryName();
				name.SetDefault("Table");
				AddMapEntry(new Color(200, 200, 200), name);
			}
		}

		public override void NumDust(int x, int y, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

		public override void KillMultiTile(int x, int y, int frameX, int frameY)
		{
			Item.NewItem(x * 16, y * 16, 48, 32, ModContent.ItemType<Items.placeable.Table.JadeTable>());
		}
	}
}