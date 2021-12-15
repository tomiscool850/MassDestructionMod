using MassDestruction.Items.placeable;
using MassDestruction.Items.placeable.Banner;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.NPCS.Monsters
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class CorruptedMonster : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Corrupted Monster");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 30;
			npc.defense = 20;
			npc.lifeMax = 450;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 1000f;
			npc.knockBackResist = 1f;
			npc.aiStyle = 3;
			aiType = NPCID.Zombie;
			animationType = NPCID.GreenSlime;
			banner = npc.type;
			bannerItem = ModContent.ItemType<DangerZombieBanner>();
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{

			return SpawnCondition.Corruption.Chance * 0.3f;

		}


	}
}
