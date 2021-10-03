using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace MassDestruction.Items.weapons.MELEE.spinners
{
    public class CopperSpinner : ModItem
    {
        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;

            item.useAnimation = 30;
            item.useTime = 30;

            item.melee = true;
            item.damage = 4;
            item.knockBack = 1f;
            item.rare = item.rare = ItemRarityID.Orange;

            item.noMelee = true;
            item.noUseGraphic = true;
            item.channel = true;
            item.autoReuse = true;


            item.useStyle = ItemUseStyleID.HoldingOut;

            item.shoot = ModContent.ProjectileType<CopperSpinnerProjectile>();
            item.shootSpeed = 4f;
        }

        public override bool CanUseItem(Player player)
        {
            return player.ownedProjectileCounts[item.shoot] < 1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CopperBar, 30);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }



    public class CopperSpinnerProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.Size = new Vector2(80);
            projectile.friendly = true;
            projectile.penetrate = -1;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.melee = true;
        }

        public override void AI()
        {
            // Set some variables
            float num = 50f;
            float num2 = 2f;
            float quarterPi = -(float)Math.PI / 4f;
            float scaleFactor = 20f;
            // Get the current player
            Player player = Main.player[projectile.owner];
            // Get the Relative Point to player
            Vector2 relativePoint = player.RotatedRelativePoint(player.MountedCenter);
            // Check if Player Dead
            if (player.dead)
            {
                projectile.Kill();
                return;
            }
            // Handle Lighting Effects
            Lighting.AddLight(player.Center, 0.75f, 0.2f, 0.3f);

            // Get the Sign of Velocity X
            int sign = Math.Sign(projectile.velocity.X);
            // Ensure that the Y velocity is zero;
            projectile.velocity = new Vector2(sign, 0f);
            // Set Rotation at start of AI
            if (projectile.ai[0] == 0f)
            {
                projectile.rotation = new Vector2(sign, 0f - player.gravDir).ToRotation() + quarterPi + (float)Math.PI;
                // Reverse Direction is less than 0
                if (projectile.velocity.X < 0f)
                {
                    projectile.rotation -= (float)Math.PI / 2f;
                }
            }

            // Increase AI
            projectile.ai[0] += 1f;
            // Rotate Projectile
            projectile.rotation += (float)Math.PI * 2f * num2 / num * (float)sign;
            // Check if a rotation is done
            bool isDone = projectile.ai[0] == (num / 2f);
            // Check if projectile is done with its rotations
            if (projectile.ai[0] >= num || (isDone && !player.controlUseItem))
            {
                // Destroy Projectile
                projectile.Kill();
                // Reset the reuse delay ready for the next cycle
                player.reuseDelay = 2;
            }
            else if (isDone) // Check if we are done
            {
                // Get position of cursor
                Vector2 mouseWorld = Main.MouseWorld;
                // Check direction  towards cursor
                int dir = (player.DirectionTo(mouseWorld).X > 0f) ? 1 : -1;
                // Flip everything if direction is not same as player direction
                if ((float)dir != projectile.velocity.X)
                {
                    player.ChangeDir(dir);
                    projectile.velocity = new Vector2(dir, 0f);
                    projectile.netUpdate = true;
                    projectile.rotation -= (float)Math.PI;
                }
            }

            // Get a rotation value
            float rotationValue = projectile.rotation - (float)Math.PI / 4f * (float)sign;
            Vector2 positionVector = (rotationValue + (sign == -1 ? (float)Math.PI : 0f)).ToRotationVector2() * (projectile.ai[0] / num) * scaleFactor;
            Vector2 dustVector1 = projectile.Center + (rotationValue + ((sign == -1) ? ((float)Math.PI) : 0f)).ToRotationVector2() * 30f;
            Vector2 dustPosition = rotationValue.ToRotationVector2();
            Vector2 dustVector2 = dustPosition.RotatedBy((float)Math.PI / 2f * (float)projectile.spriteDirection);
            // Spawn Dust every 1 in 2 times
            if (Main.rand.Next(2) == 0)
            {
                Dust dust = Dust.NewDustDirect(dustVector1 - new Vector2(5f), 10, 10, DustID.Fire, player.velocity.X, player.velocity.Y, 150);
                dust.velocity = projectile.DirectionTo(dust.position) * 0.1f + dust.velocity * 0.1f;
            }
            // Loop through 4 times to create dust
            for (int i = 0; i < 4; i++)
            {
                // Sets dust offset
                float scaleFactor2 = 1f;
                float scaleFactor3 = 1f;
                switch (i)
                {
                    case 1:
                        scaleFactor3 = -1f;
                        break;
                    case 2:
                        scaleFactor2 = 0.5f;
                        scaleFactor3 = 1.25f;
                        break;
                    case 3:
                        scaleFactor2 = 0.5f;
                        scaleFactor3 = -1.25f;
                        break;
                }
                // Spawns Dust 5/6 times
                if (Main.rand.Next(6) != 0)
                {
                    Dust dust2 = Dust.NewDustDirect(projectile.position, 0, 0, DustID.AmberBolt, 0f, 0f, 100);
                    dust2.position = projectile.Center + dustPosition * (60f + Main.rand.NextFloat() * 20f) * scaleFactor3;
                    dust2.velocity = dustVector2 * (4f + 4f * Main.rand.NextFloat()) * scaleFactor3 * scaleFactor2;
                    dust2.noGravity = true;
                    dust2.noLight = true;
                    dust2.scale = 0.5f;
                    dust2.customData = this;
                    if (Main.rand.Next(4) == 0)
                    {
                        dust2.noGravity = false;
                    }
                }
            }

            // Update Projectile
            projectile.position = relativePoint - projectile.Size / 2f;
            projectile.position += positionVector;
            projectile.spriteDirection = projectile.direction;
            projectile.timeLeft = 2;
            // Update Player
            player.ChangeDir(projectile.direction);
            player.heldProj = projectile.whoAmI;
            player.itemTime = 2;
            player.itemAnimation = 2;
            player.itemRotation = MathHelper.WrapAngle(projectile.rotation);
        }
    }
}