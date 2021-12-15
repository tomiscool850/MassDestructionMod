
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MassDestruction.Items.placeable.Bar;

namespace MassDestruction.Items.armor.leggins
{
	[AutoloadEquip(EquipType.Legs)]
	public class AncientCrimsonGreaves : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Crimson version of the ancinet shadow armor");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 5000;
			item.rare = ItemRarityID.LightRed;
			item.defense = 6;
		}

		public override void UpdateEquip(Player player)
		{
			player.meleeSpeed += 0.08f;
		}

	}
}