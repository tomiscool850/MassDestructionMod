
using MassDestruction.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.armor.chestplates
{
	[AutoloadEquip(EquipType.Body)]
	public class ReinforcedVortexBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Reinforced Vortex Breastplate");
			Tooltip.SetDefault("Vortex yes.");

		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 100000;
			item.rare = ItemRarityID.Red;
			item.defense = 30;
		}

		public override void UpdateEquip(Player player)
		{
			player.rangedDamage += 0.5f;
			player.AddBuff(BuffID.Ironskin, 100);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<ReinforcedVortexFragment>(), 80);
			recipe.AddIngredient(ItemID.VortexBreastplate);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}