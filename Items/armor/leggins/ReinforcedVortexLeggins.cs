
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MassDestruction.Items.Materials;

namespace MassDestruction.Items.armor.leggins
{
	[AutoloadEquip(EquipType.Legs)]
	public class ReinforcedVortexLeggins : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Vortex YAAAAs.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Blue;
			item.defense = 30;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 1f;
			player.buffImmune[BuffID.Frostburn] = true;
			player.AddBuff(BuffID.AmmoReservation, 100);


		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<ReinforcedSolarFragment>(), 45);
			recipe.AddIngredient(ItemID.SolarFlareLeggings);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}