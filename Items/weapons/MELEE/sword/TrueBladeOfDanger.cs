using Terraria.ID;
using Terraria.ModLoader;
using MassDestruction.Items.projectiles;
using MassDestruction.Items.projectiles.MeleeP;

namespace MassDestruction.Items.weapons.MELEE.sword
{
	public class TrueBladeOfDanger : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Blade of Danger");
			Tooltip.SetDefault("very powerful big purple sword and very powerful.");
		}

		public override void SetDefaults()
		{
			item.damage = 650;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 1000000000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<BladeOfDangerProjectile>();
			item.scale = 0.8f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TrueTerraBlade>(), 5);
			recipe.AddIngredient(ModContent.ItemType<TrueInfluxWaver>(), 5);
			recipe.AddIngredient(ModContent.ItemType<TheBladeOfDanger>());
			recipe.AddIngredient(ItemID.BrokenHeroSword, 25);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
