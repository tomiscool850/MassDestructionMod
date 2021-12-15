
using MassDestruction.Items.placeable.Bar;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.placeable.Bed
{
	public class CobaltBed : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("must be Hard to sleep at night on this.");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 20;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 2000;
			item.createTile = ModContent.TileType<tiles.furniture.Beds.CobaltBedTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}