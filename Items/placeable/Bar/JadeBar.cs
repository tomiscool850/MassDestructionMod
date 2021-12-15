using MassDestruction.Items.placeable;
using MassDestruction.Items.placeable.Ore;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.placeable.Bar
{ 
	public class JadeBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("jade, compresed in a rectangle shaped block so...happy to see.");
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
			item.createTile = ModContent.TileType<tiles.BarTile.JadeBarTile>();
			item.placeStyle = 0;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<JadeOre>(), 3);
			recipe.AddTile(TileID.AdamantiteForge);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}