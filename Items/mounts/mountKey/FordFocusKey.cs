using MassDestruction.Items.Materials;
using MassDestruction.Items.mounts.mount;
using MassDestruction.Items.tiles;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.mounts.mountKey
{
	public class FordFocusKey : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("yo the super fast ford focus se.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 30;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = 30000;
			item.rare = ItemRarityID.Red;
			item.UseSound = SoundID.Item79;
			item.noMelee = true;
			item.mountType = ModContent.MountType<FordFocusSE>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Equast>(), 2);
			recipe.AddIngredient(ModContent.ItemType<Wheel>(), 4);
			recipe.AddIngredient(ModContent.ItemType<SteeringWheel>());
			recipe.AddIngredient(ItemID.BluePaint, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}