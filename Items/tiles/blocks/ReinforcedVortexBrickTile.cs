using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.tiles.blocks
{
	public class ReinforcedVortexBrickTile : ModTile
	{
		public override void SetDefaults()
		{
			TileID.Sets.Ore[Type] = false;
			Main.tileSpelunker[Type] = false; // The tile will be affected by spelunker highlighting
			Main.tileValue[Type] = 1000; // Metal Detector value, see https://terraria.gamepedia.com/Metal_Detector
			Main.tileShine2[Type] = true; // Modifies the draw color slightly.
			Main.tileShine[Type] = 1000; // How often tiny dust appear off this tile. Larger is less frequently
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Reinforced Vortex Brick Tile");
			AddMapEntry(new Color(152, 171, 198), name);

			drop = ModContent.ItemType<Items.placeable.Block.ReinforcedVortexBrick>();
			soundType = SoundID.Tink;
			soundStyle = 1;
			mineResist = 3f;
			minPick = 220;
		}
	}
}