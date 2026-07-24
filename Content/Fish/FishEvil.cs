using Terraria;
using Terraria.ID;

namespace FishMania.Content.Fish
{
	// Peixes da corrupcao e do carmim.

	public class PeixeSombrio : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 30);
	}

	public class DevoradorMirim : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 60);
	}

	public class PeixeCarmesim : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 30);
	}

	public class SanguessugaEscamada : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 60);
	}
}
