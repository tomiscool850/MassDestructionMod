using MassDestruction.Items;
using MassDestruction.Items.projectiles;
using MassDestruction.Items.tiles;
using MassDestruction.Items.weapons.RANGER.bows;
using MassDestruction.Items.weapons.MELEE.sword;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MAGES.wands
{
	public class TutorialWand : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("You have betten the tutorial this is your reward.");
			Item.staff[item.type] = true; //this makes the useStyle animate as a staff instead of as a gun
		}

		public override void SetDefaults()
		{
			item.damage = 5;
			item.magic = true;
			item.mana = 3;
			item.width = 40;
			item.height = 40;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true; //so the item's animation doesn't do damage
			item.knockBack = 5;
			item.value = 10000;
			item.rare = ItemRarityID.Gray;
			item.UseSound = SoundID.Item20;
			item.autoReuse = false;
			item.shoot = ProjectileID.Spark;
			item.shootSpeed = 8;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TutorialBow>());
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<TutorialSword>());
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
		}

	}
}

