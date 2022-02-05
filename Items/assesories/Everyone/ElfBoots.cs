using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.assesories.Everyone
{
	public class ElfBoots : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Elf boots");
			Tooltip.SetDefault("a worker of claus");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 24;
			item.accessory = true; // Makes this item an accessory.
			item.rare = ItemRarityID.Red;
			item.value = Item.sellPrice(gold: 5); // Sets the item sell price to one gold coin.
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.accRunSpeed = 5f; // The player's maximum run speed with accessories
			player.moveSpeed += 3f; // The acceleration multiplier of the player's movement speed
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LightningBoots);
			recipe.AddIngredient(ItemID.CandyCaneBlock, 10);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}