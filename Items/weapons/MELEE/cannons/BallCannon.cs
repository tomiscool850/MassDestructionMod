using MassDestruction.Items.projectiles.RangeP;
using MassDestruction.Items.weapons.RANGER.balls;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MELEE.cannons
{
	public class BallCannon : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Shoots balls at enemys.");
		}

		public override void SetDefaults()
		{
			item.damage = 20; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
			item.melee = true; // sets the damage type to ranged
			item.width = 40; // hitbox width of the item
			item.height = 20; // hitbox height of the item
			item.useTime = 12; // The item's use time in ticks (60 ticks == 1 second.)
			item.useAnimation = 13; // The length of the item's use animation in ticks (60 ticks == 1 second.)
			item.useStyle = ItemUseStyleID.HoldingOut; // how you use the item (swinging, holding out, etc) //so the item's animation doesn't do damage
			item.knockBack = 5; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
			item.value = 10000; // how much the item sells for (measured in copper)
			item.rare = ItemRarityID.LightRed; // the color that the item's name will be in-game
			item.UseSound = SoundID.Item11; // The sound that this item plays when used.
			item.autoReuse = true; // if you can hold click to automatically use it again
			item.shoot = 11; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 15f; // the speed of the projectile (measured in pixels per frame)
			item.shoot = ModContent.ProjectileType<CobaltBallProjectile>();// The "ammo Id" of the ammo item that this weapon uses. Note that this is not an item Id, but just a magic value.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SnowballCannon);
			recipe.AddIngredient(ItemID.IronBar, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SnowballCannon);
			recipe.AddIngredient(ItemID.LeadBar, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}