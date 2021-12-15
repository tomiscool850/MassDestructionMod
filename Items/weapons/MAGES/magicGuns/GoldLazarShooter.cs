using MassDestruction.Items.placeable.Bar;
using MassDestruction.Items.projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MAGES.magicGuns
{
	public class GoldLazarShooter : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Gold lazar go brrr");
		}

		public override void SetDefaults()
		{
			item.damage = 18;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can hold the weapon [Important]
			item.mana = 8;
			item.rare = ItemRarityID.Yellow;
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
			recipe.AddIngredient(ItemID.GoldBar, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}