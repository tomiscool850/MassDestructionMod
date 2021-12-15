using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MELEE.shortswords
{
	public class ShortswordSpammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shortsword Spammer");
			Tooltip.SetDefault("This shortsword spam ye.");
		}

		public override void SetDefaults()
		{
			item.damage = 2;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 2;
			item.useAnimation = 2;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 0;
			item.value = 1000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.scale = 1.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BlackLens);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}