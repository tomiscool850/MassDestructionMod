using MassDestruction.Items.tiles;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MassDestruction.Items.armor.chestplates;
using MassDestruction.Items.armor.leggins;

namespace MassDestruction.Items.armor.helmets
{
	[AutoloadEquip(EquipType.Head)]
	public class LuminiteHelmet: ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("everyone can use it.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 10000000;
			item.rare = ItemRarityID.Red;
			item.defense = 19;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<LuminiteBreastPlate>() && legs.type == ModContent.ItemType<LuminiteLeggins>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "adds 25% damage to all classes except melee and range witch is 50% then\n " +
				"also gives mages 100 more mana and summoner 2 more slots";
			player.allDamage -= 0.2f;
			
			player.meleeDamage += 0.5f;
			player.rangedDamage += 0.25f;
			player.magicDamage += 0.25f;
			player.minionDamage += 0.25f;
			player.statManaMax2 += 100;
			player.maxMinions += 2;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 25);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}