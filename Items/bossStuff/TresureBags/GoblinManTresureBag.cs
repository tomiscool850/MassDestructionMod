using MassDestruction.Items.armor;
using MassDestruction.Items.weapons;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MassDestruction.Items.bossStuff.Masks;
using MassDestruction.Items.Materials;
using MassDestruction.Items.weapons.MAGES.wands;
using MassDestruction.Items.weapons.RANGER.bows;
using MassDestruction.Items.weapons.MELEE.sword;
using MassDestruction.Items.armor.leggins;
using MassDestruction.Items.armor.helmets;
using MassDestruction.Items.armor.chestplates;
using MassDestruction.Items.weapons.RANGER.javilens;
using MassDestruction.Items.weapons.MELEE.spear;
using MassDestruction.Items.weapons.SUMMONERS.summoner;

namespace MassDestruction.Items.bossStuff.TresureBags
{
	public class GoblinManTresureBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Treasure Bag (Goblin man)");
			Tooltip.SetDefault("A tresure bag from the Goblin will give you cool weapons");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = ItemRarityID.Green;
			item.expert = true;

		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void OpenBossBag(Player player)
		{
			player.TryGettingDevArmor();


			if (Main.rand.NextBool(50))
			{
				player.QuickSpawnItem(ModContent.ItemType<GoblinManMask>());
			}

			if (Main.rand.NextBool(30))
			{
				player.QuickSpawnItem(ModContent.ItemType<GoblinJavilen>(), 75);

				if (Main.rand.NextBool(30))
				{

					player.QuickSpawnItem(ModContent.ItemType<GoblinSpear>());

					if (Main.rand.NextBool(20))
					{

						player.QuickSpawnItem(ModContent.ItemType<GoblinHeldToBat>());

					}
				}
			}
		}

		public override int BossBagNPC => ModContent.NPCType<Items.NPCS.bosses.GoblinMan>();


	}
}