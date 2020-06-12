using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace SummonerOverhaul.Items.Accessories
{
	public class EvocationScarab : ModItem
	{

		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Increases your max number of minions by 2" +
				"\nIncreases the damage and knockback of your minions");
		}

		public override void SetDefaults()
		{
			item.accessory = true;
			item.value = Item.sellPrice(gold: 4);
			item.rare = ItemRarityID.Yellow;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.minionKB += 4f;
			player.minionDamage += 0.15f;
			player.maxMinions += 2;
		}



		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PapyrusScarab, 1);
			recipe.AddIngredient(ModContent.ItemType<EvocationPendant>(), 1);
			recipe.AddTile(TileID.TinkerersWorkbench);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}




