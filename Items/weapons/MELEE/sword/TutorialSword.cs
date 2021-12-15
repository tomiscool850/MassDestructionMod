using MassDestruction.Items.weapons.RANGER.bows;
using MassDestruction.Items.weapons.MAGES.wands;
using Terraria.ID;
using Terraria.ModLoader;
using MassDestruction.Items.Materials;

namespace MassDestruction.Items.weapons.MELEE.sword
{
	public class TutorialSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tutorial Sword");
			Tooltip.SetDefault("wow you beat me now im apart of you FOREVER;).");
		}

		public override void SetDefaults()
		{
			item.damage = 5;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 24;
			item.useAnimation = 24;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 100;
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
			item.scale = 1;
			item.scale = 0.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TutorialBow>());
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TutorialWand>());
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TutorialPeices>(), 8);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}