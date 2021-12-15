using MassDestruction.Items.Effects.Debuffs;
using MassDestruction.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.weapons.MELEE.sword
{
	public class RubyBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ruby Blade");
			Tooltip.SetDefault("A sword out of Per Ruby .");
		}

		public override void SetDefaults()
		{
			item.damage = 16;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ruby, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

			public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(ModContent.BuffType<Gemified>(), 300);
		}
	}
}
