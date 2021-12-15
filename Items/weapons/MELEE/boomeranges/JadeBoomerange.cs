using IL.Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using MassDestruction.Items.projectiles;
using MassDestruction.Items.projectiles.MeleeP;
using MassDestruction.Items.placeable.Bar;

namespace MassDestruction.Items.weapons.MELEE.boomeranges
{
	public class JadeBoomerange : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jade Boomerange");
			Tooltip.SetDefault("Green range.");
		}

		public override void SetDefaults()
		{
			item.damage = 45;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 4;
			item.noUseGraphic = true;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.scale = 1;
			item.shootSpeed = 12f;
			item.shoot = ModContent.ProjectileType<JadeBoomerangeProjectile>();
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<JadeBar>());
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}