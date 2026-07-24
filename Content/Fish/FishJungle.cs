using Terraria;
using Terraria.ID;

namespace FishMania.Content.Fish
{
	// Peixes da selva.

	public class PiranhaEsmeralda : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 25);
	}

	public class TucunareSelvagem : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 30);
	}

	public class EnguiaVenenosa : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 35);
	}

	public class PirarucuAncestral : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightPurple;
		protected override int SellValue => Item.sellPrice(gold: 2);
	}
}
