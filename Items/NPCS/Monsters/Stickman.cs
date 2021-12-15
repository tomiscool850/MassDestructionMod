using MassDestruction.Items.placeable;
using MassDestruction.Items.placeable.Banner;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.NPCS.Monsters
{
	public class Stickman : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("stick man");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 40;
			npc.defense = 20;
			npc.lifeMax = 700;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 1000f;
			npc.knockBackResist = 1f;
			npc.aiStyle = 3;
			aiType = NPCID.BoneLee;
			animationType = NPCID.Zombie;
			banner = npc.type;
			bannerItem = ModContent.ItemType<StickmanBanner>();
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{

			return !spawnInfo.playerSafe && NPC.downedBoss3 ? SpawnCondition.Underground.Chance * 0.1f : 0f;


		}


	}
}
