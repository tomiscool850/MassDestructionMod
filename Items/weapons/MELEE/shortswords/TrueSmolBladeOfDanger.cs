using Terraria.ID;
using Terraria.ModLoader;
using MassDestruction.Items.projectiles;
using MassDestruction.Items.projectiles.MeleeP;

namespace MassDestruction.Items.weapons.MELEE.shortswords
{
	public class TrueSmolBladeOfDanger : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True smol Blade of Danger");
			Tooltip.SetDefault("very powerful small purple sword and very powerful.");
		}

		public override void SetDefaults()
		{
			item.damage = 600;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 7;
			item.value = 100000000;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<BladeOfDangerProjectile>();
			item.scale = 0.8f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TrueInfluxShortsword>(), 3);
			recipe.AddIngredient(ModContent.ItemType<TrueTerraHalfBlade>(), 3);
			recipe.AddIngredient(ModContent.ItemType<SmolBladeOfDanger>());
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
