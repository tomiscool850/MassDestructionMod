
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MassDestruction.Items.placeable.Bar;

namespace MassDestruction.Items.armor.leggins
{
	[AutoloadEquip(EquipType.Legs)]
	public class BluecandyCaneLeggins : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Surger speed");
			DisplayName.SetDefault("Blue Candy Cane Leggins");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 5000;
			item.rare = ItemRarityID.Blue;
			item.defense = 4;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 1f;
		}

	}
}