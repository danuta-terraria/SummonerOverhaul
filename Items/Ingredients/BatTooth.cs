using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace SummonerOverhaul.Items.Ingredients
{
	public class BatTooth : ModItem
	{

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("'Sharp and pointy'");
		}

		public override void SetDefaults()
		{
			item.value = Item.sellPrice(silver: 2);
			item.rare = ItemRarityID.Blue;
			item.maxStack = 999;
		}


	}
}




