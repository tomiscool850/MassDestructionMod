
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MELEE.sword
{
	public class FeatherBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Feather Sword");
			Tooltip.SetDefault("Sword of the Feathers.");
		}

		public override void SetDefaults()
		{
			item.damage = 17;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 8;
			item.useAnimation = 8;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 5000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Feather, 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}