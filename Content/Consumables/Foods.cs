using Microsoft.Xna.Framework;
using FishMania.Content.Fish;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Consumables
{
	// Base das comidas de peixe. A sprite tem 3 quadros verticais:
	// inventario, segurando e colocada no prato.
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

	public class SushiDeLambari : FishFoodBase
	{
		protected override int FoodBuff => BuffID.WellFed;
		protected override int BuffTime => 8 * 60 * 60; // 8 minutos

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<Lambari>(2)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}

	public class MoquecaDeTilapia : FishFoodBase
	{
		protected override int FoodBuff => BuffID.WellFed2;
		protected override int BuffTime => 12 * 60 * 60; // 12 minutos
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 60);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<Tilapia>()
				.AddIngredient<BagreBigodudo>()
				.AddIngredient(ItemID.Bowl)
				.AddTile(TileID.CookingPots)
				.Register();
		}
	}

	public class BanqueteDoRei : FishFoodBase
	{
		protected override int FoodBuff => BuffID.WellFed3;
		protected override int BuffTime => 20 * 60 * 60; // 20 minutos
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(gold: 2);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<PirarucuAncestral>()
				.AddIngredient<AtumGigante>()
				.AddIngredient<DouradoDoRio>()
				.AddTile(TileID.CookingPots)
				.Register();
		}
	}
}
