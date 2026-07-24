using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Fish
{
	// Freshwater surface fish (forest / purity).

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

	[LegacyName("CarpaEspelhada")]
	public class MirrorCarp : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 20);
	}

	[LegacyName("BagreBigodudo")]
	public class BewhiskeredCatfish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.White;
		protected override int SellValue => Item.sellPrice(silver: 12);
	}

	[LegacyName("DouradoDoRio")]
	public class RiverDorado : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 60);
	}
}
