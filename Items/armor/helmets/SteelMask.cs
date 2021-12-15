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
	public class SteelMask : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Steel is fully immune.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 7;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<SteelTunic>() && legs.type == ModContent.ItemType<SteelLeggins>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = ("Your now fully immune to fire");
			player.AddBuff(BuffID.ObsidianSkin, 100);

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 20);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}