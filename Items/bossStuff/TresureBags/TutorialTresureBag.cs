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

namespace MassDestruction.Items.bossStuff.TresureBags
{
	public class TutorialTresureBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Treasure Bag (Tutorial)");
			Tooltip.SetDefault("A tresure bag from the tutorial will give you the weapons and armor");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = ItemRarityID.Red;
			item.expert = true;
			
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void OpenBossBag(Player player)
		{
			player.TryGettingDevArmor();
			if (Main.rand.NextBool(7))
			{
				player.QuickSpawnItem(ModContent.ItemType<TutorialMask>());
			}
			player.QuickSpawnItem(ModContent.ItemType<TutorialSword>());
			player.QuickSpawnItem(ModContent.ItemType<TutorialBow>());
			player.QuickSpawnItem(ModContent.ItemType<TutorialWand>());
			player.QuickSpawnItem(ModContent.ItemType<TutorialPeices>(), 15);
			if (Main.rand.NextBool(50))
			{
				player.QuickSpawnItem(ModContent.ItemType<TutorialTunic>());
				player.QuickSpawnItem(ModContent.ItemType<TutorialHelmet>());
				player.QuickSpawnItem(ModContent.ItemType<TutorialBoots>());
			}
		}



		public override int BossBagNPC => ModContent.NPCType<Items.NPCS.bosses.Tutorial>();


	}
}