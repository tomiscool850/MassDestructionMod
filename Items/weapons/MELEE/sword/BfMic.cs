using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MELEE.sword
{
	public class BfMic : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bf mic");
			Tooltip.SetDefault("be the coolest bf ever.");
		}

		public override void SetDefaults()
		{
			item.damage = 18;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 1000;
			item.rare = 2;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "MassDestruction/sounds/BfSound");
			item.autoReuse = true;
			item.scale = 0.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LeadBar, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}