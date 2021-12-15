using MassDestruction.Items.placeable.Bar;
using MassDestruction.Items.projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MAGES.magicGuns
{
	public class TinZapinater : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Tin lazar go brrr");
		}

		public override void SetDefaults()
		{
			item.damage = 5;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can hold the weapon [Important]
			item.mana = 3;
			item.rare = ItemRarityID.Pink;
			item.width = 28;
			item.height = 30;
			item.useTime = 15;
			item.UseSound = SoundID.Item12;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.shootSpeed = 8f;
			item.useAnimation = 15;
			item.shoot = ProjectileID.PurpleLaser;
			item.value = Item.sellPrice(silver: 50);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinBar, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}