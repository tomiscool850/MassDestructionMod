using MassDestruction.Items.tiles;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MassDestruction.Items.placeable.Bar;
using MassDestruction.Items.placeable.Block;

namespace MassDestruction.Items.tools.wings
{
	[AutoloadEquip(EquipType.Wings)]
	public class DevilIceWings : ModItem
	{

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Devil Ice wings.");
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
			player.wingTimeMax = 110;
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising,
			ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.95f;
			ascentWhenRising = 0.25f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.150f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 6.5f;
			acceleration *= 3f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<DevilIce>(), 25);
			recipe.AddIngredient(ItemID.DemonWings);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}