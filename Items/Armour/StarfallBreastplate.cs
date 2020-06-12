
using SummonerOverhaul.Items.Ingredients;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SummonerOverhaul.Items.Armour
{
	[AutoloadEquip(EquipType.Body)]
	public class StarfallBreastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Starfall Breastplate");
			Tooltip.SetDefault("+1 max minions");
		}

		public override void SetDefaults()
		{
			item.value = Item.sellPrice(copper: 80);
			item.rare = ItemRarityID.Blue;
			item.defense = 1;
		}

		public override void UpdateEquip(Player player)
		{
			player.maxMinions++;

		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return head.type == ItemType<StarfallHelmet>() && legs.type == ItemType<StarfallLeggings>();
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "+2.5% summon damage";
			player.minionDamage += 0.025f;


		}


		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Wood", 30);
			recipe.AddIngredient(ItemID.FallenStar, 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}