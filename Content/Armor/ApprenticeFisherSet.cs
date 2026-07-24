using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace FishMania.Content.Armor
{
	// Apprentice Fisher Set: early-game fishing armor.
	// Each piece: +5 fishing power. Full set: the line never breaks and +5 extra fishing power.

	[AutoloadEquip(EquipType.Head)]
	public class ApprenticeFisherHat : ModItem
	{
		public static LocalizedText SetBonusText { get; private set; }

		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 1;
			SetBonusText = this.GetLocalization("SetBonus");
		}

		public override void SetDefaults() {
			Item.width = 26;
			Item.height = 16;
			Item.defense = 4;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(silver: 30);
		}

		public override void UpdateEquip(Player player) {
			player.fishingSkill += 5;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ModContent.ItemType<ApprenticeFisherVest>() && legs.type == ModContent.ItemType<ApprenticeFisherWaders>();
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = SetBonusText.Value;
			player.accFishingLine = true;
			player.fishingSkill += 5;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddRecipeGroup(RecipeGroupID.Wood, 10)
				.AddIngredient(ItemID.Silk, 5)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}

	[AutoloadEquip(EquipType.Body)]
	public class ApprenticeFisherVest : ModItem
	{
		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 1;
		}

		public override void SetDefaults() {
			Item.width = 26;
			Item.height = 22;
			Item.defense = 5;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(silver: 40);
		}

		public override void UpdateEquip(Player player) {
			player.fishingSkill += 5;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddRecipeGroup(RecipeGroupID.Wood, 15)
				.AddIngredient(ItemID.Silk, 8)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}

	[AutoloadEquip(EquipType.Legs)]
	public class ApprenticeFisherWaders : ModItem
	{
		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 1;
		}

		public override void SetDefaults() {
			Item.width = 22;
			Item.height = 18;
			Item.defense = 4;
			Item.rare = ItemRarityID.Blue;
			Item.value = Item.sellPrice(silver: 30);
		}

		public override void UpdateEquip(Player player) {
			player.fishingSkill += 5;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddRecipeGroup(RecipeGroupID.Wood, 12)
				.AddIngredient(ItemID.Silk, 6)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
