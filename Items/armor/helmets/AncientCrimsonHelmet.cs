using MassDestruction.Items.tiles;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MassDestruction.Items;
using MassDestruction.Items.armor.chestplates;
using MassDestruction.Items.armor.leggins;
using MassDestruction.Items.placeable.Bar;

namespace MassDestruction.Items.armor.helmets
{
	[AutoloadEquip(EquipType.Head)]
	public class AncientCrimsonHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Crimson version of the ancinet shadow armor.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 5000;
			item.rare = ItemRarityID.LightRed;
			item.defense = 6;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<AncientCrimsonScailmain>() && legs.type == ModContent.ItemType<AncientCrimsonGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = ("gives a good speed boost");
			player.moveSpeed += 0.16f;

		}

	}
}