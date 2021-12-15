using MassDestruction.Items.Materials;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.Potions
{
    public class PetroleumPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("gives you very speed, speed big.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 26;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useAnimation = 15;
            item.useTime = 15;
            item.useTurn = true;
            item.UseSound = SoundID.Item3;
            item.maxStack = 30;
            item.consumable = true;
            item.rare = ItemRarityID.Orange;
            item.value = Item.buyPrice(gold: 1);
            item.buffType = ModContent.BuffType<Effects.Buffs.PetroleumEffect>();
            item.buffTime = 10600;

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SwiftnessPotion, 5);
            recipe.AddIngredient(ModContent.ItemType<Plastic>());
            recipe.AddIngredient(ModContent.ItemType<CobwebFeather>(), 2);
            recipe.AddTile(TileID.Bottles);
            recipe.SetResult(this);
            recipe.AddRecipe();

        }
    }
}