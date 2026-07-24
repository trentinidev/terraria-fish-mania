using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Fish
{
	// Hallow and underground fish.

	[LegacyName("PeixePrisma")]
	public class PrismFish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(silver: 80);
	}

	[LegacyName("PeixeFada")]
	public class FairyFish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Pink;
		protected override int SellValue => Item.sellPrice(gold: 1, silver: 50);
	}

	[LegacyName("PeixeCegoDasCavernas")]
	public class BlindCavefish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.White;
		protected override int SellValue => Item.sellPrice(silver: 15);
	}

	[LegacyName("PeixeLanterna")]
	public class Lanternfish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 70);
	}
}
