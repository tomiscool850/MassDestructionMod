
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.ammo.Arrows
{
	public class SwordArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("sword on arrow.");
		}

		public override void SetDefaults()
		{
			item.damage = 8;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = 1000;
			item.rare = ItemRarityID.Green;
			item.shoot = ModContent.ProjectileType<Items.projectiles.AmmoP.SwordArrowProjectile>();   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 8f;                  //The speed of the projectile
			item.ammo = AmmoID.Arrow;              //The ammo class this ammo belongs to.
		}

		// Give each bullet consumed a 20% chance of granting the Wrath buff for 5 seconds
		public override void OnConsumeAmmo(Player player)
		{
			if (Main.rand.NextBool(5))
			{
				player.AddBuff(BuffID.Bleeding, 300);
			}
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodenArrow, 50);
			recipe.AddIngredient(ItemID.LeadBar);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodenArrow, 50);
			recipe.AddIngredient(ItemID.IronBar);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();


		}
	}
}