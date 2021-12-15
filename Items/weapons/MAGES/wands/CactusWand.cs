
using MassDestruction.Items.projectiles;
using MassDestruction.Items.projectiles.MageP;
using MassDestruction.Items.tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MAGES.wands
{
	public class CactusWand : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Shooting balls of spikes you hear.");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 7;
			item.magic = true;
			item.mana = 3;
			item.width = 40;
			item.height = 40;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 1;
			item.value = 1000;
			item.rare = ItemRarityID.Green;
			item.UseSound = SoundID.Item20;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<CactusWandProjectile>();
			item.shootSpeed = 5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Cactus, 15);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}