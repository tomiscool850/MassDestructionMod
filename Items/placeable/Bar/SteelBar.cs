using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.placeable.Bar
{
	public class SteelBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			
				Tooltip.SetDefault("steel, made of lead/iron and obsidean and can stand lava.");

			ItemID.Sets.SortingPriorityMaterials[item.type] = 59; // influences the inventory sort order. 59 is PlatinumBar, higher is more valuable.
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = 750;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.consumable = true;
			item.createTile = ModContent.TileType<tiles.BarTile.SteelBarTile>();
			item.placeStyle = 0;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar,2);
			recipe.AddIngredient(ItemID.Obsidian);
			recipe.AddIngredient(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 2);
			recipe.AddIngredient(ItemID.Obsidian);
			recipe.AddIngredient(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}