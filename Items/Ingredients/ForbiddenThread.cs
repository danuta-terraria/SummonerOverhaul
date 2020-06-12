using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace SummonerOverhaul.Items.Ingredients
{
	public class ForbiddenThread : ModItem
	{

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("'Woven with dark energies'");
		}

		public override void SetDefaults()
		{
			item.value = Item.sellPrice(silver: 1);
			item.rare = ItemRarityID.Blue;
			item.maxStack = 999;
		}


	}
}
