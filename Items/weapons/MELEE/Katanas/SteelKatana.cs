using MassDestruction.Items.placeable.Bar;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MELEE.Katanas
{
	public class SteelKatana : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Katana");
			Tooltip.SetDefault("Steel but fast.");
		}

		public override void SetDefaults()
		{
			item.damage = 23;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 13;
			item.useAnimation = 13;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
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
