using MassDestruction.Items.bossStuff.Masks;
using MassDestruction.Items.bossStuff.Throfys;
using MassDestruction.Items.bossStuff.TresureBags;
using MassDestruction.Items.Materials;
using MassDestruction.Items.placeable.Banner;
using MassDestruction.Items.weapons.MELEE.spear;
using MassDestruction.Items.weapons.RANGER.javilens;
using MassDestruction.Items.weapons.SUMMONERS.summoner;
using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.NPCS.bosses
{
	[AutoloadBossHead]
	public class GoblinMan : ModNPC
	{
		public override string Texture => "MassDestruction/Items/NPCS/bosses/GoblinMan";

		public override string HeadTexture => "MassDestruction/Items/NPCS/bosses/GoblinMan_Head_Boss";

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Flutter Slime"); // Automatic from .lang files
			Main.npcFrameCount[npc.type] = 16; // make sure to set this for your modnpcs.
		}

		public override void SetDefaults()
		{
			npc.width = 50;
			npc.height = 50;
			npc.aiStyle = -1; // This npc has a completely unique AI, so we set this to -1. The default aiStyle 0 will face the player, which might conflict with custom AI code.
			npc.damage = 20;
			npc.defense = 35;
			npc.lifeMax = 1500;
			npc.boss = true;
			npc.knockBackResist = 0.1f;
			npc.aiStyle = 3;
			npc.HitSound = SoundID.NPCHit1;
			animationType = NPCID.GoblinWarrior;
			npc.DeathSound = SoundID.NPCDeath1;
			//npc.alpha = 175;
			//npc.color = new Color(0, 80, 255, 100);
			npc.value = 10000f;// npc default to being immune to the Confused debuff. Allowing confused could be a little more work depending on the AI. npc.confused is true while the npc is confused.
			npc.scale = 5f;
			bossBag = ModContent.ItemType<GoblinManTresureBag>();
			banner = npc.type;
			bannerItem = ModContent.ItemType<GoblinManBanner>();
			music = MusicID.Boss2;
		}
		public override void NPCLoot()
		{
			if (Main.expertMode)
			{
				npc.DropBossBags();
			}
			else
			{
				if (Main.rand.NextBool(30))
				{
					Item.NewItem(npc.getRect(), ModContent.ItemType<GoblinJavilen>(), 50);
					
					if (Main.rand.NextBool(30))
					{

						Item.NewItem(npc.getRect(), ModContent.ItemType<GoblinSpear>());
						
						if (Main.rand.NextBool(20))
						{

							Item.NewItem(npc.getRect(), ModContent.ItemType<GoblinHeldToBat>());
						}
					}

					if (Main.rand.NextBool(10))
					{
						Item.NewItem(npc.getRect(), ModContent.ItemType<GoblinManThrofy>());

						if (Main.rand.NextBool(10))
						{
							Item.NewItem(npc.getRect(), ModContent.ItemType<GoblinManMask>());
						}


					}
				}
			}
		}
	}
}