using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.tools.hooks
{
	internal class SteelHook : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Hook");
		}

		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.AmethystHook);
			item.shootSpeed = 18f; // how quickly the hook is shot.
			item.shoot = ModContent.ProjectileType<SteelHookProjectile>();
		}
	}

	internal class SteelHookProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("SteelHookProjectile");
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.GemHookAmethyst);
		}

		// Use this hook for hooks that can have multiple hooks mid-flight: Dual Hook, Web Slinger, Fish Hook, Static Hook, Lunar Hook
		public override bool? CanUseGrapple(Player player)
		{
			int hooksOut = 0;
			for (int l = 0; l < 1000; l++)
			{
				if (Main.projectile[l].active && Main.projectile[l].owner == Main.myPlayer && Main.projectile[l].type == projectile.type)
				{
					hooksOut++;
				}
			}
			if (hooksOut > 2) // This hook can have 3 hooks out.
			{
				return false;
			}
			return true;
		}

		public override float GrappleRange()
		{
			return 450f;
		}

		public override void NumGrappleHooks(Player player, ref int numHooks)
		{
			numHooks = 1;
		}

		// default is 11, Lunar is 24
		public override void GrappleRetreatSpeed(Player player, ref float speed)
		{
			speed = 15f;
		}

		public override void GrapplePullSpeed(Player player, ref float speed)
		{
			speed = 4;
		}

		public override void GrappleTargetPoint(Player player, ref float grappleX, ref float grappleY)
		{
			Vector2 dirToPlayer = projectile.DirectionTo(player.Center);
			float hangDist = 50f;
			grappleX += dirToPlayer.X * hangDist;
			grappleY += dirToPlayer.Y * hangDist;
		}

		public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
		{
			Vector2 playerCenter = Main.player[projectile.owner].MountedCenter;
			Vector2 center = projectile.Center;
			Vector2 distToProj = playerCenter - projectile.Center;
			float projRotation = distToProj.ToRotation() - 1.57f;
			float distance = distToProj.Length();
			while (distance > 30f && !float.IsNaN(distance))
			{
				distToProj.Normalize();                 //get unit vector
				distToProj *= 24f;                      //speed = 24
				center += distToProj;                   //update draw position
				distToProj = playerCenter - center;    //update distance
				distance = distToProj.Length();
				Color drawColor = lightColor;

				//Draw chain
				spriteBatch.Draw(mod.GetTexture("Items/projectiles/Chains/HookChains/SteelHookChain"), new Vector2(center.X - Main.screenPosition.X, center.Y - Main.screenPosition.Y),
					new Rectangle(0, 0, Main.chain30Texture.Width, Main.chain30Texture.Height), drawColor, projRotation,
					new Vector2(Main.chain30Texture.Width * 0.5f, Main.chain30Texture.Height * 0.5f), 1f, SpriteEffects.None, 0f);
			}
			return true;
		}
	}

}