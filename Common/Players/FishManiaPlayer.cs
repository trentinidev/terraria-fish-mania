using FishMania.Content.Crates;
using FishMania.Content.Fish;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace FishMania.Common.Players
{
	// Decides when vanilla catches are replaced by FishMania fish and crates.
	public class FishManiaPlayer : ModPlayer
	{
		// Set by the Lucky Lure accessory.
		public bool luckyLure;

		public override void ResetEffects() {
			luckyLure = false;
		}

		public override void ModifyLuck(ref float luck) {
			if (luckyLure) {
				luck += 0.1f;
			}
		}

		public override void CatchFish(FishingAttempt attempt, ref int itemDrop, ref int npcSpawn, ref AdvancedPopupRequest sonar, ref Vector2 sonarPosition) {
			var rand = Main.rand;

			// ---- Crates: substitute biome crates, never lava nor top-tier ones ----
			if (attempt.crate) {
				if (attempt.inLava || attempt.veryrare || attempt.legendary) {
					return;
				}
				bool hm = Main.hardMode;
				if (attempt.inHoney) {
					if (rand.NextBool(2)) {
						itemDrop = hm ? ModContent.ItemType<RoyalJellyCrate>() : ModContent.ItemType<HoneyCrate>();
					}
				}
				else if (Player.ZoneGlowshroom) {
					if (rand.NextBool(2)) {
						itemDrop = hm ? ModContent.ItemType<MyceliumCrate>() : ModContent.ItemType<MushroomCrate>();
					}
				}
				else if (attempt.heightLevel >= 2 && rand.NextBool(3)) {
					itemDrop = hm ? ModContent.ItemType<DeepstoneCrate>() : ModContent.ItemType<CavernCrate>();
				}
				return;
			}

			// Never replace the Angler's quest fish.
			if (attempt.questFish > 0 && itemDrop == attempt.questFish) {
				return;
			}

			int fishingLevel = attempt.playerFishingConditions.FinalFishingLevel;
			int Pick(params int[] ids) => ids[rand.Next(ids.Length)];

			// ---- Lava ----
			if (attempt.inLava) {
				if (attempt.legendary && rand.NextBool(4)) {
					itemDrop = ModContent.ItemType<FlareEel>();
				}
				else if (attempt.veryrare) {
					itemDrop = Pick(ModContent.ItemType<PeixeObsidiana>(), ModContent.ItemType<BasaltGrouper>());
				}
				else if (attempt.rare) {
					itemDrop = Pick(ModContent.ItemType<PeixeMagma>(), ModContent.ItemType<CinderSole>());
				}
				else if (attempt.uncommon && rand.NextBool(2)) {
					itemDrop = ModContent.ItemType<AshKoi>();
				}
				return;
			}

			// ---- Honey ----
			if (attempt.inHoney) {
				if (attempt.rare) {
					itemDrop = ModContent.ItemType<RoyalJellyfish>();
				}
				else if (attempt.uncommon) {
					itemDrop = Pick(ModContent.ItemType<PeixeMel>(), ModContent.ItemType<BumblebeeFish>());
				}
				else if (attempt.common && rand.NextBool(2)) {
					itemDrop = ModContent.ItemType<BumblebeeFish>();
				}
				return;
			}

			// ---- Blood moon ----
			if (Main.bloodMoon && attempt.heightLevel <= 1) {
				if (attempt.rare) {
					itemDrop = ModContent.ItemType<BloodEel>();
					return;
				}
				if (attempt.uncommon && rand.NextBool(2)) {
					itemDrop = ModContent.ItemType<BloodMoonPiranha>();
					return;
				}
			}

			// ---- Global legendaries ----
			if (attempt.legendary && Player.ZoneBeach && rand.NextBool(4)) {
				itemDrop = ModContent.ItemType<LeviathanFry>();
				sonar.Text = Language.GetTextValue("Mods.FishMania.Sonar.LeviathanFry");
				sonar.Color = Color.DeepSkyBlue;
				sonar.Velocity = Vector2.Zero;
				sonar.DurationInFrames = 300;
				sonarPosition = new Vector2(Player.position.X, Player.position.Y - 64);
				return;
			}

			if (attempt.legendary && fishingLevel >= 80 && rand.NextBool(4)) {
				itemDrop = ModContent.ItemType<ReiDosPeixes>();
				sonar.Text = Language.GetTextValue("Mods.FishMania.Sonar.ReiDosPeixes");
				sonar.Color = Color.Gold;
				sonar.Velocity = Vector2.Zero;
				sonar.DurationInFrames = 300;
				sonarPosition = new Vector2(Player.position.X, Player.position.Y - 64);
				return;
			}

			if (attempt.legendary && !Main.dayTime && attempt.heightLevel >= 3 && rand.NextBool(3)) {
				itemDrop = rand.NextBool()
					? ModContent.ItemType<PeixeDoVazio>()
					: ModContent.ItemType<VoidMaw>();
				sonar.Text = Language.GetTextValue("Mods.FishMania.Sonar.PeixeDoVazio");
				sonar.Color = Color.MediumPurple;
				sonar.Velocity = Vector2.Zero;
				sonar.DurationInFrames = 300;
				sonarPosition = new Vector2(Player.position.X, Player.position.Y - 64);
				return;
			}

			if (attempt.legendary && attempt.heightLevel >= 2 && rand.NextBool(4)) {
				itemDrop = ModContent.ItemType<AbyssalAngler>();
				return;
			}

			if (attempt.veryrare) {
				if (!Main.dayTime && attempt.heightLevel == 0 && rand.NextBool(3)) {
					itemDrop = ModContent.ItemType<CelestialGuppy>();
					return;
				}
				if (!Main.dayTime && attempt.heightLevel <= 1 && rand.NextBool(5)) {
					itemDrop = ModContent.ItemType<PeixeEstrelaCadente>();
					return;
				}
				if (rand.NextBool(9)) {
					itemDrop = ModContent.ItemType<CarpaLendaria>();
					return;
				}
				if (rand.NextBool(9)) {
					itemDrop = Pick(ModContent.ItemType<PeixeRobo>(), ModContent.ItemType<ClockworkPike>());
					return;
				}
				if (rand.NextBool(10)) {
					itemDrop = ModContent.ItemType<MidasFish>();
					return;
				}
			}

			// ---- Rain (surface) ----
			if (Main.raining && attempt.heightLevel <= 1 && attempt.uncommon && rand.NextBool(3)) {
				itemDrop = ModContent.ItemType<StormFish>();
				return;
			}

			// ---- Biome tables: 55% chance to replace the vanilla catch ----
			if (rand.Next(100) >= 55) {
				return;
			}

			if (Player.ZoneBeach) {
				if (attempt.veryrare) {
					itemDrop = ModContent.ItemType<Opah>();
				}
				else if (attempt.rare) {
					itemDrop = Pick(ModContent.ItemType<PeixeEspadaReal>(), ModContent.ItemType<RoyalGrouper>(), ModContent.ItemType<Lionfish>());
				}
				else if (attempt.uncommon) {
					itemDrop = Pick(ModContent.ItemType<AtumGigante>(), ModContent.ItemType<PeixePalhaco>(), ModContent.ItemType<BaiacuEspinhoso>(),
						ModContent.ItemType<LinguadoSorrateiro>(), ModContent.ItemType<MahiMahi>(), ModContent.ItemType<Barracuda>());
				}
				else if (attempt.common) {
					itemDrop = Pick(ModContent.ItemType<SardinhaPrateada>(), ModContent.ItemType<SilverAnchovy>(), ModContent.ItemType<SpottedMackerel>());
				}
			}
			else if (Player.ZoneSnow) {
				if (attempt.veryrare) {
					itemDrop = ModContent.ItemType<AuroraTrout>();
				}
				else if (attempt.rare) {
					itemDrop = ModContent.ItemType<PeixeCristal>();
				}
				else if (attempt.uncommon) {
					itemDrop = Pick(ModContent.ItemType<FrostGrayling>(), ModContent.ItemType<GlacierEel>(), ModContent.ItemType<Snowflounder>());
				}
				else if (attempt.common) {
					itemDrop = Pick(ModContent.ItemType<SalmaoArtico>(), ModContent.ItemType<BacalhauPolar>(), ModContent.ItemType<ArcticChar>());
				}
			}
			else if (Player.ZoneJungle) {
				if (attempt.veryrare) {
					itemDrop = Pick(ModContent.ItemType<PirarucuAncestral>(), ModContent.ItemType<RoyalArowana>());
				}
				else if (attempt.rare) {
					itemDrop = Pick(ModContent.ItemType<EnguiaVenenosa>(), ModContent.ItemType<VoltEel>(), ModContent.ItemType<AmazonStingray>());
				}
				else if (attempt.uncommon) {
					itemDrop = Pick(ModContent.ItemType<PiranhaEsmeralda>(), ModContent.ItemType<TucunareSelvagem>(),
						ModContent.ItemType<LeafFish>(), ModContent.ItemType<PoisonDartFish>());
				}
			}
			else if (Player.ZoneCorrupt) {
				if (attempt.rare) {
					itemDrop = Pick(ModContent.ItemType<DevoradorMirim>(), ModContent.ItemType<ShadowflameEel>());
				}
				else if (attempt.uncommon) {
					itemDrop = Pick(ModContent.ItemType<PeixeSombrio>(), ModContent.ItemType<RottenHerring>(), ModContent.ItemType<CursedAnchovy>());
				}
			}
			else if (Player.ZoneCrimson) {
				if (attempt.rare) {
					itemDrop = Pick(ModContent.ItemType<SanguessugaEscamada>(), ModContent.ItemType<FleshSnapper>());
				}
				else if (attempt.uncommon) {
					itemDrop = Pick(ModContent.ItemType<PeixeCarmesim>(), ModContent.ItemType<IchorCarp>(), ModContent.ItemType<VeinFish>());
				}
			}
			else if (Player.ZoneHallow) {
				if (attempt.veryrare) {
					itemDrop = Pick(ModContent.ItemType<PeixeFada>(), ModContent.ItemType<UnicornFish>());
				}
				else if (attempt.rare) {
					itemDrop = Pick(ModContent.ItemType<PeixePrisma>(), ModContent.ItemType<CrystalButterflyfish>(), ModContent.ItemType<PrismarineTrout>());
				}
			}
			else if (Player.ZoneGlowshroom) {
				if (attempt.rare) {
					itemDrop = ModContent.ItemType<TruffleTrout>();
				}
				else if (attempt.uncommon) {
					itemDrop = Pick(ModContent.ItemType<Cogupeixe>(), ModContent.ItemType<SporeSardine>());
				}
			}
			else if (Player.ZoneDesert) {
				if (attempt.rare) {
					itemDrop = ModContent.ItemType<MirageFish>();
				}
				else if (attempt.uncommon) {
					itemDrop = Pick(ModContent.ItemType<PeixeCacto>(), ModContent.ItemType<BagreDoOasis>(),
						ModContent.ItemType<DesertPupfish>(), ModContent.ItemType<SandEel>(), ModContent.ItemType<OasisPerch>());
				}
			}
			else if (attempt.heightLevel == 0) {
				// Sky fishing.
				if (attempt.rare) {
					itemDrop = Pick(ModContent.ItemType<PeixeNuvem>(), ModContent.ItemType<SkyManta>(), ModContent.ItemType<CometMinnow>());
				}
				else if (attempt.uncommon) {
					itemDrop = ModContent.ItemType<StratusFish>();
				}
			}
			else if (attempt.heightLevel >= 2) {
				// Underground and caverns.
				if (attempt.rare) {
					itemDrop = Pick(ModContent.ItemType<PeixeLanterna>(), ModContent.ItemType<DeepDweller>());
				}
				else if (attempt.uncommon) {
					itemDrop = Pick(ModContent.ItemType<BagreBigodudo>(), ModContent.ItemType<GlowwormEel>(), ModContent.ItemType<CrystalCavefish>());
				}
				else if (attempt.common) {
					itemDrop = ModContent.ItemType<PeixeCegoDasCavernas>();
				}
			}
			else {
				// Forest / purity surface (with night specials).
				if (!Main.dayTime && attempt.rare && rand.NextBool(2)) {
					itemDrop = ModContent.ItemType<StargazerFish>();
				}
				else if (!Main.dayTime && attempt.uncommon && rand.NextBool(3)) {
					itemDrop = ModContent.ItemType<MoonshadowBass>();
				}
				else if (attempt.rare) {
					itemDrop = Pick(ModContent.ItemType<DouradoDoRio>(), ModContent.ItemType<GoldenKoi>());
				}
				else if (attempt.uncommon) {
					itemDrop = Pick(ModContent.ItemType<CarpaEspelhada>(), ModContent.ItemType<BagreBigodudo>(),
						ModContent.ItemType<SilverBream>(), ModContent.ItemType<GrassCarp>(), ModContent.ItemType<RiverPerch>());
				}
				else if (attempt.common) {
					itemDrop = Pick(ModContent.ItemType<Tilapia>(), ModContent.ItemType<Lambari>(),
						ModContent.ItemType<Bluegill>(), ModContent.ItemType<Sunnyfish>(), ModContent.ItemType<MudMinnow>());
				}
			}
		}
	}
}
