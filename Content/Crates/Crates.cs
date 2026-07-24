using FishMania.Content.Baits;
using FishMania.Content.Fish;
using Terraria;
using Terraria.GameContent.ItemDropRules;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Crates
{
	// ============ Biome fishing crates (3 themes x normal/hardmode) ============
	// Caught while fishing in the matching biome (see FishManiaPlayer.CatchFish).

	public abstract class BiomeCrateBase : ModItem
	{
		protected virtual int Rarity => ItemRarityID.Blue;
		protected virtual int SellValue => Item.sellPrice(silver: 50);
		protected virtual bool Hardmode => false;

		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 10;
			ItemID.Sets.IsFishingCrate[Type] = true;
			if (Hardmode) {
				ItemID.Sets.IsFishingCrateHardmode[Type] = true;
			}
		}

		public override void SetDefaults() {
			Item.width = 26;
			Item.height = 22;
			Item.maxStack = Item.CommonMaxStack;
			Item.rare = Rarity;
			Item.value = SellValue;
		}

		public override bool CanRightClick() => true;
	}

	// ---- Glowing mushroom biome ----

	public class MushroomCrate : BiomeCrateBase
	{
		public override void ModifyItemLoot(ItemLoot itemLoot) {
			itemLoot.Add(ItemDropRule.Common(ItemID.GoldCoin, 1, 2, 5));
			itemLoot.Add(ItemDropRule.Common(ItemID.GlowingMushroom, 1, 5, 15));
			itemLoot.Add(ItemDropRule.Common(ItemID.MushroomGrassSeeds, 2, 1, 3));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<NeonBait>(), 2, 2, 4));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<Mushfish>(), 3, 1, 2));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<SporeSardine>(), 3, 1, 2));
			itemLoot.Add(ItemDropRule.Common(ItemID.HealingPotion, 3, 2, 3));
		}
	}

	public class MyceliumCrate : BiomeCrateBase
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(gold: 1, silver: 50);
		protected override bool Hardmode => true;

		public override void ModifyItemLoot(ItemLoot itemLoot) {
			itemLoot.Add(ItemDropRule.Common(ItemID.GoldCoin, 1, 5, 10));
			itemLoot.Add(ItemDropRule.Common(ItemID.ChlorophyteBar, 2, 3, 6));
			itemLoot.Add(ItemDropRule.Common(ItemID.GlowingMushroom, 1, 10, 20));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<TruffleTrout>(), 3, 1, 2));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<VoidBait>(), 3, 1, 3));
			itemLoot.Add(ItemDropRule.Common(ItemID.GreaterHealingPotion, 3, 2, 4));
		}
	}

	// ---- Underground / caverns ----

	public class CavernCrate : BiomeCrateBase
	{
		public override void ModifyItemLoot(ItemLoot itemLoot) {
			itemLoot.Add(ItemDropRule.Common(ItemID.GoldCoin, 1, 1, 4));
			itemLoot.Add(ItemDropRule.Common(ItemID.Torch, 1, 10, 20));
			itemLoot.Add(ItemDropRule.OneFromOptions(1, ItemID.Amethyst, ItemID.Topaz, ItemID.Sapphire, ItemID.Emerald, ItemID.Ruby, ItemID.Diamond));
			itemLoot.Add(ItemDropRule.Common(ItemID.GoldBar, 2, 3, 6));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<BlindCavefish>(), 3, 1, 2));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<CrystalCavefish>(), 3, 1, 2));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<PlumpWorm>(), 2, 3, 6));
		}
	}

	public class DeepstoneCrate : BiomeCrateBase
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(gold: 1, silver: 50);
		protected override bool Hardmode => true;

		public override void ModifyItemLoot(ItemLoot itemLoot) {
			itemLoot.Add(ItemDropRule.Common(ItemID.GoldCoin, 1, 5, 10));
			itemLoot.Add(ItemDropRule.Common(ItemID.MythrilBar, 3, 3, 6));
			itemLoot.Add(ItemDropRule.Common(ItemID.TitaniumBar, 3, 3, 5));
			itemLoot.Add(ItemDropRule.OneFromOptions(1, ItemID.Amethyst, ItemID.Topaz, ItemID.Sapphire, ItemID.Emerald, ItemID.Ruby, ItemID.Diamond));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<DeepDweller>(), 3, 1, 2));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<SoulLeech>(), 3, 2, 4));
		}
	}

	// ---- Honey / hive ----

	public class HoneyCrate : BiomeCrateBase
	{
		public override void ModifyItemLoot(ItemLoot itemLoot) {
			itemLoot.Add(ItemDropRule.Common(ItemID.GoldCoin, 1, 1, 4));
			itemLoot.Add(ItemDropRule.Common(ItemID.BottledHoney, 1, 5, 10));
			itemLoot.Add(ItemDropRule.Common(ItemID.HoneyBlock, 2, 10, 20));
			itemLoot.Add(ItemDropRule.Common(ItemID.Stinger, 2, 2, 5));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<Honeyfish>(), 3, 1, 2));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<HoneyGrub>(), 2, 3, 6));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<BumblebeeFish>(), 3, 1, 2));
		}
	}

	public class RoyalJellyCrate : BiomeCrateBase
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(gold: 1, silver: 50);
		protected override bool Hardmode => true;

		public override void ModifyItemLoot(ItemLoot itemLoot) {
			itemLoot.Add(ItemDropRule.Common(ItemID.GoldCoin, 1, 5, 10));
			itemLoot.Add(ItemDropRule.Common(ItemID.BottledHoney, 1, 10, 15));
			itemLoot.Add(ItemDropRule.Common(ItemID.Beenade, 3, 5, 10));
			itemLoot.Add(ItemDropRule.Common(ItemID.SoulofLight, 3, 3, 6));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<RoyalJellyfish>(), 3, 1, 2));
			itemLoot.Add(ItemDropRule.Common(ModContent.ItemType<HoneyGrub>(), 2, 5, 8));
			itemLoot.Add(ItemDropRule.Common(ItemID.Stinger, 2, 5, 10));
		}
	}
}
