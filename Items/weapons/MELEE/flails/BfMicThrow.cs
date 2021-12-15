using MassDestruction.Items.projectiles;
using MassDestruction.Items.projectiles.MeleeP;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MELEE.flails
{
	public class BfMicThrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bf's Throwable Mic");
		}

		public override void SetDefaults()
		{
			item.width = 35;
			item.height = 35;
			item.value = Item.sellPrice(silver: 5);
			item.rare = ItemRarityID.White;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.useAnimation = 40;
			item.useTime = 40;
			item.knockBack = 4f;
			item.damage = 15;
			item.noUseGraphic = true;
			item.shoot = ModContent.ProjectileType<BFFlailProjectiles>();
			item.shootSpeed = 15.1f;
			item.UseSound = SoundID.Item1;
			item.melee = true;
			item.crit = 9;
			item.channel = true;
			item.scale = 0.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 6);
			recipe.AddIngredient(ItemID.Cobweb, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar, 6);
			recipe.AddIngredient(ItemID.Cobweb, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}