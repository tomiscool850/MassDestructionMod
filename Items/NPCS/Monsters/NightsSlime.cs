using MassDestruction.Items.placeable;
using MassDestruction.Items.placeable.Banner;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.NPCS.Monsters
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class NightsSlime : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Night Slime");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BlueSlime];
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 30;
			npc.defense = 15;
			npc.lifeMax = 500;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 10000f;
			npc.knockBackResist = 1f;
			npc.aiStyle = 1;
			aiType = NPCID.BlueSlime;
			animationType = NPCID.BlueSlime;
			banner = npc.type;
			bannerItem = ModContent.ItemType<NightsSlimeBanner>();
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{

			return !spawnInfo.playerSafe && Main.hardMode ? SpawnCondition.OverworldNightMonster.Chance * 0.2f : 0f;


		}


	}
}