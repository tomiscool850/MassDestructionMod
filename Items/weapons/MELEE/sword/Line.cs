
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MELEE.sword
{
	public class Line : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Line");
			Tooltip.SetDefault("very slim.");
		}

		public override void SetDefaults()
		{
			item.damage = 2;
			item.melee = true;
			item.width = 10;
			item.height = 10;
			item.useTime = 5;
			item.useAnimation = 5;
			item.useStyle = 1;
			item.knockBack = 0;
			item.value = 10;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;    
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BlackLens);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}