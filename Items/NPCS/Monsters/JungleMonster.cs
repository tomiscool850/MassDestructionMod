using MassDestruction.Items.placeable;
using MassDestruction.Items.placeable.Banner;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.NPCS.Monsters
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class JungleMonster : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jungle Monster");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 20;
			npc.defense = 25;
			npc.lifeMax = 150;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 1000f;
			npc.knockBackResist = 1f;
			npc.aiStyle = 3;
			aiType = NPCID.Zombie;
			animationType = NPCID.GreenSlime;
			banner = npc.type;
			bannerItem = ModContent.ItemType<JungleMonsterBanner>();
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{

			return !spawnInfo.playerSafe && NPC.downedQueenBee ? SpawnCondition.UndergroundJungle.Chance * 0.8f : 0f;


		}


	}
}