using Terraria.ID;
using Terraria.ModLoader;
using MassDestruction.Items.placeable.CraftingStation;
using MassDestruction.Items.Materials;
using MassDestruction.Items.placeable.Bar;

namespace MassDestruction.Items.weapons.MELEE.shortswords
{
	public class SteelShortsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Shortsword");
			Tooltip.SetDefault("Short steel.");
		}

		public override void SetDefaults()
		{
			item.damage = 30;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 5);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}