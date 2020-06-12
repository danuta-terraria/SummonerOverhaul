using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace SummonerOverhaul.Items.Accessories
{
	public class EvocationEmblem : ModItem
	{

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Increases your max number of minions by 3" +
				"\nIncreases summon damage by 25%" +
				"\nIncreases minion knocback");
		}

		public override void SetDefaults()
		{
			item.accessory = true;
			item.value = Item.sellPrice(gold: 25);
			item.rare = ItemRarityID.Cyan;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.minionKB += 6f;
			player.minionDamage += 0.25f;
			player.maxMinions += 3;
		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<EvocationScarab>(), 1);
			recipe.AddIngredient(ItemID.PygmyNecklace, 1);
			recipe.AddIngredient(ItemID.SummonerEmblem, 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}




	}
}




