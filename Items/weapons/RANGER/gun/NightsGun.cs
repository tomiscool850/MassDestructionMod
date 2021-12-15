using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.RANGER.gun
{
	public class NightsGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("pew pew night.");
		}

		public override void SetDefaults()
		{
			item.damage = 18;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 3;
			item.value = 100000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 18f;
			item.useAmmo = AmmoID.Bullet;
			item.scale = 0.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Boomstick, 1);
			recipe.AddIngredient(ItemID.FlintlockPistol, 1);
			recipe.AddIngredient(ItemID.Musket, 1);
			recipe.AddIngredient(ItemID.PhoenixBlaster, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Boomstick, 1);
			recipe.AddIngredient(ItemID.FlintlockPistol, 1);
			recipe.AddIngredient(ItemID.TheUndertaker, 1);
			recipe.AddIngredient(ItemID.PhoenixBlaster, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}