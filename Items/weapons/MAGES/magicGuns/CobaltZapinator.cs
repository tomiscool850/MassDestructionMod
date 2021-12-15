using MassDestruction.Items.placeable.Bar;
using MassDestruction.Items.projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MAGES.magicGuns
{
	public class CobaltZapinator : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Cobalt lazar go brrr");
		}

		public override void SetDefaults()
		{
			item.damage = 32;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can hold the weapon [Important]
			item.mana = 8;
			item.rare = ItemRarityID.Blue;
			item.width = 28;
			item.height = 30;
			item.useTime = 12;
			item.UseSound = SoundID.Item12;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.shootSpeed = 12f;
			item.useAnimation = 12;
			item.shoot = ProjectileID.PurpleLaser;
			item.value = Item.sellPrice(gold: 1);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CobaltBar, 8);
			recipe.AddIngredient(ItemID.LaserRifle);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}