
using MassDestruction.Items.placeable.Bar;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.placeable.Door
{
	public class CobaltDoor : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("the Cobalt door Walk into your house with the Black style buy now.\n" +
				"Only 20.99");
		}

		public override void SetDefaults()
		{
			item.width = 14;
			item.height = 28;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.value = 1500;
			item.createTile = ModContent.TileType<Items.tiles.furniture.Doors.CobaltDoorClosedTile>();
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