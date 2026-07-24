using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Fish
{
	// Jungle fish.

	[LegacyName("PiranhaEsmeralda")]
	public class EmeraldPiranha : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 25);
	}

	[LegacyName("TucunareSelvagem")]
	public class WildPeacockBass : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 30);
	}

	[LegacyName("EnguiaVenenosa")]
	public class VenomousEel : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 35);
	}

	[LegacyName("PirarucuAncestral")]
	public class AncestralPirarucu : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightPurple;
		protected override int SellValue => Item.sellPrice(gold: 2);
	}
}
