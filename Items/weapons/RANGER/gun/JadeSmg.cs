
using MassDestruction.Items;
using MassDestruction.Items.placeable.Bar;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.RANGER.gun
{
	public class JadeSmg : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This is a modded gun.");
		}

		public override void SetDefaults()
		{
			item.damage = 30; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
			item.ranged = true; // sets the damage type to ranged
			item.width = 40; // hitbox width of the item
			item.height = 20; // hitbox height of the item
			item.useTime = 7; // The item's use time in ticks (60 ticks == 1 second.)
			item.useAnimation = 7; // The length of the item's use animation in ticks (60 ticks == 1 second.)
			item.useStyle = ItemUseStyleID.HoldingOut; // how you use the item (swinging, holding out, etc)
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 2; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
			item.value = 1000000; // how much the item sells for (measured in copper)
			item.rare = ItemRarityID.Green; // the color that the item's name will be in-game
			item.UseSound = SoundID.Item11; // The sound that this item plays when used.
			item.autoReuse = true; // if you can hold click to automatically use it again
			item.shoot = 10; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 15f; // the speed of the projectile (measured in pixels per frame)
			item.useAmmo = AmmoID.Bullet; // The "ammo Id" of the ammo item that this weapon uses. Note that this is not an item Id, but just a magic value.
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<JadeBar>(), 15);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}


	}
}