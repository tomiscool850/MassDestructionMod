
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MassDestruction.Items.placeable.Bar;

namespace MassDestruction.Items.armor.leggins
{
	[AutoloadEquip(EquipType.Legs)]
	public class SteelLeggins : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("MORE SPEED.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.defense = 5;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 12);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}