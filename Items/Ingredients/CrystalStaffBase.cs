using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace SummonerOverhaul.Items.Ingredients
{
	public class CrystalStaffBase : ModItem
	{

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("'It looks like the bottom part of an ancient staff'");
		}

		public override void SetDefaults()
		{
			item.value = Item.sellPrice(silver: 40);
			item.rare = ItemRarityID.LightRed;
			item.maxStack = 1;
		}


	}
}
