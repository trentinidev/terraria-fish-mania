using FishMania.Content.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Rods
{
	// ============ Expansion rods (12 new, total 20) ============

	public class CactusRod : FishingRodBase
	{
		protected override int FishingPower => 12;
		protected override float BobberSpeed => 9.5f;
		protected override int BobberType => ModContent.ProjectileType<BobberCactus>();
		protected override int Rarity => ItemRarityID.White;
		protected override int SellValue => Item.sellPrice(silver: 4);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Cactus, 15)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}

	public class CoralRod : FishingRodBase
	{
		protected override int FishingPower => 18;
		protected override float BobberSpeed => 10.5f;
		protected override int BobberType => ModContent.ProjectileType<BobberCoral>();
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 25);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Coral, 10)
				.AddIngredient(ItemID.PalmWood, 8)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}

	public class BoneRod : FishingRodBase
	{
		protected override int FishingPower => 25;
		protected override float BobberSpeed => 12f;
		protected override int BobberType => ModContent.ProjectileType<BobberBone>();
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 60);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Bone, 30)
				.AddTile(TileID.BoneWelder)
				.Register();
		}
	}

	public class SpiderRod : FishingRodBase
	{
		protected override int FishingPower => 26;
		protected override float BobberSpeed => 12f;
		protected override int BobberType => ModContent.ProjectileType<BobberSpider>();
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 65);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.SpiderFang, 8)
				.AddRecipeGroup(RecipeGroupID.Wood, 8)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}

	public class HoneycombRod : FishingRodBase
	{
		protected override int FishingPower => 28;
		protected override float BobberSpeed => 12.5f;
		protected override int BobberType => ModContent.ProjectileType<BobberHoneycomb>();
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 70);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Hive, 20)
				.AddIngredient(ItemID.HoneyBlock, 5)
				.AddTile(TileID.HoneyDispenser)
				.Register();
		}
	}

	public class MushroomRod : FishingRodBase
	{
		protected override int FishingPower => 30;
		protected override float BobberSpeed => 12.5f;
		protected override int BobberType => ModContent.ProjectileType<BobberMushroom>();
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(silver: 80);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.GlowingMushroom, 20)
				.AddIngredient(ItemID.MushroomGrassSeeds, 2)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}

	public class MeteorRod : FishingRodBase
	{
		protected override int FishingPower => 32;
		protected override float BobberSpeed => 13f;
		protected override int BobberType => ModContent.ProjectileType<BobberMeteor>();
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(gold: 1);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.MeteoriteBar, 15)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}

	public class ObsidianRod : FishingRodBase
	{
		protected override int FishingPower => 34;
		protected override float BobberSpeed => 13f;
		protected override int BobberType => ModContent.ProjectileType<BobberObsidian>();
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(gold: 1, silver: 20);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Obsidian, 20)
				.AddIngredient(ItemID.HellstoneBar, 5)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}

	public class StormRod : FishingRodBase
	{
		protected override int FishingPower => 38;
		protected override float BobberSpeed => 14f;
		protected override int BobberType => ModContent.ProjectileType<BobberStorm>();
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(gold: 2);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.SunplateBlock, 12)
				.AddIngredient(ItemID.Feather, 5)
				.AddIngredient(ItemID.Cloud, 3)
				.AddTile(TileID.SkyMill)
				.Register();
		}
	}

	public class CrystalRod : FishingRodBase
	{
		protected override int FishingPower => 42;
		protected override float BobberSpeed => 15f;
		protected override int BobberType => ModContent.ProjectileType<BobberCrystal>();
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(gold: 3);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.CrystalShard, 15)
				.AddIngredient(ItemID.SoulofLight, 5)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}

	public class SpectralRod : FishingRodBase
	{
		protected override int FishingPower => 46;
		protected override float BobberSpeed => 15.5f;
		protected override int BobberType => ModContent.ProjectileType<BobberSpectral>();
		protected override int Rarity => ItemRarityID.Pink;
		protected override int SellValue => Item.sellPrice(gold: 4);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Ectoplasm, 12)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}

	public class ShroomiteRod : FishingRodBase
	{
		protected override int FishingPower => 50;
		protected override float BobberSpeed => 16f;
		protected override int BobberType => ModContent.ProjectileType<BobberShroomite>();
		protected override int Rarity => ItemRarityID.Lime;
		protected override int SellValue => Item.sellPrice(gold: 5);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.ShroomiteBar, 12)
				.AddTile(TileID.Autohammer)
				.Register();
		}
	}
}
