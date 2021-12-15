using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MELEE.shortswords
{
	public class SeedlerShortsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Seedler Shortsword");
			Tooltip.SetDefault("Seedler Shortsword yes.");
		}

		public override void SetDefaults()
		{
			item.damage = 52;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 8;
			item.useAnimation = 8;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ProjectileID.SeedlerThorn;
			item.scale = 2f;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Seedler);
			recipe.AddTile(ModContent.TileType<Items.tiles.CraftingStations.CutterStationTile>());
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}