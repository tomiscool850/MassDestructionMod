using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.assesories.Melee
{
	[AutoloadEquip(EquipType.Back)]
	public class BrosadeTetory : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("inflects the cyan blaze buff on anything that hits you");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 24;
			item.accessory = true; // Makes this item an accessory.
			item.rare = ItemRarityID.Blue;
			item.value = Item.sellPrice(gold: 5); // Sets the item sell price to one gold coin.
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.accOreFinder = true;
		}
	}
}