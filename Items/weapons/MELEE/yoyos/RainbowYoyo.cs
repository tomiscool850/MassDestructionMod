using MassDestruction.Items.projectiles;
using MassDestruction.Items.projectiles.MeleeP;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MELEE.yoyos
{
	public class RainbowYoyo : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("yoyo made of rainbow...EVERYTHING ");

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
			item.useAnimation = 10;
			item.useTime = 10;
			item.shootSpeed = 20f;
			item.knockBack = 6f;
			item.damage = 64;
			item.rare = -12;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(gold: 5);
			item.shoot = ModContent.ProjectileType<RainbowYoyoProjectile>();
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
			recipe.AddIngredient(ItemID.RainbowBrick, 100);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}