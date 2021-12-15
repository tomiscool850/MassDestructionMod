using Terraria.ID;
using Terraria.ModLoader;
using MassDestruction.Items.placeable.CraftingStation;

namespace MassDestruction.Items.weapons.MELEE.shortswords
{
	public class CobaltShortsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cobalt Shortsword");
			Tooltip.SetDefault("cobalt small.");
		}

		public override void SetDefaults()
		{
			item.damage = 36;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 1;
			item.value = 10000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltBar, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}