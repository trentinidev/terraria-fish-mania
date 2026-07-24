using Microsoft.Xna.Framework;
using FishMania.Content.Fish;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Consumables
{
	// Base class for the fish dishes. The sprite has 3 vertical frames:
	// inventory, held and placed on a plate.
	public abstract class FishFoodBase : ModItem
	{
		protected abstract int FoodBuff { get; }
		protected abstract int BuffTime { get; }
		protected virtual int Rarity => ItemRarityID.Blue;
		protected virtual int SellValue => Item.sellPrice(silver: 30);

		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 5;

			Main.RegisterItemAnimation(Type, new DrawAnimationVertical(-1, 3) {
				NotActuallyAnimating = true
			});

			ItemID.Sets.FoodParticleColors[Type] = new Color[] {
				new Color(240, 240, 240),
				new Color(232, 130, 100),
				new Color(120, 180, 120)
			};

			ItemID.Sets.IsFood[Type] = true;
		}

		public override void SetDefaults() {
			Item.DefaultToFood(24, 24, FoodBuff, BuffTime);
			Item.rare = Rarity;
			Item.value = SellValue;
		}
	}

	[LegacyName("SushiDeLambari")]
	public class LambariSushi : FishFoodBase
	{
		protected override int FoodBuff => BuffID.WellFed;
		protected override int BuffTime => 8 * 60 * 60; // 8 minutes

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<Lambari>(2)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}

	[LegacyName("MoquecaDeTilapia")]
	public class TilapiaMoqueca : FishFoodBase
	{
		protected override int FoodBuff => BuffID.WellFed2;
		protected override int BuffTime => 12 * 60 * 60; // 12 minutes
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 60);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<Tilapia>()
				.AddIngredient<BewhiskeredCatfish>()
				.AddIngredient(ItemID.Bowl)
				.AddTile(TileID.CookingPots)
				.Register();
		}
	}

	[LegacyName("BanqueteDoRei")]
	public class KingsBanquet : FishFoodBase
	{
		protected override int FoodBuff => BuffID.WellFed3;
		protected override int BuffTime => 20 * 60 * 60; // 20 minutes
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(gold: 2);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<AncestralPirarucu>()
				.AddIngredient<GiantTuna>()
				.AddIngredient<RiverDorado>()
				.AddTile(TileID.CookingPots)
				.Register();
		}
	}
}
