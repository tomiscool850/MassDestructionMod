using MassDestruction.Items.mounts.MountBuff;
using MassDestruction.Dusts.MountDust;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.mounts.mount
{
	public class FordFocusSE : ModMountData
	{
		public override void SetDefaults()
		{
			mountData.spawnDust = ModContent.DustType<CarGas>();
			mountData.buff = ModContent.BuffType<FordFocusSEBuff>();
			mountData.heightBoost = 20;
			mountData.fallDamage = 0.5f;
			mountData.runSpeed = 13f;
			mountData.dashSpeed = 8f;
			mountData.flightTimeMax = 0;
			mountData.fatigueMax = 0;
			mountData.jumpHeight = 8;
			mountData.acceleration = 0.20f;
			mountData.jumpSpeed = 4f;
			mountData.blockExtraJumps = false;
			mountData.totalFrames = 4;
			mountData.constantJump = true;
			int[] array = new int[mountData.totalFrames];
			for (int l = 0; l < array.Length; l++)
			{
				array[l] = 20;
			}
			mountData.playerYOffsets = array;
			mountData.xOffset = 13;
			mountData.bodyFrame = 3;
			mountData.yOffset = -12;
			mountData.playerHeadOffset = 22;
			mountData.standingFrameCount = 4;
			mountData.standingFrameDelay = 12;
			mountData.standingFrameStart = 0;
			mountData.runningFrameCount = 4;
			mountData.runningFrameDelay = 12;
			mountData.runningFrameStart = 0;
			mountData.flyingFrameCount = 0;
			mountData.flyingFrameDelay = 0;
			mountData.flyingFrameStart = 0;
			mountData.inAirFrameCount = 1;
			mountData.inAirFrameDelay = 12;
			mountData.inAirFrameStart = 0;
			mountData.idleFrameCount = 4;
			mountData.idleFrameDelay = 12;
			mountData.idleFrameStart = 0;
			mountData.idleFrameLoop = true;
			mountData.swimFrameCount = mountData.inAirFrameCount;
			mountData.swimFrameDelay = mountData.inAirFrameDelay;
			mountData.swimFrameStart = mountData.inAirFrameStart;
			if (Main.netMode == NetmodeID.Server)
			{
				return;
			}

			mountData.textureWidth = mountData.backTexture.Width + 20;
			mountData.textureHeight = mountData.backTexture.Height;
		}

		public override void UpdateEffects(Player player)
		{
			// This code simulates some wind resistance for the balloons. 
			var balloons = (CarSpecificData)player.mount._mountSpecificData;
			float ballonMovementScale = 0.05f;
			for (int i = 0; i < balloons.count; i++)
			{
				if (Math.Abs(balloons.rotations[i]) > Math.PI / 2)
					ballonMovementScale *= -1;
				balloons.rotations[i] += -player.velocity.X * ballonMovementScale * Main.rand.NextFloat();
				balloons.rotations[i] = balloons.rotations[i].AngleLerp(0, 0.05f);
			}

			// This code spawns some dust if we are moving fast enough.
			if (!(Math.Abs(player.velocity.X) > 4f))
			{
				return;
			}
			Rectangle rect = player.getRect();
			Dust.NewDust(new Vector2(rect.X, rect.Y), rect.Width, rect.Height, ModContent.DustType<CarGas>());
		}

		// Since only a single instance of ModMountData ever exists, we can use player.mount._mountSpecificData to store additional data related to a specific mount.
		// Using something like this for gameplay effects would require ModPlayer syncing, but this example is purely visual.
		internal class CarSpecificData
		{
			// count tracks how many balloons are still left. See ExamplePerson.Hurt to see how count decreases whenever damage is taken.
			internal int count;
			internal float[] rotations;
			internal static float[] offsets = new float[] { 0, 14, -14 };
			public CarSpecificData()
			{
				count = 3;
				rotations = new float[count];
			}
		}

		public override void SetMount(Player player, ref bool skipDust)
		{
			// When this mount is mounted, we initialize _mountSpecificData with a new CarSpecificData object which will track some extra visuals for the mount.
			player.mount._mountSpecificData = new CarSpecificData();

			// This code bypasses the normal mount spawning dust and replaces it with our own visual.
			for (int i = 0; i < 16; i++)
			{
				Dust.NewDustPerfect(player.Center + new Vector2(80, 0).RotatedBy(i * Math.PI * 2 / 16f), mountData.spawnDust);
			}
			skipDust = true;
		}

		}
	}