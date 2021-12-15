using MassDestruction.Items.tiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.RANGER.Luanchers
{
	public class TitaniumLuancher : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("rockets right back to Titanium:).");
		}

		public override void SetDefaults()
		{
			item.damage = 42;
			item.ranged = true; 
			item.width = 40; 
			item.height = 20; 
			item.useTime = 15; 
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.HoldingOut; 
			item.noMelee = true; 
			item.knockBack = 3; 
			item.value = 100000; 
			item.rare = ItemRarityID.Red; 
			item.UseSound = SoundID.Item11; 
			item.autoReuse = true;
			item.shoot = 5;
			item.shootSpeed = 16; 
			item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TitaniumBar, 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}