using MassDestruction.Items.placeable.Bar;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.ammo.Darts
{
	public class JadeDart : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("spikey Jade.");
		}

		public override void SetDefaults()
		{
			item.damage = 17;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 3f;
			item.value = 10000;
			item.rare = ItemRarityID.Red;
			item.shoot = ModContent.ProjectileType<projectiles.AmmoP.JadeDartProjectile>();   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 12f;                  //The speed of the projectile
			item.ammo = AmmoID.Dart;              //The ammo class this ammo belongs to.
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<JadeBar>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}
	}
}