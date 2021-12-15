using MassDestruction.Items.placeable.Bar;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.RANGER.DartRifles
{
	public class TitaniumDartRifle : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("shoots darts, thos dart can be Titanium to;).");
		}

		public override void SetDefaults()
		{
			item.damage = 55;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 10000;
			item.rare = ItemRarityID.White;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 12f;
			item.useAmmo = AmmoID.Dart;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TitaniumBar, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}

	}
}
