using Terraria.ID;
using Terraria.ModLoader;
using MassDestruction.Items.projectiles;
using MassDestruction.Items.projectiles.MeleeP;

namespace MassDestruction.Items.weapons.MELEE.sword
{
	public class TheBladeOfDanger : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blade of Danger");
			Tooltip.SetDefault("very big purple sword and very powerful.");
		}

		public override void SetDefaults()
		{
			item.damage = 500;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 1000000000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<BladeOfDangerProjectile>();
			item.scale = 0.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TrueTerraBlade>(), 2);
			recipe.AddIngredient(ModContent.ItemType<TrueInfluxWaver>());
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
