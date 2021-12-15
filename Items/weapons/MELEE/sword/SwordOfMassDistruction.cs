using Terraria.ID;
using Terraria.ModLoader;
using MassDestruction.Items.projectiles;
using MassDestruction.Items.projectiles.MeleeP;

namespace MassDestruction.Items.weapons.MELEE.sword
{
	public class SwordOfMassDistruction : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sword OF Mass Distruction");
			Tooltip.SetDefault("This was gifted from the gods to you im sure youll need it soon.");
		}

		public override void SetDefaults()
		{
			item.damage = 800;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = 1;
			item.knockBack = 18;
			item.value = 1000000000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<SwordOfMassDistructionProjectile>();
			item.scale = 1f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TrueTerraBlade>(), 5);
			recipe.AddIngredient(ModContent.ItemType<TrueInfluxWaver>(), 5);
			recipe.AddIngredient(ModContent.ItemType<TheBladeOfDanger>(), 2);
			recipe.AddIngredient(ModContent.ItemType<TrueBladeOfDanger>());
			recipe.AddIngredient(ItemID.BrokenHeroSword, 50);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
