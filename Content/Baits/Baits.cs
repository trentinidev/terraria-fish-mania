using FishMania.Content.Fish;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Baits
{
	// Base das iscas do mod.
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

	public class MinhocaGorda : BaitBase
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

	public class GrilaoCintilante : BaitBase
	{
		protected override int BaitPower => 30;
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 10);

		public override void AddRecipes() {
			CreateRecipe(3)
				.AddIngredient(ItemID.Firefly)
				.AddIngredient(ItemID.FallenStar)
				.Register();
		}
	}

	// Isca de lava: so funciona (e brilha) na lava.
	public class LarvaIgnea : BaitBase
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
				.AddIngredient<MinhocaGorda>(3)
				.AddIngredient(ItemID.Hellstone, 5)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}

	public class IscaDeNeon : BaitBase
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

	public class IscaHolografica : BaitBase
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

	public class IscaDoVazio : BaitBase
	{
		protected override int BaitPower => 60;
		protected override int Rarity => ItemRarityID.Lime;
		protected override int SellValue => Item.sellPrice(silver: 50);

		public override void AddRecipes() {
			CreateRecipe(3)
				.AddIngredient(ItemID.Ectoplasm)
				.AddIngredient<IscaDeNeon>(3)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}
}
