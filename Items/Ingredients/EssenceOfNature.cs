using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace SummonerOverhaul.Items.Ingredients
{
	public class EssenceOfNature : ModItem
	{

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("'The essence of jungle creatures'");
		}

		public override void SetDefaults()
		{
			item.height = 10;
			item.width = 10;
			item.value = Item.sellPrice(silver: 5);
			item.rare = ItemRarityID.Pink;
			item.maxStack = 999;
		}


	}
}
