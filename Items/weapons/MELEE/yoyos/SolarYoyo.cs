using MassDestruction.Items.projectiles;
using MassDestruction.Items.projectiles.MeleeP;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MELEE.yoyos
{
	public class SolarYoyo : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Solar fragments shaped as a yoyo");


			ItemID.Sets.Yoyo[item.type] = true;
			ItemID.Sets.GamepadExtraRange[item.type] = 15;
			ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.width = 24;
			item.height = 24;
			item.useAnimation = 18;
			item.useTime = 18;
			item.shootSpeed = 18f;
			item.knockBack = 2.5f;
			item.damage = 80;
			item.rare = ItemRarityID.White;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(platinum: 1);
			item.shoot = ModContent.ProjectileType<SolarYoyoProjectile>();
		}


		private static readonly int[] unwantedPrefixes = new int[] { PrefixID.Terrible, PrefixID.Dull, PrefixID.Shameful, PrefixID.Annoying, PrefixID.Broken, PrefixID.Damaged, PrefixID.Shoddy };

		public override bool AllowPrefix(int pre)
		{


			if (Array.IndexOf(unwantedPrefixes, pre) > -1)
			{

				return false;
			}

			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentSolar, 15);
			recipe.AddIngredient(ItemID.Cobweb, 10);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();

		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.OnFire, 360);
		}
	}
}
