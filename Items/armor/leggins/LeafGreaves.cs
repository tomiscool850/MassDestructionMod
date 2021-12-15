
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MassDestruction.Items.placeable.Bar;

namespace MassDestruction.Items.armor.leggins
{
	[AutoloadEquip(EquipType.Legs)]
	public class LeafGreaves : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("you feel even lighter");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1000;
			item.rare = ItemRarityID.Green;
			item.defense = 3;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.2f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeafWand);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}