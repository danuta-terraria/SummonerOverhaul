using SummonerOverhaul.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace SummonerOverhaul.Items.Ingredients
{
	public class MyGlobalNPC : GlobalNPC
	{

		public override void NPCLoot(NPC npc)
		{

			if (npc.type == NPCID.JungleBat)
			{
				if (Main.expertMode)
				{
					if (Main.rand.NextFloat() < .40f)
					{
						Item.NewItem(npc.getRect(), ModContent.ItemType<BatTooth>());
					}
				}
				else
                {
					if (Main.rand.Next(5) == 0)
					{
						Item.NewItem(npc.getRect(), ModContent.ItemType<BatTooth>());
					}
				}
			}

			if (npc.type == NPCID.Pixie || npc.type == NPCID.Unicorn || npc.type == NPCID.Gastropod || npc.type == NPCID.LightMummy)
			{
				if (Main.expertMode)
				{
					if (Main.rand.NextFloat() < .20f)
					{
						Item.NewItem(npc.getRect(), ModContent.ItemType<CrystalStaffBase>());
					}
				}
				else
				{
					if (Main.rand.Next(10) == 0)
					{
						Item.NewItem(npc.getRect(), ModContent.ItemType<CrystalStaffBase>());
					}
				}
			}

			if (npc.type == NPCID.EyeofCthulhu)
			{
				if (Main.expertMode)
				{
					if (Main.rand.NextFloat() < .66f)
					{
						int stack = Main.rand.Next(3);
						Item.NewItem(npc.getRect(), ModContent.ItemType<ForbiddenThread>(), stack + 3); // 3 to 5
					}
				}
				else
				{
					if (Main.rand.NextFloat() < .33f)
					{
						int stack = Main.rand.Next(3);
						Item.NewItem(npc.getRect(), ModContent.ItemType<ForbiddenThread>(), stack + 2); // 2 to 4
					}
				}
			}

			if (npc.type == NPCID.JungleCreeper || npc.type == NPCID.Moth || npc.type == NPCID.MossHornet || npc.type == NPCID.AngryTrapper || npc.type == NPCID.Arapaima || npc.type == NPCID.GiantTortoise)
			{
				if (Main.expertMode)
				{
					if (Main.rand.NextFloat() < .20f)
					{
						int stack = Main.rand.Next(6);
						Item.NewItem(npc.getRect(), ModContent.ItemType<EssenceOfNature>(), stack + 2);
					}
				}
				else
				{
					if (Main.rand.NextFloat() < .10f)
					{
						int stack = Main.rand.Next(4);
						Item.NewItem(npc.getRect(), ModContent.ItemType<EssenceOfNature>(), stack + 2);
					}
				}
			}

			if (npc.type == NPCID.SkeletronHead)
			{
				if (Main.expertMode)
				{
					if (Main.rand.NextFloat() < .50f)
					{
						Item.NewItem(npc.getRect(), ModContent.ItemType<SkullTotem>());
					}
				}
				else
				{
					if (Main.rand.NextFloat() < .25f)
					{
						Item.NewItem(npc.getRect(), ModContent.ItemType<SkullTotem>());
					}
				}
			}

			if (npc.type == NPCID.GiantFlyingFox)
			{
				if (Main.expertMode)
				{
					if (Main.rand.NextFloat() < .10f)
					{
						Item.NewItem(npc.getRect(), ModContent.ItemType<FlyingFoxStaff>());
					}
				}
				else
				{
					if (Main.rand.NextFloat() < .05f)
					{
						Item.NewItem(npc.getRect(), ModContent.ItemType<FlyingFoxStaff>());
					}
				}
			}
		}
	}
}


