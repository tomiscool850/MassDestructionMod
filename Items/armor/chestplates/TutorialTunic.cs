
using MassDestruction.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.armor.chestplates
{
	[AutoloadEquip(EquipType.Body)]
	public class TutorialTunic : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Tutorial Tunic");
			Tooltip.SetDefault("Tutorial armor a very great begginer armor a combination of the woo armor."
				+ "\nBut better and the tutorial ring but weaker");

		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1000;
			item.rare = ItemRarityID.Gray;
			item.defense = 2;
		}

		public override void UpdateEquip(Player player)
		{
			player.statLifeMax2 += 3;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TutorialPeices>(), 15);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}