using System;
using MassDestruction.Dusts;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.projectiles.MageP
{
	// Code adapted from the vanilla's magic missile.
	public class SnowFlakeProjectile : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = ProjectileID.Bee; // Vanilla magic missile uses this aiStyle, but using it wouldn't let us fine tune the projectile speed or dust
			projectile.friendly = true;
			projectile.light = 0.8f;
			projectile.magic = true;
			drawOriginOffsetY = -6;
		}
	}
}