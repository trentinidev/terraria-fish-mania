using Terraria;
using Terraria.ID;

namespace FishMania.Content.Fish
{
	// Peixes do oceano.

	public class SardinhaPrateada : FishItemBase
	{
		protected override int Rarity => ItemRarityID.White;
		protected override int SellValue => Item.sellPrice(silver: 6);
	}

	public class AtumGigante : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 30);
	}

	public class PeixePalhaco : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 25);
	}

	public class BaiacuEspinhoso : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 25);
	}

	public class PeixeEspadaReal : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(silver: 70);
	}

	public class LinguadoSorrateiro : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 22);
	}
}
