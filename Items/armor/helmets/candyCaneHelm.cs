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
	public class candyCaneHelm : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("surgery hat.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 5000;
			item.rare = ItemRarityID.LightRed;
			item.defense = 3;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<candyCaneChestplate>() && legs.type == ModContent.ItemType<candyCaneLeggins>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = ("Suger your way to sucsess");
			player.moveSpeed += 2f;

		}

	}
}