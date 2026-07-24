using Terraria;
using Terraria.ID;

namespace FishMania.Content.Fish
{
	// Peixes do deserto (oasis) e da neve.

	public class PeixeCacto : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 25);
	}

	public class BagreDoOasis : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 20);
	}

	public class SalmaoArtico : FishItemBase
	{
		protected override int Rarity => ItemRarityID.White;
		protected override int SellValue => Item.sellPrice(silver: 12);
	}

	public class BacalhauPolar : FishItemBase
	{
		protected override int Rarity => ItemRarityID.White;
		protected override int SellValue => Item.sellPrice(silver: 10);
	}

	public class PeixeCristal : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(silver: 80);
	}
}
