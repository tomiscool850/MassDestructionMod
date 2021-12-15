using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.projectiles.MeleeP
{
	// Code adapted from the vanilla's magic missile.
	public class TrueCopperShortswordProjectile : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			// projectile.aiStyle = 9; // Vanilla magic missile uses this aiStyle, but using it wouldn't let us fine tune the projectile speed or dust
			projectile.friendly = true;
			projectile.light = 2f;
			projectile.melee = true;
			drawOriginOffsetY = -6;
			projectile.tileCollide = false;
			projectile.aiStyle = 12;
		}

	}
}