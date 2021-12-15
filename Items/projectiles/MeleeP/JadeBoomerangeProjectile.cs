using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.projectiles.MeleeP
{
	public class JadeBoomerangeProjectile : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.friendly = true;
			projectile.light = 2f;
			projectile.melee = true;
			drawOriginOffsetY = -6;
			projectile.tileCollide = true;
			projectile.CloneDefaults(ProjectileID.EnchantedBoomerang);
			projectile.aiStyle = 3;
			projectile.timeLeft = 480;
		}
	}
}
