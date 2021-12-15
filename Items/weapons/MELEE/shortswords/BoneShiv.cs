using Terraria.ID;
using Terraria.ModLoader;
using MassDestruction.Items.placeable.CraftingStation;

namespace MassDestruction.Items.weapons.MELEE.shortswords
{
	public class BoneShiv : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bone Shiv");
			Tooltip.SetDefault("a shiv of bone.");
		}

		public override void SetDefaults()
		{
			item.damage = 12;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 1;
			item.value = 1000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Bone, 35);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}