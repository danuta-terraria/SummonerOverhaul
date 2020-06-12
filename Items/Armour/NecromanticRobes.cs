
using SummonerOverhaul.Items.Ingredients;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SummonerOverhaul.Items.Armour
{
    [AutoloadEquip(EquipType.Body)]
    public class NecromanticRobes : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Necromantic Robes");
			Tooltip.SetDefault("+1 max minions");
		}

		public override void SetDefaults()
		{
			item.value = Item.sellPrice(silver: 8);
			item.rare = ItemRarityID.Green;
			item.defense = 1;
		}

		public override void UpdateEquip(Player player)
		{
			player.maxMinions++;

		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return head.type == ItemType<NecromanticHood>() && legs.type == ItemType<NecromanticPants>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "+5% summon damage";
			player.minionDamage += 0.05f;
			

		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 30);
			recipe.AddIngredient(ItemType<ForbiddenThread>(), 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}