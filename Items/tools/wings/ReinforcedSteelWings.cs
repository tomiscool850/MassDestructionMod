using MassDestruction.Items.tiles;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MassDestruction.Items.placeable.Bar;

namespace MassDestruction.Items.tools.wings
{
	[AutoloadEquip(EquipType.Wings)]
	public class ReinforcedSteelWings : ModItem
	{

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Steel wings.");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = 10000;
			item.rare = ItemRarityID.Red;
			item.accessory = true;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 85;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 5f;
			acceleration *= 1.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 25);
			recipe.AddIngredient(ItemID.AngelWings);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}