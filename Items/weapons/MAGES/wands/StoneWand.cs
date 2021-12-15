
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
	public class StoneWand : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Stone balls.");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 9;
			item.magic = true;
			item.mana = 6;
			item.width = 40;
			item.height = 40;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 2;
			item.value = 100;
			item.rare = ItemRarityID.Gray;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<StoneWandProjectile>();
			item.shootSpeed = 3f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}