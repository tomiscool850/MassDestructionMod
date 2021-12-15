using MassDestruction.Items.placeable.Bar;
using MassDestruction.Items.projectiles;
using MassDestruction.Items.projectiles.bobs;
using MassDestruction.Items.tiles;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.tools.fishingRods
{
	public class SteelRod : ModItem
	{


		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Fishing Rod");
			Tooltip.SetDefault("can fish in lava.");
			//Allows the pole to fish in lava
			ItemID.Sets.CanFishInLava[item.type] = true;
		}

		public override void SetDefaults()
		{
			//These are copied through the CloneDefaults method
			//item.useStyle = 1;
			//item.useAnimation = 8;
			//item.useTime = 8;
			//item.width = 24;
			//item.height = 28;
			//item.UseSound = SoundID.Item1;
			item.CloneDefaults(ItemID.WoodFishingPole);

			//Sets the poles fishing power
			item.fishingPole = 55;

			//Sets the speed in which the bobbers are launched, Wooden Fishing Pole is 9f and Golden Fishing Rod is 17f
			item.shootSpeed = 12f;

			//The Bobber projectile
			item.shoot = ModContent.ProjectileType<SteelBobber>();

		}

		//Grants the High Test Fishing Line bool if holding the item
		//NOTE: Only triggers through the hotbar, not if you hold the item by hand outside of the inventory
		public override void HoldItem(Player player)
		{
			player.accFishingLine = true;
		}

		//Overrides the default shooting method to fire multiple bobbers
		//NOTE: This will allow the fishing rod to summon multiple Duke Fishrons with multiple Truffle Worms in the inventory
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int bobberAmount = Main.rand.Next(1, 2); //3 to 5 bobbers
			float spreadAmount = 75f;
			for (int index = 0; index < bobberAmount; ++index)
			{
				float SpeedX = speedX + Main.rand.NextFloat(-spreadAmount, spreadAmount) * 0.05f;
				float SpeedY = speedY + Main.rand.NextFloat(-spreadAmount, spreadAmount) * 0.05f;
				Projectile.NewProjectile(position.X, position.Y, SpeedX, SpeedY, type, 0, 0f, player.whoAmI, 0f, 0f);
			}
			return false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SteelBar>(), 10);
			recipe.AddTile(TileID.Hellforge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}