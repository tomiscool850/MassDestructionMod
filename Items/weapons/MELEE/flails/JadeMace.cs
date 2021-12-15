using MassDestruction.Items.placeable.Bar;
using MassDestruction.Items.projectiles;
using MassDestruction.Items.projectiles.MeleeP;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MELEE.flails
{
	public class JadeMace : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 20;
			item.value = Item.sellPrice(gold: 2);
			item.rare = ItemRarityID.Red;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.useAnimation = 20;
			item.useTime = 20;
			item.knockBack = 4f;
			item.damage = 52;
			item.noUseGraphic = true;
			item.shoot = ModContent.ProjectileType<JadeMaceProjectile>();
			item.shootSpeed = 12f;
			item.UseSound = SoundID.Item1;
			item.melee = true;
			item.crit = 12;
			item.channel = true;
		}

		public override void AddRecipes()
		{
			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Chain);
			recipe.AddIngredient(ModContent.ItemType<JadeBar>(), 8);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}