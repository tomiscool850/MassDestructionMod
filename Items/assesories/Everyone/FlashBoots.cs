using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.assesories.Everyone
{
	[AutoloadEquip(EquipType.Shoes)]
	public class FlashBoots : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flash boots");
			Tooltip.SetDefault("you are now flash");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 24;
			item.accessory = true; // Makes this item an accessory.
			item.rare = ItemRarityID.Red;
			item.value = Item.sellPrice(gold: 10); // Sets the item sell price to one gold coin.
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.accRunSpeed = 18f; // The player's maximum run speed with accessories
			player.moveSpeed += 5f; // The acceleration multiplier of the player's movement speed
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FrostsparkBoots);
			recipe.AddIngredient(ItemID.LightningBoots, 2);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}