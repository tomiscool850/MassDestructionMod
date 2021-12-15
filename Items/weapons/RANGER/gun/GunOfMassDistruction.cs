using MassDestruction.Items.placeable.Bar;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.RANGER.gun
{
	public class GunOfMassDistruction : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("MASS GUN GO BRRRRRRRRRRRRRRRRRRRR.");
		}

		public override void SetDefaults()
		{
			item.damage = 200;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 1;
			item.useAnimation = 1;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 100000000;
			item.rare = ItemRarityID.LightPurple;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 25;
			item.shootSpeed = 25f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<InfluxAR>(), 3);
			recipe.AddIngredient(ModContent.ItemType<terraGun>(), 3);
			recipe.AddIngredient(ModContent.ItemType<terraGun>(), 2);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 25);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}