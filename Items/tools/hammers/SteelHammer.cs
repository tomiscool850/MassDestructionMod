using MassDestruction.Items.placeable.Bar;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.tools.hammers
{
	public class SteelHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Steel ham.");
		}

		public override void SetDefaults()
		{
			item.damage = 8;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;       //How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5
			item.hammer = 70;      //How much hammer power the weapon has
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 3;
			item.value = 10000;
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 10);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}