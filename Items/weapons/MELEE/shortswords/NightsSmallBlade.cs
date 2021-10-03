using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MELEE.shortswords
{
	public class NightsSmallBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nights Small Blade");
			Tooltip.SetDefault("Nigth is small.");
		}

		public override void SetDefaults()
		{
			item.damage = 38;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 3;
			item.value = 100000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.scale = 3f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<JungleSmallSword>());
			recipe.AddIngredient(ModContent.ItemType<FlameBurster>());
			recipe.AddIngredient(ModContent.ItemType<DemoniteStabber>());
			recipe.AddIngredient(ModContent.ItemType<BlueShorty>());
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<JungleSmallSword>());
			recipe.AddIngredient(ModContent.ItemType<FlameBurster>());
			recipe.AddIngredient(ModContent.ItemType<CrimtaneShortsword>());
			recipe.AddIngredient(ModContent.ItemType<BlueShorty>());
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}