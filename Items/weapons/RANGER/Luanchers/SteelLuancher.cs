using MassDestruction.Items.placeable.Bar;
using MassDestruction.Items.tiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.RANGER.Luanchers
{
	public class SteelLuancher : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("rockets right back to Steel:).");
		}

		public override void SetDefaults()
		{
			item.damage = 29;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 5;
			item.shootSpeed = 15;
			item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 8);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}