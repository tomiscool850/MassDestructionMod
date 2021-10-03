using Terraria.ID;
using Terraria.ModLoader;
using MassDestruction.Items.tiles;

namespace MassDestruction.Items.placeable.Ore
{
    public class JadeOre : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("jade is green and what else is green emeralds\n" +
				" what do emeralds do they make big emeralds and a hook\n" +
				" do people make these items no witch in theory jade\n" +
				" will allways be usless and no one will use in witch\n" +
				" also means jade is emeralds.");
		}

		public override void SetDefaults()
		{
			item.createTile = ModContent.TileType<Items.tiles.blocks.JadeOreTile>();
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 100;
			item.rare = ItemRarityID.Blue;
            item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.scale = 0.2f;
			item.autoReuse = true;
		}

			
		}
	}