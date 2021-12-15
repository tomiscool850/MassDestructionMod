using MassDestruction.Items.tiles;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MassDestruction.Items;
using MassDestruction.Items.armor.chestplates;
using MassDestruction.Items.armor.leggins;
using MassDestruction.Items.Materials;

namespace MassDestruction.Items.armor.helmets
{
	[AutoloadEquip(EquipType.Head)]
	public class ReinforcedVortexHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Vortex but better.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Red;
			item.defense = 30;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<ReinforcedVortexBreastplate>() && legs.type == ModContent.ItemType<ReinforcedVortexLeggins>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "just Vortex armor but better ";
			player.rangedDamage += 2f;
			player.rangedCrit += 80;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<ReinforcedSolarFragment>(), 55);
			recipe.AddIngredient(ItemID.SolarFlareHelmet);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}