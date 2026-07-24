using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Accessories
{
	// Base class for the fishing accessories.
	public abstract class FishingAccessoryBase : ModItem
	{
		protected virtual int Rarity => ItemRarityID.Blue;
		protected virtual int SellValue => Item.sellPrice(silver: 50);

		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 1;
		}

		public override void SetDefaults() {
			Item.DefaultToAccessory(28, 28);
			Item.rare = Rarity;
			Item.value = SellValue;
		}
	}

	// +10 fishing power.
	[LegacyName("AnzolDourado")]
	public class GoldenHook : FishingAccessoryBase
	{
		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.fishingSkill += 10;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.GoldBar, 5)
				.AddTile(TileID.Anvils)
				.Register();
			CreateRecipe()
				.AddIngredient(ItemID.PlatinumBar, 5)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}

	// +12 fishing power and the line never breaks.
	[LegacyName("CarretelDeSeda")]
	public class SilkReel : FishingAccessoryBase
	{
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 80);

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.fishingSkill += 12;
			player.accFishingLine = true;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Silk, 8)
				.AddRecipeGroup(RecipeGroupID.IronBar, 5)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}

	// +15 fishing power and a chance not to consume bait.
	[LegacyName("CaixaDeApetrechos")]
	public class TackleKit : FishingAccessoryBase
	{
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(gold: 1);

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.fishingSkill += 15;
			player.accTackleBox = true;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddRecipeGroup(RecipeGroupID.IronBar, 8)
				.AddRecipeGroup(RecipeGroupID.Wood, 12)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}

	// +5 fishing power and a permanent Sonar Potion effect.
	[LegacyName("SonarPortatil")]
	public class PortableSonar : FishingAccessoryBase
	{
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(gold: 1, silver: 50);

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.fishingSkill += 5;
			player.sonarPotion = true;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Wire, 10)
				.AddIngredient(ItemID.Glass, 5)
				.AddIngredient(ItemID.GoldBar, 3)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}

	// +20 fishing power, plus +10 while it rains.
	[LegacyName("AmuletoDoMarProfundo")]
	public class DeepSeaAmulet : FishingAccessoryBase
	{
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(gold: 2);

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.fishingSkill += 20;
			if (Main.raining) {
				player.fishingSkill += 10;
			}
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.WhitePearl)
				.AddIngredient(ItemID.SoulofNight, 8)
				.AddIngredient(ItemID.Chain)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}

	// +8 fishing power and allows walking on water.
	[LegacyName("BoiaDaSorte")]
	public class LuckyBuoy : FishingAccessoryBase
	{
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(gold: 1);

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.fishingSkill += 8;
			player.waterWalk = true;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Silk, 5)
				.AddIngredient(ItemID.Gel, 10)
				.AddIngredient(ItemID.SharkFin)
				.AddTile(TileID.Loom)
				.Register();
		}
	}

	// Combines every fishing accessory in the mod: +25 fishing power,
	// unbreakable line, tackle box, sonar, lava fishing and water walking.
	[LegacyName("EquipamentoDoPescadorLendario")]
	public class LegendaryAnglersGear : FishingAccessoryBase
	{
		protected override int Rarity => ItemRarityID.Red;
		protected override int SellValue => Item.sellPrice(gold: 10);

		public override void UpdateAccessory(Player player, bool hideVisual) {
			player.fishingSkill += 25;
			if (Main.raining) {
				player.fishingSkill += 10;
			}
			player.accFishingLine = true;
			player.accTackleBox = true;
			player.sonarPotion = true;
			player.accLavaFishing = true;
			player.waterWalk = true;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<GoldenHook>()
				.AddIngredient<SilkReel>()
				.AddIngredient<TackleKit>()
				.AddIngredient<PortableSonar>()
				.AddIngredient<DeepSeaAmulet>()
				.AddIngredient<LuckyBuoy>()
				.AddTile(TileID.TinkerersWorkbench)
				.Register();
		}
	}
}
