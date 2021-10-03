
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.Materials
{
	public class BrokenToys : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("WOW you broke it.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 100;
			item.rare = ItemRarityID.Blue;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Toys>());
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);

		}
	}
}