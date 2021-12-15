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
	public class ZombieKingTresureBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Treasure Bag (Zombie King)");
			Tooltip.SetDefault("A tresure bag from the Zombie king will give you bacicly nothing");
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
			{

			}
				player.QuickSpawnItem(ModContent.ItemType<ZombieKingMask>());


		}

		public override int BossBagNPC => ModContent.NPCType<Items.NPCS.bosses.ZombieKing>();


	}
}