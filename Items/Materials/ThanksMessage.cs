using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.Materials
{
	public class ThanksMessage : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("this item is the last item that will be added to the mod\n " +
				" as we are making a new mod for 1.4 terraria called a worthy adventure\n" +
				" also known as Worthy Mod. There was a ton of content i wanted to add\n" +
				" but never did sadly. but any ideas i had for this mod will be put into\n" +
				" worthy mod. the worthy mod might be worked on around may as thats when\n" +
				" i end school and thats when tmodloader beta starts and when we will be\n" +
				" incourage to move there so ya.\n " +
				" so thanks for playing the mod and well see you in 1.4\n" +
				" used for The Sowrd Of Mass Distruction");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 1000;
			item.rare = -13;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Paper>(), 5);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
	}
}