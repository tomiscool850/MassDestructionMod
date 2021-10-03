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
	public class JadeHeadgear : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("jade helmet is cool.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 14;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<JadeChestplate>() && legs.type == ModContent.ItemType<JadeLeggins>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "purmitily gives the reduce ammo buff amd rangers" +
				"\n do 20% more damage";
			player.rangedDamage += 0.2f;
			player.AddBuff(BuffID.AmmoReservation, 100);

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<JadeBar>(), 25);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}