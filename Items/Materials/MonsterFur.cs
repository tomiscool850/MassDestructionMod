using Terraria.ID;
using Terraria.ModLoader;

namespace MassDestruction.Items.Materials
{
	public class MonsterFur : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Fur from monsters, not monsters like zombies but monsters.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 1000;
			item.rare = ItemRarityID.White;
		}


		}
	}