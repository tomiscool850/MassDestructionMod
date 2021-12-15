using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.ammo.Bullets
{
	public class PlatinumBullet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Platinum balls.");
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
			item.rare = ItemRarityID.Red;
			item.shoot = ModContent.ProjectileType<projectiles.AmmoP.PlatinumBulletProjectile>();   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 15f;                  //The speed of the projectile
			item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MusketBall, 50);
			recipe.AddIngredient(ItemID.PlatinumBar);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}
	}
}