using Terraria.ID;
using Terraria.ModLoader;
using MassDestruction.Items.placeable.CraftingStation;

namespace MassDestruction.Items.weapons.MELEE.shortswords
{
	public class BlueShorty : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blue Shorty");
			Tooltip.SetDefault("the big dugion blue thing but smaller.");
		}

		public override void SetDefaults()
		{
			item.damage = 22;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 2;
			item.value = 100000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Muramasa);
			recipe.AddTile(ModContent.TileType<Items.tiles.CraftingStations.CutterStationTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}