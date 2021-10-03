using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using static Terraria.ModLoader.ModContent;
using MassDestruction.Items.tiles;
using MassDestruction.Items.tiles.blocks;

namespace MassDestruction
{
    public class World : ModWorld
    {
        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int shiniesIndex = tasks.FindIndex(x => x.Name.Equals("Shinies"));
            if (shiniesIndex != -1)
            {
                tasks.Insert(shiniesIndex + 1, new PassLegacy("Jade Ore Generation", OreGeneration));
            }
        }


        private void OreGeneration(GenerationProgress progress)
        {
            progress.Message = "Generating modded Ores";

            for (int i = 0; i < (int)((Main.maxTilesX * Main.maxTilesY) * 7E-04); i++)
            {

                int x = WorldGen.genRand.Next(0, Main.maxTilesX);
                int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY);

                WorldGen.TileRunner(
                    x,
                    y,
                    (double)WorldGen.genRand.Next(3, 6),
                    WorldGen.genRand.Next(2, 6),
                    ModContent.TileType<JadeOreTile>(),
                    false,
                    0f,
                    0f,
                    false,
                    true
                 );
            }
        }
    }
}