using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.RANGER.gun
{
	public class terraGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("TERRA GUN GO BRRRRRRRRRRRRRRRRRRRR.");
		}

		public override void SetDefaults()
		{
			item.damage = 70;
			item.ranged = true; 
			item.width = 40;
			item.height = 40; 
			item.useTime = 5; 
			item.useAnimation = 5; 
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 3; 
			item.value = 100000; 
			item.rare = ItemRarityID.Green; 
			item.UseSound = SoundID.Item11; 
			item.autoReuse = true; 
			item.shoot = 10; 
			item.shootSpeed = 15f; 
			item.useAmmo = AmmoID.Bullet; 
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<NightsGun>());
			recipe.AddIngredient(ModContent.ItemType<HallowPistal>());
			recipe.AddIngredient(ItemID.BrokenHeroSword);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}