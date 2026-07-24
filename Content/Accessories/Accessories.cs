using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Accessories
{
	// Base dos acessorios de pesca.
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

	// +10 de poder de pesca.
	public class AnzolDourado : FishingAccessoryBase
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

	// +12 de pesca e a linha nunca arrebenta.
	public class CarretelDeSeda : FishingAccessoryBase
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

	// +15 de pesca e chance de nao consumir iscas.
	public class CaixaDeApetrechos : FishingAccessoryBase
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

	// +5 de pesca e efeito permanente de Pocao de Sonar.
	public class SonarPortatil : FishingAccessoryBase
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

	// +20 de pesca, e +10 extra enquanto chove.
	public class AmuletoDoMarProfundo : FishingAccessoryBase
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

	// +8 de pesca e permite andar sobre a agua.
	public class BoiaDaSorte : FishingAccessoryBase
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

	// Combina todos os acessorios de pesca do mod: +25 de pesca,
	// linha inquebravel, caixa de apetrechos, sonar, pesca em lava e andar na agua.
	public class EquipamentoDoPescadorLendario : FishingAccessoryBase
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
				.AddIngredient<AnzolDourado>()
				.AddIngredient<CarretelDeSeda>()
				.AddIngredient<CaixaDeApetrechos>()
				.AddIngredient<SonarPortatil>()
				.AddIngredient<AmuletoDoMarProfundo>()
				.AddIngredient<BoiaDaSorte>()
				.AddTile(TileID.TinkerersWorkbench)
				.Register();
		}
	}
}
