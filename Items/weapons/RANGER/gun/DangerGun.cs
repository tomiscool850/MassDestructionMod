using MassDestruction.Items.placeable.Bar;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.RANGER.gun
{
	public class DangerGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Danger GUN GO BRRRRRRRRRRRRRRRRRRRR.");
		}

		public override void SetDefaults()
		{
			item.damage = 105;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 2;
			item.useAnimation = 2;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 3;
			item.value = 1000000;
			item.rare = ItemRarityID.Cyan;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 20;
			item.shootSpeed = 20f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<InfluxAR>());
			recipe.AddIngredient(ModContent.ItemType<terraGun>());
			recipe.AddIngredient(ItemID.BrokenHeroSword, 5);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}