using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Baits
{
	// ============ Expansion baits (9 new, total 15) ============

	public class SpicedBeetle : BaitBase
	{
		protected override int BaitPower => 25;
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 8);

		public override void AddRecipes() {
			CreateRecipe(3)
				.AddIngredient(ItemID.Cactus, 3)
				.AddIngredient(ItemID.Worm)
				.Register();
		}
	}

	public class FrostFly : BaitBase
	{
		protected override int BaitPower => 30;
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 10);

		public override void AddRecipes() {
			CreateRecipe(3)
				.AddIngredient(ItemID.IceBlock, 5)
				.AddIngredient(ItemID.Worm)
				.Register();
		}
	}

	public class HoneyGrub : BaitBase
	{
		protected override int BaitPower => 35;
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 12);

		public override void AddRecipes() {
			CreateRecipe(3)
				.AddIngredient(ItemID.HoneyBlock, 2)
				.AddIngredient(ItemID.Worm)
				.Register();
		}
	}

	public class SporeMite : BaitBase
	{
		protected override int BaitPower => 38;
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 14);

		public override void AddRecipes() {
			CreateRecipe(3)
				.AddIngredient(ItemID.GlowingMushroom, 3)
				.AddIngredient<PlumpWorm>()
				.Register();
		}
	}

	public class GlowShrimp : BaitBase
	{
		protected override int BaitPower => 45;
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 20);

		public override void AddRecipes() {
			CreateRecipe(3)
				.AddIngredient(ItemID.Coral, 2)
				.AddIngredient(ItemID.Glowstick, 1)
				.Register();
		}
	}

	public class CrystalGnat : BaitBase
	{
		protected override int BaitPower => 48;
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(silver: 25);

		public override void AddRecipes() {
			CreateRecipe(3)
				.AddIngredient(ItemID.CrystalShard)
				.AddIngredient(ItemID.Firefly)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}

	public class StormWasp : BaitBase
	{
		protected override int BaitPower => 52;
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(silver: 30);

		public override void AddRecipes() {
			CreateRecipe(3)
				.AddIngredient(ItemID.SoulofFlight)
				.AddIngredient(ItemID.Stinger)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}

	public class SoulLeech : BaitBase
	{
		protected override int BaitPower => 55;
		protected override int Rarity => ItemRarityID.Pink;
		protected override int SellValue => Item.sellPrice(silver: 35);

		public override void AddRecipes() {
			CreateRecipe(3)
				.AddIngredient(ItemID.SoulofNight)
				.AddIngredient<PlumpWorm>(2)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}

	public class Starworm : BaitBase
	{
		protected override int BaitPower => 65;
		protected override int Rarity => ItemRarityID.Yellow;
		protected override int SellValue => Item.sellPrice(silver: 60);

		public override void AddRecipes() {
			CreateRecipe(3)
				.AddIngredient(ItemID.FallenStar, 2)
				.AddIngredient<VoidBait>()
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}
}
