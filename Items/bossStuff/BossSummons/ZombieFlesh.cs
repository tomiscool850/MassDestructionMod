using MassDestruction.Items.NPCS.bosses;
using MassDestruction.Items.tiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.bossStuff.BossSummons
{
	public class ZombieFlesh : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Hes Huge be careful.");
			ItemID.Sets.SortingPriorityBossSpawns[item.type] = 13; // This helps sort inventory know this is a boss summoning item.
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 20;
			item.rare = ItemRarityID.White;
			item.useAnimation = 30;
			item.useTime = 30;
			item.useStyle = ItemUseStyleID.HoldingUp;
			item.UseSound = SoundID.Item44;
			item.consumable = true;
		}

		// We use the CanUseItem hook to prevent a player from using this item while the boss is present in the world.
		public override bool CanUseItem(Player player)
		{
			// "player.ZoneUnderworldHeight" could also be written as "player.position.Y / 16f > Main.maxTilesY - 200"
			return !Main.dayTime && !NPC.AnyNPCs(ModContent.NPCType<NPCS.bosses.ZombieKing>());
		}

		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<Items.NPCS.bosses.ZombieKing>());
			Main.PlaySound(SoundID.Roar, player.position, 0);
			return true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 20);
			recipe.AddIngredient(ItemID.RottenChunk, 15);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}