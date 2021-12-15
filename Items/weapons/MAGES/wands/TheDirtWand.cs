
using MassDestruction.Items.Materials;
using MassDestruction.Items.placeable.Bar;
using MassDestruction.Items.projectiles;
using MassDestruction.Items.projectiles.MageP;
using MassDestruction.Items.tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MAGES.wands
{
	public class TheDirtWand : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("dirt balls, it looks weaker then it is.");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 999;
			item.magic = true;
			item.mana = 100;
			item.width = 40;
			item.height = 40;
			item.useTime = 600;
			item.useAnimation = 600;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 2;
			item.value = 1000000000;
			item.rare = ItemRarityID.Gray;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<TheDirtWandProjectile>();
			item.shootSpeed = 3f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 999);
			recipe.AddIngredient(ItemID.LunarBar);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}