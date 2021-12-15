using Terraria;
using Terraria.ID;
using MassDestruction.Items.tiles;
using Terraria.Localization;
using Terraria.ModLoader;
using MassDestruction.Items.placeable.Bar;

namespace MassDestruction.Items.placeable.Block
{
	public class AdamantitePlating : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("all plating of adamantite.");
			ItemID.Sets.ExtractinatorMode[item.type] = item.type;

			// This is an example of how translations are coded into the game. Making your mod Open Source is a good way to enlist help with translations and make your mod more popular worldwide. Be sure to have "using Terraria.Localization".

		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.createTile = ModContent.TileType<tiles.blocks.AdamantitePlatingTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock);
			recipe.AddIngredient(ItemID.AdamantiteBar);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}
