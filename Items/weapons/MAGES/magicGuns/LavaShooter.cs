using MassDestruction.Items.placeable.Bar;
using MassDestruction.Items.projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MAGES.magicGuns
{
	public class LavaShooter : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Did you really think this was real lol just a retextured slime gun");
		}

		public override void SetDefaults()
		{
			item.damage = 26;
			item.noMelee = true;
			item.magic = true;
			item.channel = true; //Channel so that you can hold the weapon [Important]
			item.mana = 5;
			item.rare = ItemRarityID.Orange;
			item.width = 28;
			item.height = 30;
			item.useTime = 13;
			item.UseSound = SoundID.Item12;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.shootSpeed = 12f;
			item.useAnimation = 13;
			item.shoot = ProjectileID.SlimeGun;
			item.value = Item.sellPrice(gold: 1);
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 5);
			recipe.AddIngredient(ItemID.LavaBucket, 3);
			recipe.AddIngredient(ItemID.SlimeGun);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

				public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.OnFire, 360);
		}
	}
}	
