
using MassDestruction.Items.placeable.Bar;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.ammo.Arrows
{
	public class JadeArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("arrow with Jade.");
		}

		public override void SetDefaults()
		{
			item.damage = 19;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 2f;
			item.value = 10000;
			item.rare = ItemRarityID.Green;
			item.shoot = ModContent.ProjectileType<Items.projectiles.AmmoP.JadeArrowProjectile>();  //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 7f;                  //The speed of the projectile
			item.ammo = AmmoID.Arrow;              //The ammo class this ammo belongs to.
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodenArrow, 50);
			recipe.AddIngredient(ModContent.ItemType<JadeBar>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();


		}
	}
}