using Terraria;
using Terraria.ID;

namespace FishMania.Content.Fish
{
	// ============ Expansion fish (62 new species, total 100) ============

	// ---- Forest / surface ----
	public class Bluegill : FishItemBase
	{
		protected override int Rarity => ItemRarityID.White;
		protected override int SellValue => Item.sellPrice(silver: 9);
	}

	public class RiverPerch : FishItemBase
	{
		protected override int Rarity => ItemRarityID.White;
		protected override int SellValue => Item.sellPrice(silver: 11);
	}

	public class GoldenKoi : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 70);
	}

	public class Sunnyfish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.White;
		protected override int SellValue => Item.sellPrice(silver: 8);
	}

	public class MudMinnow : FishItemBase
	{
		protected override int Rarity => ItemRarityID.White;
		protected override int SellValue => Item.sellPrice(silver: 6);
	}

	public class SilverBream : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 18);
	}

	public class GrassCarp : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 20);
	}

	// ---- Ocean ----
	public class SpottedMackerel : FishItemBase
	{
		protected override int Rarity => ItemRarityID.White;
		protected override int SellValue => Item.sellPrice(silver: 10);
	}

	public class SilverAnchovy : FishItemBase
	{
		protected override int Rarity => ItemRarityID.White;
		protected override int SellValue => Item.sellPrice(silver: 6);
	}

	public class RoyalGrouper : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(silver: 85);
	}

	public class MahiMahi : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 40);
	}

	public class Barracuda : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 38);
	}

	public class Lionfish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 60);
	}

	public class Opah : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightPurple;
		protected override int SellValue => Item.sellPrice(gold: 1, silver: 80);
	}

	// ---- Desert / oasis ----
	public class DesertPupfish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 22);
	}

	public class SandEel : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 30);
	}

	public class OasisPerch : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 24);
	}

	public class MirageFish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(silver: 90);
	}

	// ---- Snow ----
	public class ArcticChar : FishItemBase
	{
		protected override int Rarity => ItemRarityID.White;
		protected override int SellValue => Item.sellPrice(silver: 12);
	}

	public class FrostGrayling : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 22);
	}

	public class GlacierEel : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 32);
	}

	public class Snowflounder : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 24);
	}

	public class AuroraTrout : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(silver: 95);
	}

	// ---- Jungle ----
	public class RoyalArowana : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(silver: 90);
	}

	public class VoltEel : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 55);
	}

	public class LeafFish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 26);
	}

	public class PoisonDartFish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 34);
	}

	public class AmazonStingray : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 60);
	}

	// ---- Corruption ----
	public class RottenHerring : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 28);
	}

	public class ShadowflameEel : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 62);
	}

	public class CursedAnchovy : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 24);
	}

	// ---- Crimson ----
	public class IchorCarp : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 30);
	}

	public class FleshSnapper : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 58);
	}

	public class VeinFish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 24);
	}

	// ---- Hallow ----
	public class CrystalButterflyfish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(silver: 85);
	}

	public class UnicornFish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Pink;
		protected override int SellValue => Item.sellPrice(gold: 1, silver: 20);
	}

	public class PrismarineTrout : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(silver: 80);
	}

	// ---- Underground / caverns ----
	public class CrystalCavefish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 26);
	}

	public class GlowwormEel : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 36);
	}

	public class DeepDweller : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 68);
	}

	// ---- Glowing mushroom ----
	public class SporeSardine : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 26);
	}

	public class TruffleTrout : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 55);
	}

	// ---- Sky ----
	public class SkyManta : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 60);
	}

	public class StratusFish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 28);
	}

	public class CometMinnow : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(silver: 85);
	}

	// ---- Lava ----
	public class CinderSole : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(silver: 80);
	}

	public class AshKoi : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 60);
	}

	public class BasaltGrouper : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(silver: 95);
	}

	public class FlareEel : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightPurple;
		protected override int SellValue => Item.sellPrice(gold: 1, silver: 80);
	}

	// ---- Honey ----
	public class BumblebeeFish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 28);
	}

	public class RoyalJellyfish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 55);
	}

	// ---- Special conditions (night, blood moon, rain) ----
	public class MoonshadowBass : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 35);
	}

	public class StargazerFish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 65);
	}

	public class BloodMoonPiranha : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 70);
	}

	public class BloodEel : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(silver: 90);
	}

	public class StormFish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 35);
	}

	// ---- Legendary / fantasy ----
	public class LeviathanFry : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Red;
		protected override int SellValue => Item.sellPrice(gold: 8);

		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 1;
		}
	}

	public class MidasFish : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightPurple;
		protected override int SellValue => Item.sellPrice(gold: 5);
	}

	public class ClockworkPike : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightPurple;
		protected override int SellValue => Item.sellPrice(gold: 2, silver: 80);
	}

	public class VoidMaw : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Purple;
		protected override int SellValue => Item.sellPrice(gold: 6);
	}

	public class CelestialGuppy : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightPurple;
		protected override int SellValue => Item.sellPrice(gold: 3);
	}

	public class AbyssalAngler : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Purple;
		protected override int SellValue => Item.sellPrice(gold: 4);
	}
}
