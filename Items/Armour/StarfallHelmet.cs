
using SummonerOverhaul.Items.Ingredients;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SummonerOverhaul.Items.Armour
{
	[AutoloadEquip(EquipType.Head)]
	public class StarfallHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Starfall Helmet");
		}

		public override void SetDefaults()
		{
			item.value = Item.sellPrice(copper: 40);
			item.rare = ItemRarityID.Blue;
		}

		public override void UpdateEquip(Player player)
		{

		}



		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Wood", 25);
			recipe.AddIngredient(ItemID.FallenStar, 15);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}