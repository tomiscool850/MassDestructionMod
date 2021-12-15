using Terraria.ModLoader;
using Terraria.ID;

namespace MassDestruction.Items.bossStuff.Masks
{
	[AutoloadEquip(EquipType.Head)]
	public class GoblinManMask : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 20;
			item.rare = ItemRarityID.Green;
			item.vanity = true;
		}

		public override bool DrawHead()
		{
			return false;
		}
	}
}