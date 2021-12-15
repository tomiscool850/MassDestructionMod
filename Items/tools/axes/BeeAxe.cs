
using MassDestruction.Items.placeable.Bar;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.tools.axes
{
	public class BeeAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Bee Axe.");
		}

		public override void SetDefaults()
		{
			item.damage = 6;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;       //How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5
			item.axe = 11;      //How much hammer power the weapon has
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 3;
			item.value = 8000;
			item.rare = ItemRarityID.Yellow;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HoneyBlock, 8);
			recipe.AddIngredient(ItemID.Hive, 8);
			recipe.AddTile(TileID.HoneyDispenser);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}