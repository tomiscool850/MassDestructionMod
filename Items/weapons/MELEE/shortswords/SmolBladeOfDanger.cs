using Terraria.ID;
using Terraria.ModLoader;
using MassDestruction.Items.projectiles;
using MassDestruction.Items.projectiles.MeleeP;

namespace MassDestruction.Items.weapons.MELEE.shortswords
{
	public class SmolBladeOfDanger : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("smol Blade of Danger");
			Tooltip.SetDefault("very small purple sword and very powerful.");
		}

		public override void SetDefaults()
		{
			item.damage = 480;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 7;
			item.value = 100000000;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<BladeOfDangerProjectile>();
			item.scale = 0.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TrueInfluxShortsword>(), 2);
			recipe.AddIngredient(ModContent.ItemType<TrueTerraHalfBlade>());
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
