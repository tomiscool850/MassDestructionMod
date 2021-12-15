using MassDestruction.Items.placeable.Bar;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.ammo.Darts
{
	public class SteelDart : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("spikey Steel.");
		}

		public override void SetDefaults()
		{
			item.damage = 8;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 3f;
			item.value = 10000;
			item.rare = ItemRarityID.White;
			item.shoot = ModContent.ProjectileType<projectiles.AmmoP.SteelDartProjectile>();   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 7f;                  //The speed of the projectile
			item.ammo = AmmoID.Dart;              //The ammo class this ammo belongs to.
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}
	}
}