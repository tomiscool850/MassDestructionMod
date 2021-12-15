using MassDestruction.Items.tiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.RANGER.Luanchers
{
	public class CobaltLuancher : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("rockets right back to Cobalt:).");
		}

		public override void SetDefaults()
		{
			item.damage = 36;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 3;
			item.value = 100000;
			item.rare = ItemRarityID.Blue;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 6;
			item.shootSpeed = 16;
			item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltBar, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}