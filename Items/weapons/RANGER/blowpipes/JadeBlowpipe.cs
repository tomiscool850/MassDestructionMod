using Terraria.ModLoader;
using Terraria.ID;
using MassDestruction.Items.Materials;
using MassDestruction.Items.placeable.Bar;

namespace MassDestruction.Items.weapons.RANGER.blowpipes
{

	public class JadeBlowpipe : ModItem

	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jade Blowpipe");
			Tooltip.SetDefault("this jade blowpipe can give a nice dart.");
		}


		public override void SetDefaults()
		{
			item.damage = 44;
			item.ranged = true;
			item.width = 38;
			item.height = 18;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 100000;
			item.rare = 3;
			item.autoReuse = false;
			item.shoot = 7;
			item.shootSpeed = 10f;
			item.useAmmo = AmmoID.Dart;
		}


		public override void AddRecipes()
		{
			base.AddRecipes();
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<BlowpipeCore>());
			recipe.AddIngredient(ModContent.ItemType<JadeBar>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}