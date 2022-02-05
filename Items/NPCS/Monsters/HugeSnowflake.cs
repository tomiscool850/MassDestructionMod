using MassDestruction.Items.placeable;
using MassDestruction.Items.placeable.Banner;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.NPCS.Monsters
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class HugeSnowflake : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Huge snowflake");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.EnchantedSword];
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 12;
			npc.defense = 5;
			npc.lifeMax = 150;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 1000f;
			npc.knockBackResist = 1f;
			npc.aiStyle = NPCID.EnchantedSword;
			aiType = NPCID.EnchantedSword;
			animationType = NPCID.EnchantedSword;
			banner = npc.type;
			bannerItem = ModContent.ItemType<HugeSnowflakeBanner>();
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{

			return !spawnInfo.playerSafe && NPC.downedSlimeKing ? SpawnCondition.Underground.Chance * 0.2f : 0f;


		}


	}
}
