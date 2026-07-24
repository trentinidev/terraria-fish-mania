using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace FishMania.Content.Armor
{
	// Abyssal Diver Set: endgame fishing armor, upgrade of the Fisherman Set.
	// Each piece: +15 fishing power. Full set: permanent Fishing, Sonar and Crate
	// potion effects, lava fishing and water walking.

	[AutoloadEquip(EquipType.Head)]
	public class AbyssalDiverHelmet : ModItem
	{
		public static LocalizedText SetBonusText { get; private set; }

		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 1;
			SetBonusText = this.GetLocalization("SetBonus");
		}

		public override void SetDefaults() {
			Item.width = 26;
			Item.height = 18;
			Item.defense = 26;
			Item.rare = ItemRarityID.Red;
			Item.value = Item.sellPrice(gold: 8);
		}

		public override void UpdateEquip(Player player) {
			player.fishingSkill += 15;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ModContent.ItemType<AbyssalDiverSuit>() && legs.type == ModContent.ItemType<AbyssalDiverFins>();
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = SetBonusText.Value;
			player.fishingSkill += 15;
			player.sonarPotion = true;
			player.cratePotion = true;
			player.accLavaFishing = true;
			player.waterWalk = true;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<FishermanHat>()
				.AddIngredient(ItemID.LunarBar, 8)
				.AddIngredient<Content.Fish.ObsidianFish>(2)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
		}
	}

	[AutoloadEquip(EquipType.Body)]
	public class AbyssalDiverSuit : ModItem
	{
		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 1;
		}

		public override void SetDefaults() {
			Item.width = 26;
			Item.height = 24;
			Item.defense = 30;
			Item.rare = ItemRarityID.Red;
			Item.value = Item.sellPrice(gold: 10);
		}

		public override void UpdateEquip(Player player) {
			player.fishingSkill += 15;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<FishermanOveralls>()
				.AddIngredient(ItemID.LunarBar, 10)
				.AddIngredient<Content.Fish.ObsidianFish>(2)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
		}
	}

	[AutoloadEquip(EquipType.Legs)]
	public class AbyssalDiverFins : ModItem
	{
		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 1;
		}

		public override void SetDefaults() {
			Item.width = 24;
			Item.height = 18;
			Item.defense = 28;
			Item.rare = ItemRarityID.Red;
			Item.value = Item.sellPrice(gold: 8);
		}

		public override void UpdateEquip(Player player) {
			player.fishingSkill += 15;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<FishermanBoots>()
				.AddIngredient(ItemID.LunarBar, 8)
				.AddIngredient<Content.Fish.ObsidianFish>(2)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
		}
	}
}
