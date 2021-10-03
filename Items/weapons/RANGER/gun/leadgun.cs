using Terraria.ModLoader;
using Terraria.ID;


namespace MassDestruction.Items.weapons.RANGER.gun
{

	public class leadgun : ModItem

	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("lead gun");
			Tooltip.SetDefault("gun of lead.");
		}


		public override void SetDefaults()
		{
			item.damage = 13;
			item.ranged = true;
			item.width = 38;
			item.height = 18;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 1000;
			item.rare = 2;
			item.autoReuse = false;
			item.shoot = 5;
			item.shootSpeed = 12f;
			item.useAmmo = AmmoID.Bullet;
		}


		public override void AddRecipes()
		{
			base.AddRecipes();
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar, 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}