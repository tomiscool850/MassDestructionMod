
using MassDestruction.Items.tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.tools.picks
{
	public class BeePick : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("honey and comb are mine.");
		}

		public override void SetDefaults()
		{
			item.damage = 7;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.pick = 65;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 2;
			item.value = 1000;
			item.rare = ItemRarityID.Yellow;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HoneyBlock, 10);
			recipe.AddIngredient(ItemID.Hive, 15);
			recipe.AddTile(TileID.HoneyDispenser);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


	}
}