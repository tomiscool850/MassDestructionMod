using MassDestruction.Items.Materials;
using MassDestruction.Items.placeable;
using MassDestruction.Items.placeable.Banner;
using MassDestruction.Items.weapons.RANGER.javilens;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.NPCS.Monsters
{
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class Monster : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Monster");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Zombie];
		}

		public override void SetDefaults()
		{
			npc.width = 18;
			npc.height = 40;
			npc.damage = 25;
			npc.defense = 10;
			npc.lifeMax = 275;
			npc.HitSound = mod.GetLegacySoundSlot(SoundType.Item, "MassDestruction/sounds/MonsterGrowl2");
			npc.DeathSound = mod.GetLegacySoundSlot(SoundType.Item, "MassDestruction/sounds/MonsterGrowl1");
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

			return !spawnInfo.playerSafe && NPC.downedSlimeKing ? SpawnCondition.OverworldNightMonster.Chance * 0.8f : 0f;
		}


		public override void NPCLoot()
		{
			Item.NewItem(npc.getRect(), ModContent.ItemType<MonsterFur>());
		}


	}


}
