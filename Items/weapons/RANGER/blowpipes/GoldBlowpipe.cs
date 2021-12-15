using Terraria.ModLoader;
using Terraria.ID;
using MassDestruction.Items.Materials;

namespace MassDestruction.Items.weapons.RANGER.blowpipes
{

	public class GoldBlowpipe : ModItem

	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("gold Blowpipe");
			Tooltip.SetDefault("wasnt expecting this huh.");
		}


		public override void SetDefaults()
		{
			item.damage = 16;
			item.ranged = true;
			item.width = 38;
			item.height = 18;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 3;
			item.value = 5000;
			item.rare = 3;
			item.autoReuse = false;
			item.shoot = 6;
			item.shootSpeed = 6f;
			item.useAmmo = AmmoID.Dart;
		}


		public override void AddRecipes()
		{
			base.AddRecipes();
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GoldBar, 8);
			recipe.AddIngredient(ModContent.ItemType<BlowpipeCore>());
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}