using MassDestruction.Items.tiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.RANGER.Luanchers
{
	public class CopperLuancher : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("meteorite right back to copper:).");
		}

		public override void SetDefaults()
		{
			item.damage = 11; 
			item.ranged = true; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 24; 
			item.useAnimation = 24; 
			item.useStyle = ItemUseStyleID.HoldingOut; 
			item.noMelee = true; 
			item.knockBack = 3; 
			item.value = 1000; 
			item.rare = ItemRarityID.Blue; 
			item.UseSound = SoundID.Item11;
			item.autoReuse = true; 
			item.shoot = 5; 
			item.shootSpeed = 16; 
			item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}