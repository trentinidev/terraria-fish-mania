using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Fish
{
	// Desert (oasis) and snow fish.

	[LegacyName("PeixeCacto")]
	public class CactusFish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 25);
	}

	[LegacyName("BagreDoOasis")]
	public class OasisCatfish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 20);
	}

	[LegacyName("SalmaoArtico")]
	public class ArcticSalmon : FishItemBase
	{
		protected override int Rarity => ItemRarityID.White;
		protected override int SellValue => Item.sellPrice(silver: 12);
	}

	[LegacyName("BacalhauPolar")]
	public class PolarCod : FishItemBase
	{
		protected override int Rarity => ItemRarityID.White;
		protected override int SellValue => Item.sellPrice(silver: 10);
	}

	[LegacyName("PeixeCristal")]
	public class CrystalFish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(silver: 80);
	}
}
