using MassDestruction.Items.tiles;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using MassDestruction.Items;
using MassDestruction.Items.armor.chestplates;
using MassDestruction.Items.armor.leggins;
using MassDestruction.Items.placeable.Bar;
using MassDestruction.Items.Materials;

namespace MassDestruction.Items.armor.helmets
{
	[AutoloadEquip(EquipType.Head)]
	public class TutorialHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("more health and more defence.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1000;
			item.rare = ItemRarityID.Gray;
			item.defense = 2;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == ModContent.ItemType<TutorialTunic>() && legs.type == ModContent.ItemType<TutorialBoots>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = ("Your health increases and your defence rises");
			player.statDefense = 3;
			player.statLifeMax2 += 3;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TutorialPeices>(), 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}