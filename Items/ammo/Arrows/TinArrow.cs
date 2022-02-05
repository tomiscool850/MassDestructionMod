
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.ammo.Arrows
{
	public class TinArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Tin on arrow.");
		}

		public override void SetDefaults()
		{
			item.damage = 4;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = 1000;
			item.rare = ItemRarityID.Orange;
			item.shoot = ModContent.ProjectileType<Items.projectiles.AmmoP.TinArrowProjectile>();   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 9f;                  //The speed of the projectile
			item.ammo = AmmoID.Arrow;              //The ammo class this ammo belongs to.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodenArrow, 25);
			recipe.AddIngredient(ItemID.TinBar);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();


		}
	}
}