using MassDestruction.Items.projectiles;
using MassDestruction.Items.projectiles.MeleeP;
using MassDestruction.Items.projectiles.RangeP;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.RANGER.javilens
{
	public class FeatherJavilen : ModItem
	{
		public override void SetDefaults()
		{
			// Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
			item.shootSpeed = 8f;
			item.damage = 13;
			item.knockBack = 3f;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useAnimation = 23;
			item.useTime = 23;
			item.width = 30;
			item.height = 30;
			item.maxStack = 999;
			item.rare = ItemRarityID.Cyan;

			item.consumable = true;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.ranged = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(silver: 75);
			// Look at the javelin projectile for a lot of custom code
			// If you are in an editor like Visual Studio, you can hold CTRL and Click ExampleJavelinProjectile
			item.shoot = ModContent.ProjectileType<FeatherJavilenProjectile>();

		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Feather, 5);
			recipe.AddTile(TileID.SkyMill);
			recipe.SetResult(this, 100);
			recipe.AddRecipe();


		}
	}
}