using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using Terraria;
using Terraria.Enums;
using Terraria.ModLoader;

namespace MassDestruction.Items.projectiles.MageP
{
	// The following laser shows a channeled ability, after charging up the laser will be fired
	// Using custom drawing, dust effects, and custom collision checks for tiles
	public class BlackLazer : ModProjectile
	{
		private const float MAX_CHARGE = 1f;
		//The distance charge particle from the player center
		private const float MOVE_DISTANCE = 15f;

		// The actual distance is stored in the ai0 field
		// By making a property to handle this it makes our life easier, and the accessibility more readable
		public float Distance
		{
			get => projectile.ai[0];
			set => projectile.ai[0] = value;
		}

		// The actual charge value is stored in the localAI0 field
		public float Charge
		{
			get => projectile.localAI[0];
			set => projectile.localAI[0] = value;
		}


		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.tileCollide = false;
			projectile.magic = true;
			projectile.hide = true;
		}

		public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
		{
			{
				DrawLaser(spriteBatch, Main.projectileTexture[projectile.type], Main.player[projectile.owner].Center,
					projectile.velocity, 10, projectile.damage, -1.57f, 1f, 350f, Color.Green, (int)MOVE_DISTANCE);
			}
			return false;
		}

		// The core function of drawing a laser
		public void DrawLaser(SpriteBatch spriteBatch, Texture2D texture, Vector2 start, Vector2 unit, float step, int damage, float rotation = 0f, float scale = 1f, float maxDist = 2000f, Color color = default(Color), int transDist = 50)
		{
			float r = unit.ToRotation() + rotation;

		}
	}
}