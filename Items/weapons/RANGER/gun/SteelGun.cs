using MassDestruction.Items.placeable.Bar;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.RANGER.gun
{
	public class SteelGun : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The gun of steel, sets stuff on fire, cool right.");
		}

		public override void SetDefaults()
		{
			item.damage = 17;
			item.ranged = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.noMelee = true;
			item.knockBack = 2;
			item.value = 1000;
			item.rare = ItemRarityID.Gray;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 8;
			item.shootSpeed = 12f;
			item.useAmmo = AmmoID.Bullet;
			item.scale = 0.5f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 12);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			// Add the Onfire buff to the NPC for 1 second when the weapon hits an NPC
			// 60 frames = 1 second
			target.AddBuff(BuffID.OnFire, 120);
		}
	}
	}
