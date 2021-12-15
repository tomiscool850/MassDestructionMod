
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.tools.hammers
{
	public class BurningHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("hammer of fire.");
		}

		public override void SetDefaults()
		{
			item.damage = 15;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;         //How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5
			item.hammer = 90;      //How much hammer power the weapon has
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.knockBack = 4;
			item.value = 25000;
			item.rare = ItemRarityID.Red;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Obsidian, 10);
			recipe.AddIngredient(ItemID.LavaBucket);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}