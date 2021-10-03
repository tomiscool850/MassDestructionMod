using MassDestruction.Items.tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.ammo.Rockets
{
	public class PreHardModeRocket : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("use with copper and tin luanchers.");
		}

		public override void SetDefaults()
		{
			item.damage = 5;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 4f;
			item.value = 1000;
			item.rare = ItemRarityID.LightRed;
			item.shootSpeed = 8f;                  //The speed of the projectile             //The ammo class this ammo belongs to
			item.ammo = AmmoID.Rocket;
		}


		// Give each bullet consumed a 20% chance of granting the Wrath buff for 5 seconds


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MeteoriteBar, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}
	}
}