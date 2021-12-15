using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.projectiles.MeleeP
{
	public class BasketBallYoyoProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{

			ProjectileID.Sets.YoyosLifeTimeMultiplier[projectile.type] = 8f;

			ProjectileID.Sets.YoyosMaximumRange[projectile.type] = 175f;

			ProjectileID.Sets.YoyosTopSpeed[projectile.type] = 10f;
		}

		public override void SetDefaults()
		{
			projectile.extraUpdates = 0;
			projectile.width = 16;
			projectile.height = 16;
			projectile.aiStyle = 99;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.melee = true;
			projectile.scale = 1f;
		}

		public override void PostAI()
		{

		}
	}
}