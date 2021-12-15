using Terraria.ModLoader;
using Terraria.ID;
using MassDestruction.Items.Materials;

namespace MassDestruction.Items.weapons.RANGER.blowpipes
{

	public class TitaniumBlowpipe : ModItem

	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Titanium Blowpipe");
			Tooltip.SetDefault("wasnt expecting this huh.");
		}


		public override void SetDefaults()
		{
			item.damage = 59;
			item.ranged = true;
			item.width = 38;
			item.height = 18;
			item.useTime = 18;
			item.useAnimation = 18;
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
			recipe.AddIngredient(ItemID.TitaniumBar, 8);
			recipe.AddIngredient(ModContent.ItemType<BlowpipeCore>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}