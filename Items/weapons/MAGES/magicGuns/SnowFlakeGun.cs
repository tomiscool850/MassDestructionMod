using MassDestruction.Items.placeable.Bar;
using MassDestruction.Items.projectiles;
using MassDestruction.Items.projectiles.MageP;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MAGES.magicGuns
{
	public class SnowFlakeGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Shoots Snowflakes");
		}

		public override void SetDefaults()
		{
			item.damage = 35;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can hold the weapon [Important]
			item.mana = 4;
			item.rare = ItemRarityID.Pink;
			item.width = 28;
			item.height = 30;
			item.useTime = 12;
			item.UseSound = SoundID.Item12;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.shootSpeed = 12f;
			item.useAnimation = 12;
			item.shoot = ModContent.ProjectileType<SnowFlakeProjectile>();
			item.value = Item.sellPrice(silver: 99);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SnowBlock, 50);
			recipe.AddIngredient(ItemID.BeeGun);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}