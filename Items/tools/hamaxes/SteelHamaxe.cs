
using MassDestruction.Items.placeable.Bar;
using MassDestruction.Items.tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.tools.hamaxes
{
	public class SteelHamaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Steel Hamaxe.");
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.axe = 15;          //How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5
			item.hammer = 80;      //How much hammer power the weapon has
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}