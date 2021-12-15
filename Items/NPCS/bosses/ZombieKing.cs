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
	public class ZombieKing : ModNPC
	{
		public override string Texture => "MassDestruction/Items/NPCS/bosses/ZombieKing";

		public override string HeadTexture => "MassDestruction/Items/NPCS/bosses/ZombieKing_Head_Boss";

		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Flutter Slime"); // Automatic from .lang files
			Main.npcFrameCount[npc.type] = 3; // make sure to set this for your modnpcs.
		}

		public override void SetDefaults()
		{
			npc.width = 50;
			npc.height = 50;
			npc.aiStyle = -1; // This npc has a completely unique AI, so we set this to -1. The default aiStyle 0 will face the player, which might conflict with custom AI code.
			npc.damage = 10;
			npc.defense = 20;
			npc.lifeMax = 1000;
			npc.boss = true;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			npc.HitSound = SoundID.NPCHit1;
			animationType = NPCID.Zombie;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 5000f;// npc default to being immune to the Confused debuff. Allowing confused could be a little more work depending on the AI. npc.confused is true while the npc is confused.
			npc.scale = 4f;
			bossBag = ModContent.ItemType<ZombieKingTresureBag>();
			banner = npc.type;
			bannerItem = ModContent.ItemType<ZombieKingBanner>();
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
					if (Main.rand.NextBool(50))
					{
						Item.NewItem(npc.getRect(), ModContent.ItemType<ZombieKingThrofy>());

						if (Main.rand.NextBool(50))
						{
							Item.NewItem(npc.getRect(), ModContent.ItemType<ZombieKingMask>());
						}


					}
				}
			}
		}
	}