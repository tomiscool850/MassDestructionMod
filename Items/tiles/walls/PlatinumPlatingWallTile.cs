using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace MassDestruction.Items.tiles.walls
{
	public class PlatinumPlatingWallTile : ModWall
	{
		public override void SetDefaults()
		{
			Main.wallHouse[Type] = true;
			drop = ModContent.ItemType<Items.placeable.Wall.PlatinumPlatingWall>();
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.5f;
			g = 0.5f;
			b = 0.5f;

		}
	}
}