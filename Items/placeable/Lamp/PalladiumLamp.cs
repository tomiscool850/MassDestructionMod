using MassDestruction.Items.placeable.Bar;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.placeable.Lamp
{
	internal class PalladiumLamp : ModItem
	{
		public override void SetDefaults()
		{
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.maxStack = 99;
			item.consumable = true;
			item.createTile = ModContent.TileType<tiles.LightScorces.Lamps.PalladiumLampTile>();
			item.width = 10;
			item.height = 24;
			item.value = 500;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PalladiumBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}