using MassDestruction.Items.placeable.Bar;
using MassDestruction.Items.placeable.Block;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MELEE.sword
{
	public class ChristmasFighterHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Christmas Fighter Hammer");
			Tooltip.SetDefault("The Spiret of Christmas Damage.");
		}

		public override void SetDefaults()
		{
			item.damage = 97;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 22;
			item.useAnimation = 22;
			item.useStyle = 1;
			item.knockBack = 10.2f;
			item.value = 10000;
			item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PaladinsHammer);
			recipe.AddIngredient(ItemID.CandyCaneSword);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
