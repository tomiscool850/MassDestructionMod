using Terraria;
using Terraria.ModLoader;

namespace MassDestruction
{
	public class ModGlobalNPC : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (!npc.SpawnedFromStatue && npc.type == base.mod.NPCType("Tutorial") && Main.rand.Next(1) == 0)
			{
				if (Main.rand.Next(1) == 0)
				{
					Main.NewText("You Received Tutorial sword From Tutorial!");
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, base.mod.ItemType("TutorialSword"));
				}
				else if (Main.rand.Next(1) == 0)
				{
					Main.NewText("You Received the Tutorial wand From Tutorial!");
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, base.mod.ItemType("TutorialWand"));
				}
				else if (Main.rand.Next(1) == 0)
				{
					Main.NewText("You Received a Tutorial Bow From Tutorial!");
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, base.mod.ItemType("TutorialBow"));
				}
			}

			}
		}
	}
