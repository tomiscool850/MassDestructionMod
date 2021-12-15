using Terraria.ID;
using Terraria.ModLoader;
using MassDestruction.Items.projectiles;
using MassDestruction.Items.projectiles.MeleeP;

namespace MassDestruction.Items.weapons.MELEE.shortswords
{
	public class SmolSwordOfMassDistruction : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("smol Sword Of Mass Distruction");
			Tooltip.SetDefault("this was a side gift from the gods you may need it.");
		}

		public override void SetDefaults()
		{
			item.damage = 750;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 7;
			item.value = 100000000;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<SwordOfMassDistructionProjectile>();
			item.scale = 1f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TrueInfluxShortsword>(), 5);
			recipe.AddIngredient(ModContent.ItemType<TrueTerraHalfBlade>(), 5);
			recipe.AddIngredient(ModContent.ItemType<SmolBladeOfDanger>());
			recipe.AddIngredient(ModContent.ItemType<TrueSmolBladeOfDanger>());
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
