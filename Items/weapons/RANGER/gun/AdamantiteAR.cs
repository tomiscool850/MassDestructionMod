using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.RANGER.gun
{
	public class AdamantiteAR : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("pew pew pew ar.");
		}

		public override void SetDefaults()
		{
			item.damage = 46;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = ItemRarityID.Blue;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 15f;
			item.useAmmo = AmmoID.Bullet;
			item.scale = 0.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AdamantiteBar, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}