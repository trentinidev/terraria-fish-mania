using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Fish
{
	// Special biome fish: glowing mushroom, sky, honey and lava.

	[LegacyName("Cogupeixe")]
	public class Mushfish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 50);
	}

	[LegacyName("PeixeNuvem")]
	public class Cloudfish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 50);
	}

	[LegacyName("PeixeMel")]
	public class Honeyfish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 45);
	}

	[LegacyName("PeixeMagma")]
	public class MagmaFish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(silver: 90);
	}

	[LegacyName("PeixeObsidiana")]
	public class ObsidianFish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightPurple;
		protected override int SellValue => Item.sellPrice(gold: 2);
	}
}
