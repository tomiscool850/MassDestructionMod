using MassDestruction.Items.projectiles;
using MassDestruction.Items.projectiles.MeleeP;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MELEE.flails
{
	public class SolarFlail : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = Item.sellPrice(gold: 30);
			item.rare = ItemRarityID.Red;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.useAnimation = 25;
			item.useTime = 25;
			item.knockBack = 6f;
			item.damage = 85;
			item.noUseGraphic = true;
			item.shoot = ModContent.ProjectileType<SolarFlailProjectile>();
			item.shootSpeed = 16f;
			item.UseSound = SoundID.Item1;
			item.melee = true;
			item.crit = 30;
			item.channel = true;
		}

		public override void AddRecipes()
		{
			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Chain, 5);
			recipe.AddIngredient(ItemID.FragmentSolar, 20);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}
				public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			// Add the Onfire buff to the NPC for 1 second when the weapon hits an NPC
			// 60 frames = 1 second
			target.AddBuff(BuffID.OnFire, 360);
		}
	}
}