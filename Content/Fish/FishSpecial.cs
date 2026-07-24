using Terraria;
using Terraria.ID;

namespace FishMania.Content.Fish
{
	// Peixes de biomas especiais: cogumelo, ceu, mel e lava.

	public class Cogupeixe : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 50);
	}

	public class PeixeNuvem : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 50);
	}

	public class PeixeMel : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 45);
	}

	public class PeixeMagma : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(silver: 90);
	}

	public class PeixeObsidiana : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightPurple;
		protected override int SellValue => Item.sellPrice(gold: 2);
	}
}
