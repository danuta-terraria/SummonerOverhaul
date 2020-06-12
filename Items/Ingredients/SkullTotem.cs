using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace SummonerOverhaul.Items.Ingredients
{
	public class SkullTotem : ModItem
	{

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The faint inscription simply reads 'doot doot'...");
		}

		public override void SetDefaults()
		{
			item.value = Item.sellPrice(silver: 3);
			item.rare = ItemRarityID.Orange;
			item.maxStack = 1;
		}


	}
}
