using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace FishMania.Content.Armor
{
	// Fisherman Set: hardmode fishing armor.
	// Each piece gives +10 fishing power; the full set grants the permanent
	// effects of the Fishing, Sonar and Crate potions.
	// Recipe: the matching Angler set piece + 10 Hallowed Bars
	// (the Angler pieces are the Captain armor counterparts available in 1.4.4.9).

	[AutoloadEquip(EquipType.Head)]
	public class FishermanHat : ModItem
	{
		public static LocalizedText SetBonusText { get; private set; }

		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 1;
			SetBonusText = this.GetLocalization("SetBonus");
		}

		public override void SetDefaults() {
			Item.width = 26;
			Item.height = 18;
			Item.defense = 20;
			Item.rare = ItemRarityID.Lime;
			Item.value = Item.sellPrice(gold: 4);
		}

		public override void UpdateEquip(Player player) {
			player.fishingSkill += 10;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ModContent.ItemType<FishermanOveralls>() && legs.type == ModContent.ItemType<FishermanBoots>();
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = SetBonusText.Value;
			player.fishingSkill += 15;   // Fishing Potion effect
			player.sonarPotion = true;   // Sonar Potion effect
			player.cratePotion = true;   // Crate Potion effect
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.AnglerHat)
				.AddIngredient(ItemID.HallowedBar, 10)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}

	[AutoloadEquip(EquipType.Body)]
	public class FishermanOveralls : ModItem
	{
		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 1;
		}

		public override void SetDefaults() {
			Item.width = 26;
			Item.height = 24;
			Item.defense = 24;
			Item.rare = ItemRarityID.Lime;
			Item.value = Item.sellPrice(gold: 5);
		}

		public override void UpdateEquip(Player player) {
			player.fishingSkill += 10;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.AnglerVest)
				.AddIngredient(ItemID.HallowedBar, 10)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}

	[AutoloadEquip(EquipType.Legs)]
	public class FishermanBoots : ModItem
	{
		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 1;
		}

		public override void SetDefaults() {
			Item.width = 24;
			Item.height = 18;
			Item.defense = 22;
			Item.rare = ItemRarityID.Lime;
			Item.value = Item.sellPrice(gold: 4, silver: 50);
		}

		public override void UpdateEquip(Player player) {
			player.fishingSkill += 10;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.AnglerPants)
				.AddIngredient(ItemID.HallowedBar, 10)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}
}
