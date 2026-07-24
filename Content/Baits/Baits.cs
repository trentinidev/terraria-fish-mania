using FishMania.Content.Fish;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Baits
{
	// Base class for the mod's baits.
	public abstract class BaitBase : ModItem
	{
		protected abstract int BaitPower { get; }
		protected virtual int Rarity => ItemRarityID.White;
		protected virtual int SellValue => Item.sellPrice(silver: 5);

		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 10;
		}

		public override void SetDefaults() {
			Item.width = 22;
			Item.height = 22;
			Item.maxStack = Item.CommonMaxStack;
			Item.consumable = true;
			Item.bait = BaitPower;
			Item.rare = Rarity;
			Item.value = SellValue;
		}
	}

	[LegacyName("MinhocaGorda")]
	public class PlumpWorm : BaitBase
	{
		protected override int BaitPower => 20;
		protected override int Rarity => ItemRarityID.White;

		public override void AddRecipes() {
			CreateRecipe(3)
				.AddIngredient(ItemID.Worm)
				.AddIngredient(ItemID.Gel, 2)
				.Register();
		}
	}

	[LegacyName("GrilaoCintilante")]
	public class SparklingCricket : BaitBase
	{
		protected override int BaitPower => 30;
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 10);

		public override void AddRecipes() {
			CreateRecipe(3)
				.AddIngredient(ItemID.Worm)
				.AddIngredient(ItemID.FallenStar)
				.Register();
		}
	}

	// Lava bait: only works (and glows) in lava.
	[LegacyName("LarvaIgnea")]
	public class IgneousLarva : BaitBase
	{
		protected override int BaitPower => 35;
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(silver: 20);

		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			ItemID.Sets.IsLavaBait[Type] = true;
		}

		public override void AddRecipes() {
			CreateRecipe(3)
				.AddIngredient<PlumpWorm>(3)
				.AddIngredient(ItemID.Hellstone, 5)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}

	[LegacyName("IscaDeNeon")]
	public class NeonBait : BaitBase
	{
		protected override int BaitPower => 40;
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 15);

		public override void AddRecipes() {
			CreateRecipe(3)
				.AddIngredient(ItemID.GlowingMushroom, 5)
				.AddIngredient(ItemID.Gel, 3)
				.Register();
		}
	}

	[LegacyName("IscaHolografica")]
	public class HolographicBait : BaitBase
	{
		protected override int BaitPower => 50;
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(silver: 30);

		public override void AddRecipes() {
			CreateRecipe(3)
				.AddIngredient(ItemID.SoulofLight)
				.AddIngredient(ItemID.Wire, 2)
				.AddIngredient(ItemID.Glass)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}

	[LegacyName("IscaDoVazio")]
	public class VoidBait : BaitBase
	{
		protected override int BaitPower => 60;
		protected override int Rarity => ItemRarityID.Lime;
		protected override int SellValue => Item.sellPrice(silver: 50);

		public override void AddRecipes() {
			CreateRecipe(3)
				.AddIngredient(ItemID.Ectoplasm)
				.AddIngredient<NeonBait>(3)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}
}
