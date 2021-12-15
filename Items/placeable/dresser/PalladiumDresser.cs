using MassDestruction.Items.placeable.Bar;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.placeable.dresser
{
	public class PalladiumDresser : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("swich your hair switch your shirt, do it with Palladium tho.");
		}

		public override void SetDefaults()
		{
			item.width = 26;
			item.height = 22;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 5000;
			item.createTile = ModContent.TileType<Items.tiles.furniture.Dressers.PalladiumDresserTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Dresser);
			recipe.AddIngredient(ItemID.PalladiumBar, 5);
			recipe.AddIngredient(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}