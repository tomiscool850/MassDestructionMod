using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MELEE.shortswords
{
	public class FlameBurster : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flame Burster");
			Tooltip.SetDefault("Fire smells weird.");
		}

		public override void SetDefaults()
		{
			item.damage = 36;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 27;
			item.useAnimation = 27;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 4.8f;
			item.value = 10000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}