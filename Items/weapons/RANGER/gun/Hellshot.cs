using Terraria.ModLoader;
using Terraria.ID;


namespace MassDestruction.Items.weapons.RANGER.gun
{

	public class Hellshot : ModItem

	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hellshot");
			Tooltip.SetDefault("Phoenix Blaster but way easier to get.");
		}


		public override void SetDefaults()
		{
			item.damage = 19;
			item.ranged = true;
			item.width = 38;
			item.height = 18;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 10000;
			item.rare = 3;
			item.autoReuse = false;
			item.shoot = 5;
			item.shootSpeed = 12f;
			item.useAmmo = AmmoID.Bullet;
		}


		public override void AddRecipes()
		{
			base.AddRecipes();
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}