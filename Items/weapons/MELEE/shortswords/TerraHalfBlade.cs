using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MELEE.shortswords
{
	public class TerraHalfBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Terra Half Blade");
			Tooltip.SetDefault("Terra is now small.");
		}

		public override void SetDefaults()
		{
			item.damage = 112;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 4.8f;
			item.value = 1000000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.scale = 0.5f;
			item.shoot = ProjectileID.TerraBeam;
			item.shootSpeed = 10f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TrueNightsSmallBlade>());
			recipe.AddIngredient(ModContent.ItemType<TrueExcaliberStabber>());
			recipe.AddIngredient(ItemID.BrokenHeroSword);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}