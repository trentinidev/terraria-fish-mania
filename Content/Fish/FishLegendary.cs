using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Fish
{
	// Legendary and fantasy fish, rare anywhere.

	[LegacyName("CarpaLendaria")]
	public class LegendaryCarp : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightPurple;
		protected override int SellValue => Item.sellPrice(gold: 2, silver: 50);
	}

	[LegacyName("PeixeRobo")]
	public class RoboFish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightPurple;
		protected override int SellValue => Item.sellPrice(gold: 2, silver: 50);
	}

	[LegacyName("PeixeEstrelaCadente")]
	public class ShootingStarFish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightPurple;
		protected override int SellValue => Item.sellPrice(gold: 3);
	}

	[LegacyName("PeixeDoVazio")]
	public class VoidFish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Purple;
		protected override int SellValue => Item.sellPrice(gold: 5);
	}

	[LegacyName("ReiDosPeixes")]
	public class KingOfFish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Red;
		protected override int SellValue => Item.sellPrice(gold: 25);

		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 1;
		}
	}
}
