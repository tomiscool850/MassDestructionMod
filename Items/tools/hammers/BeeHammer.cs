
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.tools.hammers
{
	public class BeeHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("honey and the hive be kinda smashing.");
		}

		public override void SetDefaults()
		{
			item.damage = 11;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;         //How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5
			item.hammer = 60;      //How much hammer power the weapon has
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 3;
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