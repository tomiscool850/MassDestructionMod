using Terraria.ModLoader;
using Terraria.ID;
using MassDestruction.Items.Materials;

namespace MassDestruction.Items.weapons.RANGER.blowpipes
{

	public class AdamantiteBlowpipe : ModItem

	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Adamantite Blowpipe");
			Tooltip.SetDefault("wasnt expecting this huh.");
		}


		public override void SetDefaults()
		{
			item.damage = 60;
			item.ranged = true;
			item.width = 38;
			item.height = 18;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 100000;
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
			recipe.AddIngredient(ItemID.AdamantiteBar, 8);
			recipe.AddIngredient(ModContent.ItemType<BlowpipeCore>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}