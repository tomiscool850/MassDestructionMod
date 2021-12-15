using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.Materials
{
	public class Paper : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Dont get a paper cut am i right(forshadowing).");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 100;
			item.rare = ItemRarityID.White;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}