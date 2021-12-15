using Terraria.ModLoader;
using Terraria.ID;
using MassDestruction.Items.Materials;
using MassDestruction.Items.placeable.Bar;

namespace MassDestruction.Items.weapons.RANGER.blowpipes
{

	public class SteelBlowgun : ModItem

	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Blowgun");
			Tooltip.SetDefault("wasnt expecting this huh.");
		}


		public override void SetDefaults()
		{
			item.damage = 32;
			item.ranged = true;
			item.width = 38;
			item.height = 18;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 4;
			item.autoReuse = false;
			item.shoot = 5;
			item.shootSpeed = 7f;
			item.useAmmo = AmmoID.Dart;
		}


		public override void AddRecipes()
		{
			base.AddRecipes();
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 5);
			recipe.AddIngredient(ModContent.ItemType<BlowpipeCore>());
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}