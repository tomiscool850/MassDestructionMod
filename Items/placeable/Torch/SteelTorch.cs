using MassDestruction.Dusts;
using MassDestruction.Items.placeable.Bar;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.placeable.Torch
{
	public class SteelTorch : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Torch with Steel flames.");
		}

		public override void SetDefaults()
		{
			item.width = 10;
			item.height = 12;
			item.maxStack = 99;
			item.holdStyle = 1;
			item.noWet = true;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.consumable = true;
			item.createTile = ModContent.TileType<tiles.LightScorces.Torchs.SteelTorchTile>();
			item.flame = true;
			item.value = 5000;
		}

		public override void HoldItem(Player player)
		{
			if (Main.rand.Next(player.itemAnimation > 0 ? 40 : 80) == 0)
			{
			}
			Vector2 position = player.RotatedRelativePoint(new Vector2(player.itemLocation.X + 12f * player.direction + player.velocity.X, player.itemLocation.Y - 14f + player.velocity.Y), true);
			Lighting.AddLight(position, 1f, 1f, 1f);
		}

		public override void PostUpdate()
		{
			if (!item.wet)
			{
				Lighting.AddLight((int)((item.position.X + item.width / 2) / 16f), (int)((item.position.Y + item.height / 2) / 16f), 1f, 1f, 1f);
			}
		}

		public override void AutoLightSelect(ref bool dryTorch, ref bool wetTorch, ref bool glowstick)
		{
			dryTorch = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Torch, 3);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 2);
			recipe.SetResult(this, 3);
			recipe.AddRecipe();
		}
	}
}