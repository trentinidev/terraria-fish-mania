using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Pets.PeixinhoDourado
{
	// Peixinho dourado flutuante que segue o jogador (comportamento do Peixe-Zefiro).
	public class PeixinhoDouradoProjectile : ModProjectile
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
			player.zephyrfish = false; // resquicio do AIType
			return true;
		}

		public override void AI() {
			Player player = Main.player[Projectile.owner];
			if (!player.dead && player.HasBuff(ModContent.BuffType<PeixinhoDouradoBuff>())) {
				Projectile.timeLeft = 2;
			}
		}
	}
}
