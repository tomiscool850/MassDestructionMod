using Terraria.ModLoader;
using Terraria.ID;

namespace MassDestruction.Items.bossStuff.Masks
{
	[AutoloadEquip(EquipType.Head)]
	public class TutorialMask : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 20;
			item.rare = ItemRarityID.Yellow;
			item.vanity = true;
		}

		public override bool DrawHead()
		{
			return false;
		}
	}
}