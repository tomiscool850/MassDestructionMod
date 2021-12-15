using MassDestruction.Items.tiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.RANGER.Luanchers
{
	public class GoldLuancher : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("meteorite right back to gold:).");
		}

		public override void SetDefaults()
		{
			item.damage = 19;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = ItemRarityID.Yellow;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 5;
			item.shootSpeed = 12;
			item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}