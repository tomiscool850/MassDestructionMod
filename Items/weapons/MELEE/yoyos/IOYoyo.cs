using MassDestruction.Items.projectiles;
using MassDestruction.Items.projectiles.MeleeP;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MELEE.yoyos
{
	public class IOYoyo : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("yoyo made of the IO Planet.. sus");

			// These are all related to gamepad controls and don't seem to affect anything else
			ItemID.Sets.Yoyo[item.type] = true;
			ItemID.Sets.GamepadExtraRange[item.type] = 16;
			ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.useStyle = ItemUseStyleID.HoldingOut;
			item.width = 24;
			item.height = 24;
			item.useAnimation = 20;
			item.useTime = 20;
			item.shootSpeed = 15f;
			item.knockBack = 4f;
			item.damage = 45;
			item.rare = ItemRarityID.Yellow;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(gold: 2);
			item.shoot = ModContent.ProjectileType<IOYoyoProjectile>();
		}

		// Make sure that your item can even receive these prefixes (check the vanilla wiki on prefixes)
		// These are the ones that reduce damage of a melee weapon
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
			recipe.AddIngredient(ItemID.FallenStar, 15);
			recipe.AddIngredient(ItemID.DirtBlock, 15);
			recipe.AddIngredient(ItemID.YellowDye, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}