using MassDestruction.Items.tiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.RANGER.Luanchers
{
	public class TinLuancher : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This is a modded gun.");
		}

		public override void SetDefaults()
		{
			item.damage = 10; 
			item.ranged = true; 
			item.width = 40; 
			item.height = 20;
			item.useTime = 24; 
			item.useAnimation = 24; 
			item.useStyle = ItemUseStyleID.HoldingOut; 
			item.noMelee = true; 
			item.knockBack = 4; 
			item.value = 1000; 
			item.rare = ItemRarityID.Blue; 
			item.UseSound = SoundID.Item11; 
			item.autoReuse = true; 
			item.shoot = 5; 
			item.shootSpeed = 16f; 
			item.useAmmo = AmmoID.Arrow; 
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}