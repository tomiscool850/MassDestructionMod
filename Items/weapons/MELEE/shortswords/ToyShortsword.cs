using MassDestruction.Items.Materials;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MELEE.shortswords
{
	public class ToyShortsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Toy Shortsword");
			Tooltip.SetDefault("Have you ever wanted your son to be a adventure well we have you this toy sword.");
		}

		public override void SetDefaults()
		{
			item.damage = 13;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 1;
			item.value = 1000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Toys>(), 7);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}