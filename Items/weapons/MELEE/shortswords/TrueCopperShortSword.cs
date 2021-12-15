
using MassDestruction.Items.projectiles.MeleeP;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MELEE.shortswords
{
	public class TrueCopperShortSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Copper Shortsword");
			Tooltip.SetDefault("true copper yes.");
		}

		public override void SetDefaults()
		{
			item.damage = 80;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.knockBack = 4;
			item.value = 1000000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.scale = 0.5f;
			item.shoot = ModContent.ProjectileType<TrueCopperShortswordProjectile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperShortsword, 1);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 2);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}