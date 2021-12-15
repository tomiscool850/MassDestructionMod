using MassDestruction.Items.weapons.MELEE.sword;
using MassDestruction.Items.weapons.MAGES.wands;
using Terraria.ID;
using Terraria.ModLoader;
using MassDestruction.Items.Materials;

namespace MassDestruction.Items.weapons.RANGER.bows
{
	public class TutorialBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("You passes the tutorial nice good for you.");
		}

		public override void SetDefaults()
		{
			item.damage = 8; // Sets the item's damage. Note that projectiles shot by this weapon will use its and the used ammunition's damage added together.
			item.ranged = true; // sets the damage type to ranged
			item.width = 40; // hitbox width of the item
			item.height = 20; // hitbox height of the item
			item.useTime = 30; // The item's use time in ticks (60 ticks == 1 second.)
			item.useAnimation = 30; // The length of the item's use animation in ticks (60 ticks == 1 second.)
			item.useStyle = ItemUseStyleID.HoldingOut; // how you use the item (swinging, holding out, etc)
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 1; // Sets the item's knockback. Note that projectiles shot by this weapon will use its and the used ammunition's knockback added together.
			item.value = 10; // how much the item sells for (measured in copper)
			item.rare = ItemRarityID.Gray; // the color that the item's name will be in-game
			item.UseSound = SoundID.Item39; // The sound that this item plays when used.
			item.autoReuse = false; // if you can hold click to automatically use it again
			item.shoot = 8; //idk why but all the guns in the vanilla source have this
			item.shootSpeed = 8f; // the speed of the projectile (measured in pixels per frame)
			item.useAmmo = AmmoID.Arrow; // The "ammo Id" of the ammo item that this weapon uses. Note that this is not an item Id, but just a magic value.
			item.scale = 0.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TutorialSword>());
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TutorialWand>());
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TutorialPeices>(), 8);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}
