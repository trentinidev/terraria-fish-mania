using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Fish
{
	// Ocean fish.

	[LegacyName("SardinhaPrateada")]
	public class SilverSardine : FishItemBase
	{
		protected override int Rarity => ItemRarityID.White;
		protected override int SellValue => Item.sellPrice(silver: 6);
	}

	[LegacyName("AtumGigante")]
	public class GiantTuna : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 30);
	}

	[LegacyName("PeixePalhaco")]
	public class Clownfish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 25);
	}

	[LegacyName("BaiacuEspinhoso")]
	public class SpikyPufferfish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 25);
	}

	[LegacyName("PeixeEspadaReal")]
	public class RoyalSwordfish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(silver: 70);
	}

	[LegacyName("LinguadoSorrateiro")]
	public class SneakyFlounder : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 22);
	}
}
