using MassDestruction.Items.placeable.Bar;
using MassDestruction.Items.placeable.Block;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MELEE.sword
{
	public class BlueCandyCaneSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blue Candy Cane Sword");
			Tooltip.SetDefault("HMMM rasberry.");
		}

		public override void SetDefaults()
		{
			item.damage = 17;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 27;
			item.useAnimation = 27;
			item.useStyle = 1;
			item.knockBack = 5.1f;
			item.value = 5000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<BlueCnadyCaneBlock>(), 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
