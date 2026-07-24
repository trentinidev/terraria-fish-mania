using Terraria;
using Terraria.ID;

namespace FishMania.Content.Fish
{
	// Peixes do sagrado e do subterraneo.

	public class PeixePrisma : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(silver: 80);
	}

	public class PeixeFada : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Pink;
		protected override int SellValue => Item.sellPrice(gold: 1, silver: 50);
	}

	public class PeixeCegoDasCavernas : FishItemBase
	{
		protected override int Rarity => ItemRarityID.White;
		protected override int SellValue => Item.sellPrice(silver: 15);
	}

	public class PeixeLanterna : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 70);
	}
}
