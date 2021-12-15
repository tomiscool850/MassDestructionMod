using MassDestruction.Items.tiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.RANGER.Luanchers
{
	public class VortexLuancher : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("wow vortex.");
		}

		public override void SetDefaults()
		{
			item.damage = 111;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 7;
			item.value = 1000000;
			item.rare = ItemRarityID.Red;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 12;
			item.shootSpeed = 15;
			item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentVortex, 15);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}