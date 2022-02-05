
using MassDestruction.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.ammo.Arrows
{
	public class PencilArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Wood and lead = pencil but arrow.");
		}

		public override void SetDefaults()
		{
			item.damage = 6;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1f;
			item.value = 1000;
			item.rare = ItemRarityID.Yellow;
			item.shoot = ModContent.ProjectileType<Items.projectiles.AmmoP.PencilArrowProjectile>();   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 6f;                  //The speed of the projectile
			item.ammo = AmmoID.Arrow;              //The ammo class this ammo belongs to.
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 5);
			recipe.AddIngredient(ItemID.LeadBar);
			recipe.AddIngredient(ModContent.ItemType<EraserDust>(), 3);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();


		}
	}
}