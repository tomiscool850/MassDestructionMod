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
	public class BluecandyCaneHelm : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("surgery hat.");
			DisplayName.SetDefault("Blue Candy Cane Helm");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 5000;
			item.rare = ItemRarityID.Blue;
			item.defense = 3;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<BluecandyCaneChestplate>() && legs.type == ModContent.ItemType<BluecandyCaneLeggins>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = ("Suger your way to sucsess");
			player.moveSpeed += 2f;

		}

	}
}