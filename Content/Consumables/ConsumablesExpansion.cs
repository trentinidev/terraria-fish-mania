using FishMania.Content.Buffs;
using FishMania.Content.Fish;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Consumables
{
	// ============ Expansion consumables (4 foods + 2 potions) ============

	public class FishTaco : FishFoodBase
	{
		protected override int FoodBuff => BuffID.WellFed2;
		protected override int BuffTime => 10 * 60 * 60;
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 50);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<Sunnyfish>(2)
				.AddTile(TileID.CookingPots)
				.Register();
		}
	}

	public class FishAndChips : FishFoodBase
	{
		protected override int FoodBuff => BuffID.WellFed2;
		protected override int BuffTime => 12 * 60 * 60;
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 55);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<PolarCod>(2)
				.AddTile(TileID.CookingPots)
				.Register();
		}
	}

	public class SpicyLavaStew : FishFoodBase
	{
		protected override int FoodBuff => BuffID.WellFed3;
		protected override int BuffTime => 15 * 60 * 60;
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(gold: 1, silver: 20);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<MagmaFish>()
				.AddIngredient(ItemID.Fireblossom)
				.AddIngredient(ItemID.Bowl)
				.AddTile(TileID.CookingPots)
				.Register();
		}
	}

	public class SeafoodPaella : FishFoodBase
	{
		protected override int FoodBuff => BuffID.WellFed3;
		protected override int BuffTime => 20 * 60 * 60;
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(gold: 2);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<MahiMahi>()
				.AddIngredient<SpottedMackerel>()
				.AddIngredient<SilverAnchovy>()
				.AddIngredient(ItemID.Bowl)
				.AddTile(TileID.CookingPots)
				.Register();
		}
	}

	// Potion base for the expansion potions.
	public abstract class FishingPotionBase : ModItem
	{
		protected abstract int BuffType { get; }
		protected abstract int BuffTime { get; }
		protected virtual int Rarity => ItemRarityID.Orange;
		protected virtual int SellValue => Item.sellPrice(silver: 40);

		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 20;
		}

		public override void SetDefaults() {
			Item.width = 16;
			Item.height = 26;
			Item.useStyle = ItemUseStyleID.DrinkLiquid;
			Item.useAnimation = 17;
			Item.useTime = 17;
			Item.useTurn = true;
			Item.UseSound = SoundID.Item3;
			Item.maxStack = Item.CommonMaxStack;
			Item.consumable = true;
			Item.rare = Rarity;
			Item.value = SellValue;
			Item.buffType = BuffType;
			Item.buffTime = BuffTime;
		}
	}

	public class LuckyAnglerPotion : FishingPotionBase
	{
		protected override int BuffType => ModContent.BuffType<LuckyAnglerBuff>();
		protected override int BuffTime => 8 * 60 * 60;

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient<GoldenKoi>()
				.AddIngredient(ItemID.Moonglow)
				.AddTile(TileID.Bottles)
				.Register();
		}
	}

	public class DepthsElixir : FishingPotionBase
	{
		protected override int BuffType => ModContent.BuffType<DepthsElixirBuff>();
		protected override int BuffTime => 6 * 60 * 60;
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(silver: 60);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient<ObsidianFish>()
				.AddIngredient(ItemID.Obsidian, 3)
				.AddTile(TileID.Bottles)
				.Register();
		}
	}
}
