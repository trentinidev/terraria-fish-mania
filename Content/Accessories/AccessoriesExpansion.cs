using FishMania.Common.Players;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Accessories
{
	// ============ Expansion accessories (3 new, total 10) ============

	// +12 fishing power and increased luck while equipped.
	public class LuckyLure : FishingAccessoryBase
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(gold: 2);

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.fishingSkill += 12;
			player.GetModPlayer<FishManiaPlayer>().luckyLure = true;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.GoldBar, 6)
				.AddIngredient<Content.Fish.PeixeFada>()
				.AddTile(TileID.Anvils)
				.Register();
		}
	}

	// Permanent Crate Potion effect and +8 fishing power.
	public class CrateMagnet : FishingAccessoryBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(gold: 1, silver: 50);

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.fishingSkill += 8;
			player.cratePotion = true;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddRecipeGroup(RecipeGroupID.IronBar, 10)
				.AddIngredient(ItemID.Wire, 8)
				.AddIngredient(ItemID.SoulofLight, 5)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}

	// Lava fishing + tackle box effect + 10 fishing power.
	public class LavaproofTackleBag : FishingAccessoryBase
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(gold: 2, silver: 50);

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.fishingSkill += 10;
			player.accLavaFishing = true;
			player.accTackleBox = true;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.HellstoneBar, 10)
				.AddIngredient(ItemID.Silk, 5)
				.AddIngredient<Content.Baits.LarvaIgnea>(5)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}
