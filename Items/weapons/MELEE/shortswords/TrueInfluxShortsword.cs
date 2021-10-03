using MassDestruction.Items.projectiles;
using MassDestruction.Items.projectiles.MeleeP;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MELEE.shortswords
{
	public class TrueInfluxShortsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True influx Shortsword");
			Tooltip.SetDefault("True Influx short.");
		}

		public override void SetDefaults()
		{
			item.damage = 145;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 23;
			item.useAnimation = 23;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 6.50f;
			item.value = 10000000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.scale = 0.5f;
			item.shoot = ModContent.ProjectileType<TrueInfluxWaverProjectile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TrueInfluxShortsword>());
			recipe.AddIngredient(ItemID.BrokenHeroSword, 2);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}