using Terraria.ID;
using Terraria.ModLoader;
using MassDestruction.Items.projectiles;
using MassDestruction.Items.projectiles.MeleeP;

namespace MassDestruction.Items.weapons.MELEE.shortswords
{
	public class TrueSmolSwordOfMassDistruction : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True smol Sword Of Mass Distruction");
			Tooltip.SetDefault("this was a side gift from the gods you may need it.");
		}

		public override void SetDefaults()
		{
			item.damage = 900;
			item.melee = true;
			item.width = 60;
			item.height = 60;
			item.useTime = 8;
			item.useAnimation = 8;
			item.useStyle = ItemUseStyleID.Stabbing;
			item.knockBack = 7;
			item.value = 100000000;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<TrueSwordOfMassDistructionProjectile>();
			item.scale = 1.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SmolSwordOfMassDistruction>());
			recipe.AddIngredient(ItemID.BrokenHeroSword, 250);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
