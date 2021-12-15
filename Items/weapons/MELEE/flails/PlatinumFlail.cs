using MassDestruction.Items.projectiles;
using MassDestruction.Items.projectiles.MeleeP;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MELEE.flails
{
	public class PlatinumFlail : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.value = Item.sellPrice(gold: 1);
			item.rare = ItemRarityID.Blue;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.useAnimation = 25;
			item.useTime = 25;
			item.knockBack = 3f;
			item.damage = 19;
			item.noUseGraphic = true;
			item.shoot = ModContent.ProjectileType<PlatinumFlailProjectile>();
			item.shootSpeed = 12f;
			item.UseSound = SoundID.Item1;
			item.melee = true;
			item.crit = 10;
			item.channel = true;
		}

		public override void AddRecipes()
		{
			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Chain);
			recipe.AddIngredient(ItemID.PlatinumBar, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}