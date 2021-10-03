using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.projectiles.MeleeP
{
	// Code adapted from the vanilla's magic missile.
	public class TinBoomerangeProjectile : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.friendly = true;
			projectile.light = 5f;
			projectile.melee = true;
			drawOriginOffsetY = -6;
			projectile.tileCollide = true;
			projectile.CloneDefaults(ProjectileID.WoodenBoomerang);
			projectile.aiStyle = 3;
			projectile.timeLeft = 600;
		}
	}
}
