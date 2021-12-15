
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MassDestruction.Items.placeable.Bar;

namespace MassDestruction.Items.armor.leggins
{
	[AutoloadEquip(EquipType.Legs)]
	public class RainyCloudGreaves : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("speed and Feather Fallin.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1000;
			item.rare = ItemRarityID.Gray;
			item.defense = 4;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.2f;
			player.AddBuff(BuffID.Featherfall, 100);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RainCloud, 15);
			recipe.AddTile(TileID.SkyMill);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}