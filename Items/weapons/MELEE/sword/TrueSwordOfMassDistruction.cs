using Terraria.ID;
using Terraria.ModLoader;
using MassDestruction.Items.projectiles;
using MassDestruction.Items.projectiles.MeleeP;
using MassDestruction.Items.Materials;

namespace MassDestruction.Items.weapons.MELEE.sword
{
	public class TrueSwordOfMassDistruction : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault(" True Sword OF Mass Distruction");
			Tooltip.SetDefault("This was gifted from the gods to you im sure youll need it soon also be careful with this may just destroy your world.");
		}

		public override void SetDefaults()
		{
			item.damage = 1000;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 1;
			item.useAnimation = 1;
			item.useStyle = 1;
			item.knockBack = 20;
			item.value = 1000000000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<TrueSwordOfMassDistructionProjectile>();
			item.scale = 1f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SwordOfMassDistruction>());
			recipe.AddIngredient(ModContent.ItemType<ThanksMessage>());
			recipe.AddIngredient(ItemID.BrokenHeroSword, 500);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
