using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Projectiles
{
	// Base class for the mod rods' bobbers.
	public abstract class BobberBase : ModProjectile
	{
		// Fishing line color of this bobber.
		public abstract Color LineColor { get; }

		// Whether the bobber emits its own light.
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

	[LegacyName("BobberBambu")]
	public class BobberBamboo : BobberBase
	{
		public override Color LineColor => new Color(160, 190, 90);
	}

	[LegacyName("BobberReforcado")]
	public class BobberReinforced : BobberBase
	{
		public override Color LineColor => new Color(180, 180, 190);
	}

	[LegacyName("BobberDourado")]
	public class BobberGilded : BobberBase
	{
		public override Color LineColor => new Color(255, 215, 0);
	}

	public class BobberGlacial : BobberBase
	{
		public override Color LineColor => new Color(140, 220, 255);
	}

	[LegacyName("BobberSelvagem")]
	public class BobberWildwood : BobberBase
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

	[LegacyName("BobberSupremo")]
	public class BobberSupreme : BobberBase
	{
		public override Color LineColor => new Color(80, 255, 220);
		protected override bool Glows => true;
	}
}
