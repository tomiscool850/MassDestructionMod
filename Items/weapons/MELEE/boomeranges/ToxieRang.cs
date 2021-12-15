using IL.Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using MassDestruction.Items.projectiles;
using MassDestruction.Items.projectiles.MeleeP;

namespace MassDestruction.Items.weapons.MELEE.boomeranges
{
	public class ToxieRang : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Toxie Range");
			Tooltip.SetDefault("red range.");
		}

		public override void SetDefaults()
		{
			item.damage = 20;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 3;
			item.noUseGraphic = true;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.scale = 1;
			item.shootSpeed = 10f;
			item.shoot = ModContent.ProjectileType<ToxieRangeProjectile>();
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodenBoomerang);
			recipe.AddIngredient(ItemID.ToxicFlask, 5);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}