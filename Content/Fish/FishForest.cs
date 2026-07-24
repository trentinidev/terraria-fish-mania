using Terraria;
using Terraria.ID;

namespace FishMania.Content.Fish
{
	// Peixes de agua doce da superficie (floresta / pureza).

	public class Tilapia : FishItemBase
	{
		protected override int Rarity => ItemRarityID.White;
		protected override int SellValue => Item.sellPrice(silver: 8);
	}

	public class Lambari : FishItemBase
	{
		protected override int Rarity => ItemRarityID.White;
		protected override int SellValue => Item.sellPrice(silver: 5);
	}

	public class CarpaEspelhada : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 20);
	}

	public class BagreBigodudo : FishItemBase
	{
		protected override int Rarity => ItemRarityID.White;
		protected override int SellValue => Item.sellPrice(silver: 12);
	}

	public class DouradoDoRio : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 60);
	}
}
