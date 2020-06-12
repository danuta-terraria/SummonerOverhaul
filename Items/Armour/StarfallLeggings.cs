
using SummonerOverhaul.Items.Ingredients;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SummonerOverhaul.Items.Armour
{
	[AutoloadEquip(EquipType.Legs)]
	public class StarfallLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Starfall Leggings");
		}

		public override void SetDefaults()
		{
			item.value = Item.sellPrice(copper: 50);
			item.rare = ItemRarityID.Blue;
		}



		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Wood", 20);
			recipe.AddIngredient(ItemID.FallenStar, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}