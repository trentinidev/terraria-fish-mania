using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Pets.AxolotlPal
{
	// Axolotl Pal: a pink axolotl pet that swims around the player.

	public class AxolotlPalItem : ModItem
	{
		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 1;
		}

		public override void SetDefaults() {
			Item.CloneDefaults(ItemID.ZephyrFish);
			Item.shoot = ModContent.ProjectileType<AxolotlPalProjectile>();
			Item.buffType = ModContent.BuffType<AxolotlPalBuff>();
			Item.rare = ItemRarityID.Orange;
			Item.value = Item.sellPrice(gold: 2);
		}

		public override bool? UseItem(Player player) {
			if (player.whoAmI == Main.myPlayer) {
				player.AddBuff(Item.buffType, 3600);
			}
			return true;
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.Bowl)
				.AddIngredient<Content.Fish.PeixeCristal>()
				.Register();
		}
	}

	public class AxolotlPalBuff : ModBuff
	{
		public override void SetStaticDefaults() {
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			bool unused = false;
			player.BuffHandle_SpawnPetIfNeededAndSetTime(buffIndex, ref unused, ModContent.ProjectileType<AxolotlPalProjectile>());
		}
	}

	public class AxolotlPalProjectile : ModProjectile
	{
		public override void SetStaticDefaults() {
			Main.projFrames[Type] = 4;
			Main.projPet[Type] = true;

			ProjectileID.Sets.CharacterPreviewAnimations[Type] = ProjectileID.Sets.SimpleLoop(0, Main.projFrames[Type], 6)
				.WithOffset(-10, -20f)
				.WithSpriteDirection(-1)
				.WithCode(DelegateMethods.CharacterPreview.Float);
		}

		public override void SetDefaults() {
			Projectile.CloneDefaults(ProjectileID.ZephyrFish);
			AIType = ProjectileID.ZephyrFish;
		}

		public override bool PreAI() {
			Player player = Main.player[Projectile.owner];
			player.zephyrfish = false;
			return true;
		}

		public override void AI() {
			Player player = Main.player[Projectile.owner];
			if (!player.dead && player.HasBuff(ModContent.BuffType<AxolotlPalBuff>())) {
				Projectile.timeLeft = 2;
			}
		}
	}
}
