using Terraria.ID;
using Terraria.ModLoader;
using MassDestruction.Items.placeable.CraftingStation;
using MassDestruction.Items.Materials;

namespace MassDestruction.Items.weapons.MELEE.shortswords
{
	public class Eraser : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Eraser");
			Tooltip.SetDefault("Erases Stuff.");
		}

		public override void SetDefaults()
		{
			item.damage = 50;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 1;
			item.useAnimation = 1;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 0;
			item.value = 10000000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.scale = 2f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<EraserDust>(), 80);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}