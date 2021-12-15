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
	public class RainyCloudHelm : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("You have gravitation everywhere.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1000;
			item.rare = ItemRarityID.Gray;
			item.defense = 3;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<RainyBreastplate>() && legs.type == ModContent.ItemType<RainyCloudGreaves>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = ("you can use gravintation wherever");
			player.AddBuff(BuffID.Gravitation, 100);

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RainCloud, 12);
			recipe.AddTile(TileID.SkyMill);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}