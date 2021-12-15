using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.assesories.Everyone
{
	[AutoloadEquip(EquipType.Shoes)]
	public abstract class Boots : ModItem
	{
		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 32;
			item.accessory = true;
			item.value = Item.sellPrice(silver: 25);
			item.rare = ItemRarityID.Gray;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Leather, 25);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool CanEquipAccessory(Player player, int slot)
		{

			if (slot < 10)
			{
				int index = FindDifferentEquippedExclusiveAccessory().index;
				if (index != -1)
				{
					return slot == index;
				}
			}

			return base.CanEquipAccessory(player, slot);
		}

		public override void ModifyTooltips(List<TooltipLine> tooltips)
		{

			Item accessory = FindDifferentEquippedExclusiveAccessory().accessory;
			if (accessory != null)
			{
				tooltips.Add(new TooltipLine(mod, "Swap", "Right click to swap with '" + accessory.Name + "'!")
				{
					overrideColor = Color.OrangeRed
				});
			}
		}

		public override bool CanRightClick()
		{

			int maxAccessoryIndex = 5 + Main.LocalPlayer.extraAccessorySlots;
			for (int i = 13; i < 13 + maxAccessoryIndex; i++)
			{
				if (Main.LocalPlayer.armor[i].type == item.type) return false;
			}


			if (FindDifferentEquippedExclusiveAccessory().accessory != null)
			{
				return true;
			}

			return base.CanRightClick();
		}

		public override void RightClick(Player player)
		{

			var (index, accessory) = FindDifferentEquippedExclusiveAccessory();
			if (accessory != null)
			{
				Main.LocalPlayer.QuickSpawnClonedItem(accessory);

				Main.LocalPlayer.armor[index] = item.Clone();
			}
		}


		protected (int index, Item accessory) FindDifferentEquippedExclusiveAccessory()
		{
			int maxAccessoryIndex = 5 + Main.LocalPlayer.extraAccessorySlots;
			for (int i = 3; i < 3 + maxAccessoryIndex; i++)
			{
				Item otherAccessory = Main.LocalPlayer.armor[i];

				if (!otherAccessory.IsAir &&
					!item.IsTheSameAs(otherAccessory) &&
					otherAccessory.modItem is CelestialRing)
				{

					return (i, otherAccessory);
				}
			}
			return (-1, null);
		}
	}


	public class yes : CelestialRing
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("boots");
			Tooltip.SetDefault("speeds you up");
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{

			player.statLifeMax2 += 15;

		}

		public override void RightClick(Player player)
		{

			string previousItemName = "";

			Item accessory = FindDifferentEquippedExclusiveAccessory().accessory;
			if (accessory != null)
			{
				previousItemName = accessory.Name;
			}


			base.RightClick(player);

			Main.NewText("I just equipped " + item.Name + " in place of " + previousItemName + "!");
			Main.PlaySound(SoundID.MaxMana, (int)player.position.X, (int)player.position.Y);
		}
	}

}