using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MELEE.Katanas
{
	public class WoodKatana : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wood Katana");
			Tooltip.SetDefault("Wood is very fast.");
		}

		public override void SetDefaults()
		{
			item.damage = 7;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 8;
			item.useAnimation = 8;
			item.useStyle = 1;
			item.knockBack = 0;
			item.value = 100;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}