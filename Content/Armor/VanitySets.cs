using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Armor
{
	// ============ Fishing-themed vanity sets (3 sets, 9 pieces) ============

	public abstract class VanityPieceBase : ModItem
	{
		protected abstract int SilkCost { get; }

		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 1;
		}

		public override void SetDefaults() {
			Item.width = 26;
			Item.height = 20;
			Item.vanity = true;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(silver: 50);
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Silk, SilkCost)
				.AddTile(TileID.Loom)
				.Register();
		}
	}

	// ---- Sailor (classic white and navy) ----

	[AutoloadEquip(EquipType.Head)]
	public class SailorCap : VanityPieceBase
	{
		protected override int SilkCost => 6;
	}

	[AutoloadEquip(EquipType.Body)]
	public class SailorShirt : VanityPieceBase
	{
		protected override int SilkCost => 10;
	}

	[AutoloadEquip(EquipType.Legs)]
	public class SailorPants : VanityPieceBase
	{
		protected override int SilkCost => 8;
	}

	// ---- Brass Diver (old-timey diving suit) ----

	[AutoloadEquip(EquipType.Head)]
	public class BrassDiverHelmet : VanityPieceBase
	{
		protected override int SilkCost => 6;

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Silk, 6)
				.AddIngredient(ItemID.CopperBar, 5)
				.AddTile(TileID.Loom)
				.Register();
			CreateRecipe()
				.AddIngredient(ItemID.Silk, 6)
				.AddIngredient(ItemID.TinBar, 5)
				.AddTile(TileID.Loom)
				.Register();
		}
	}

	[AutoloadEquip(EquipType.Body)]
	public class BrassDiverSuit : VanityPieceBase
	{
		protected override int SilkCost => 10;

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Silk, 10)
				.AddIngredient(ItemID.CopperBar, 8)
				.AddTile(TileID.Loom)
				.Register();
			CreateRecipe()
				.AddIngredient(ItemID.Silk, 10)
				.AddIngredient(ItemID.TinBar, 8)
				.AddTile(TileID.Loom)
				.Register();
		}
	}

	[AutoloadEquip(EquipType.Legs)]
	public class BrassDiverBoots : VanityPieceBase
	{
		protected override int SilkCost => 8;

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Silk, 8)
				.AddIngredient(ItemID.CopperBar, 5)
				.AddTile(TileID.Loom)
				.Register();
			CreateRecipe()
				.AddIngredient(ItemID.Silk, 8)
				.AddIngredient(ItemID.TinBar, 5)
				.AddTile(TileID.Loom)
				.Register();
		}
	}

	// ---- Fish Costume (goofy fish mascot) ----

	[AutoloadEquip(EquipType.Head)]
	public class FishCostumeMask : VanityPieceBase
	{
		protected override int SilkCost => 8;
	}

	[AutoloadEquip(EquipType.Body)]
	public class FishCostumeSuit : VanityPieceBase
	{
		protected override int SilkCost => 12;
	}

	[AutoloadEquip(EquipType.Legs)]
	public class FishCostumeTail : VanityPieceBase
	{
		protected override int SilkCost => 10;
	}
}
