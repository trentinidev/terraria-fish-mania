using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Projectiles
{
	// Base dos bobbers (boias) das varas do mod.
	public abstract class BobberBase : ModProjectile
	{
		// Cor da linha de pesca desta boia.
		public abstract Color LineColor { get; }

		// Se a boia deve emitir luz propria.
		protected virtual bool Glows => false;

		public override void SetDefaults() {
			Projectile.CloneDefaults(ProjectileID.BobberWooden);
			DrawOriginOffsetY = -8;
		}

		public override void AI() {
			if (!Main.dedServ && Glows) {
				Lighting.AddLight(Projectile.Center, LineColor.ToVector3() * 0.4f);
			}
		}
	}

	public class BobberBambu : BobberBase
	{
		public override Color LineColor => new Color(160, 190, 90);
	}

	public class BobberReforcado : BobberBase
	{
		public override Color LineColor => new Color(180, 180, 190);
	}

	public class BobberDourado : BobberBase
	{
		public override Color LineColor => new Color(255, 215, 0);
	}

	public class BobberGlacial : BobberBase
	{
		public override Color LineColor => new Color(140, 220, 255);
	}

	public class BobberSelvagem : BobberBase
	{
		public override Color LineColor => new Color(90, 200, 80);
	}

	public class BobberInfernal : BobberBase
	{
		public override Color LineColor => new Color(255, 120, 40);
		protected override bool Glows => true;
	}

	public class BobberCelestial : BobberBase
	{
		public override Color LineColor => new Color(200, 150, 255);
		protected override bool Glows => true;
	}

	public class BobberSupremo : BobberBase
	{
		public override Color LineColor => new Color(80, 255, 220);
		protected override bool Glows => true;
	}
}
