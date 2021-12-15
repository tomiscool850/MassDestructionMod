using MassDestruction.Dusts;
using MassDestruction.Items;
using MassDestruction.Items.Effects.Buffs;
using MassDestruction.Items.Effects.Debuffs;
using MassDestruction.Items.tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction
{
	public class ModGlobalNPC : GlobalNPC
	{
		public override bool InstancePerEntity => true;

		public bool eFlames;
		public override void DrawEffects(NPC npc, ref Color drawColor)
		{
			if (eFlames)
			{
				if (Main.rand.Next(4) < 3)
				{
					int dust = Dust.NewDust(npc.position - new Vector2(2f, 2f), npc.width + 4, npc.height + 4, ModContent.BuffType<CyanBlaze>(), npc.velocity.X * 0.4f, npc.velocity.Y * 0.4f, 100, default(Color), 3.5f);
					Main.dust[dust].noGravity = true;
					Main.dust[dust].velocity *= 1.8f;
					Main.dust[dust].velocity.Y -= 0.5f;
					if (Main.rand.NextBool(4))
					{
						Main.dust[dust].noGravity = false;
						Main.dust[dust].scale *= 0.5f;
					}
				}
				Lighting.AddLight(npc.position, 0.1f, 0.2f, 0.7f);
			}
		}



		public override void NPCLoot(NPC npc)
		{
			if (!npc.SpawnedFromStatue && npc.type == 1)
			{
				if (Main.rand.Next(1000) == 0)
				{
					Main.NewText("You Received KM Ancient Crimson Scailmain From Crimera!");
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, base.mod.ItemType("AncientCrimsonScailmain"));
				}
				else if (Main.rand.Next(1800) == 0)
				{
					Main.NewText("You Received Better Ancient Crimson Helmet From Crimera!");
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, base.mod.ItemType("AncientCrimsonHelmet"));
				}
				else if (Main.rand.Next(1500) == 0)
				{
					Main.NewText("You Received Insane Ancient Crimson Greaves From Crimera!");
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, base.mod.ItemType("AncientCrimsonGreaves"));
				}
			}
		}
	}
}