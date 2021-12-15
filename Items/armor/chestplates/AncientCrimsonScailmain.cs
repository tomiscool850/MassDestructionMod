
using MassDestruction.Items.placeable.Bar;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.armor.chestplates
{
	[AutoloadEquip(EquipType.Body)]
	public class AncientCrimsonScailmain : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Ancint Crimson Chainmail");
			Tooltip.SetDefault("Crimson version of the ancinet shadow armor.");

		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 100000;
			item.rare = ItemRarityID.LightRed;
			item.defense = 7;
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeSpeed += 0.08f;
		}

		}
	}