
using MassDestruction.Items.placeable.Bar;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.armor.chestplates
{
	[AutoloadEquip(EquipType.Body)]
	public class candyCaneChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Candy Cane Chestplate");
			Tooltip.SetDefault("a super surgery armor.");

		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1000;
			item.rare = ItemRarityID.LightRed;
			item.defense = 3;
		}

		public override void UpdateEquip(Player player)
		{
			player.allDamage += 1f;
			player.meleeSpeed += 0.5f;
		}

	}
}