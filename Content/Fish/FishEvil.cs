using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Fish
{
	// Corruption and crimson fish.

	[LegacyName("PeixeSombrio")]
	public class ShadowFish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 30);
	}

	[LegacyName("DevoradorMirim")]
	public class DevourerFry : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 60);
	}

	[LegacyName("PeixeCarmesim")]
	public class CrimsonFish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 30);
	}

	[LegacyName("SanguessugaEscamada")]
	public class ScaledLeech : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 60);
	}
}
