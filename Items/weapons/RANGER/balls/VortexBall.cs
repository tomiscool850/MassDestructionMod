using MassDestruction.Items.projectiles;
using MassDestruction.Items.projectiles.RangeP;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.RANGER.balls
{
	public class VortexBall : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vortex Ball");
		}
		public override void SetDefaults()
		{
			// Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
			item.shootSpeed = 20f;
			item.damage = 88;
			item.knockBack = 8f;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useAnimation = 19;
			item.useTime = 19;
			item.width = 30;
			item.height = 30;
			item.maxStack = 999;
			item.rare = ItemRarityID.Blue;

			item.consumable = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.thrown = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(gold: 20);
			// Look at the javelin projectile for a lot of custom code
			// If you are in an editor like Visual Studio, you can hold CTRL and Click ExampleJavelinProjectile
			item.shoot = ModContent.ProjectileType<VortexBallProjectile>();

		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentVortex, 2);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this, 100);
			recipe.AddRecipe();


		}
	}
}