using MassDestruction.Items;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.Materials
{
	public class ReinforcedSolarFragment : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("this is for some amazing armor in the furture.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 10000000;
			item.rare = ItemRarityID.Red;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentSolar);
			recipe.AddIngredient(ModContent.ItemType<ReinforcedSoul>(), 3);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}
	}
}