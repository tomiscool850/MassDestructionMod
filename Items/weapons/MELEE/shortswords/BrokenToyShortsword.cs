using Terraria.ID;
using Terraria.ModLoader;
using MassDestruction.Items.placeable.CraftingStation;
using MassDestruction.Items.Materials;

namespace MassDestruction.Items.weapons.MELEE.shortswords
{
	public class BrokenToyShortsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Broken Toy Shortsword");
			Tooltip.SetDefault("a broken toy shortsword.");
		}

		public override void SetDefaults()
		{
			item.damage = 14;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 1;
			item.value = 1000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<BrokenToys>());
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}