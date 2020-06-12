
using SummonerOverhaul.Items.Ingredients;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SummonerOverhaul.Items.Armour
{
    [AutoloadEquip(EquipType.Legs)]
    public class NecromanticPants : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Necromantic Pants");
		}

		public override void SetDefaults()
		{
			item.value = Item.sellPrice(silver: 3);
			item.rare = ItemRarityID.Green;
			item.defense = 0;
		}



		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Silk, 15);
			recipe.AddIngredient(ItemType<ForbiddenThread>(), 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}