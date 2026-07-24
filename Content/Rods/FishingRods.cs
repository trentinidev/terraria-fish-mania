using Microsoft.Xna.Framework;
using FishMania.Content.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Rods
{
	// Base das varas de pescar do mod.
	public abstract class FishingRodBase : ModItem
	{
		protected abstract int FishingPower { get; }
		protected abstract float BobberSpeed { get; }
		protected abstract int BobberType { get; }
		protected virtual int Rarity => ItemRarityID.White;
		protected virtual int SellValue => Item.sellPrice(silver: 20);
		protected virtual Color LineColor => Color.Transparent;

		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 1;
		}

		public override void SetDefaults() {
			Item.CloneDefaults(ItemID.WoodFishingPole);
			Item.fishingPole = FishingPower;
			Item.shootSpeed = BobberSpeed;
			Item.shoot = BobberType;
			Item.rare = Rarity;
			Item.value = SellValue;
		}

		public override void ModifyFishingLine(Projectile bobber, ref Vector2 lineOriginOffset, ref Color lineColor) {
			lineOriginOffset = new Vector2(43, -30);
			if (bobber.ModProjectile is BobberBase modBobber) {
				lineColor = modBobber.LineColor;
			}
		}
	}

	// Vara inicial barata, alternativa a de madeira.
	public class VaraDeBambu : FishingRodBase
	{
		protected override int FishingPower => 15;
		protected override float BobberSpeed => 10f;
		protected override int BobberType => ModContent.ProjectileType<BobberBambu>();
		protected override int Rarity => ItemRarityID.White;
		protected override int SellValue => Item.sellPrice(silver: 5);

		public override void AddRecipes() {
			CreateRecipe()
				.AddRecipeGroup(RecipeGroupID.Wood, 15)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}

	public class VaraReforcada : FishingRodBase
	{
		protected override int FishingPower => 22;
		protected override float BobberSpeed => 11f;
		protected override int BobberType => ModContent.ProjectileType<BobberReforcado>();
		protected override int Rarity => ItemRarityID.Blue;
		protected override int SellValue => Item.sellPrice(silver: 30);

		public override void AddRecipes() {
			CreateRecipe()
				.AddRecipeGroup(RecipeGroupID.IronBar, 8)
				.AddRecipeGroup(RecipeGroupID.Wood, 5)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}

	public class VaraDourada : FishingRodBase
	{
		protected override int FishingPower => 30;
		protected override float BobberSpeed => 13f;
		protected override int BobberType => ModContent.ProjectileType<BobberDourado>();
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(gold: 1);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.GoldBar, 8)
				.AddTile(TileID.Anvils)
				.Register();
			CreateRecipe()
				.AddIngredient(ItemID.PlatinumBar, 8)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}

	public class VaraGlacial : FishingRodBase
	{
		protected override int FishingPower => 33;
		protected override float BobberSpeed => 13f;
		protected override int BobberType => ModContent.ProjectileType<BobberGlacial>();
		protected override int Rarity => ItemRarityID.Green;
		protected override int SellValue => Item.sellPrice(gold: 1, silver: 20);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.IceBlock, 30)
				.AddIngredient(ItemID.BorealWood, 8)
				.AddIngredient(ItemID.FlinxFur, 2)
				.AddTile(TileID.IceMachine)
				.Register();
		}
	}

	public class VaraSelvagem : FishingRodBase
	{
		protected override int FishingPower => 36;
		protected override float BobberSpeed => 13.5f;
		protected override int BobberType => ModContent.ProjectileType<BobberSelvagem>();
		protected override int Rarity => ItemRarityID.Orange;
		protected override int SellValue => Item.sellPrice(gold: 1, silver: 50);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.RichMahogany, 15)
				.AddIngredient(ItemID.JungleSpores, 6)
				.AddIngredient(ItemID.Stinger, 3)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}

	// Pesca em lava.
	public class VaraInfernal : FishingRodBase
	{
		protected override int FishingPower => 40;
		protected override float BobberSpeed => 14f;
		protected override int BobberType => ModContent.ProjectileType<BobberInfernal>();
		protected override int Rarity => ItemRarityID.LightRed;
		protected override int SellValue => Item.sellPrice(gold: 3);

		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			ItemID.Sets.CanFishInLava[Type] = true;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.HellstoneBar, 12)
				.AddIngredient(ItemID.Obsidian, 6)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}

	public class VaraCelestial : FishingRodBase
	{
		protected override int FishingPower => 48;
		protected override float BobberSpeed => 16f;
		protected override int BobberType => ModContent.ProjectileType<BobberCelestial>();
		protected override int Rarity => ItemRarityID.Pink;
		protected override int SellValue => Item.sellPrice(gold: 6);

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.HallowedBar, 10)
				.AddIngredient(ItemID.CrystalShard, 8)
				.AddIngredient(ItemID.SoulofLight, 5)
				.AddTile(TileID.MythrilAnvil)
				.Register();
		}
	}

	// Vara final: pesca em lava e linha que nunca arrebenta.
	public class VaraDoPescadorSupremo : FishingRodBase
	{
		protected override int FishingPower => 55;
		protected override float BobberSpeed => 17f;
		protected override int BobberType => ModContent.ProjectileType<BobberSupremo>();
		protected override int Rarity => ItemRarityID.Red;
		protected override int SellValue => Item.sellPrice(gold: 15);

		public override void SetStaticDefaults() {
			base.SetStaticDefaults();
			ItemID.Sets.CanFishInLava[Type] = true;
		}

		public override void HoldItem(Player player) {
			player.accFishingLine = true;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<VaraCelestial>()
				.AddIngredient<VaraInfernal>()
				.AddIngredient(ItemID.LunarBar, 8)
				.AddTile(TileID.LunarCraftingStation)
				.Register();
		}
	}
}
