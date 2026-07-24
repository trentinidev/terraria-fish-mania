using Microsoft.Xna.Framework;

namespace FishMania.Content.Projectiles
{
	// Bobbers for the 12 expansion rods.

	public class BobberCactus : BobberBase
	{
		public override Color LineColor => new Color(120, 180, 90);
	}

	public class BobberCoral : BobberBase
	{
		public override Color LineColor => new Color(250, 128, 114);
	}

	public class BobberSpider : BobberBase
	{
		public override Color LineColor => new Color(150, 140, 160);
	}

	public class BobberBone : BobberBase
	{
		public override Color LineColor => new Color(226, 219, 197);
	}

	public class BobberHoneycomb : BobberBase
	{
		public override Color LineColor => new Color(245, 190, 60);
	}

	public class BobberMushroom : BobberBase
	{
		public override Color LineColor => new Color(110, 170, 255);
		protected override bool Glows => true;
	}

	public class BobberMeteor : BobberBase
	{
		public override Color LineColor => new Color(190, 110, 70);
	}

	public class BobberObsidian : BobberBase
	{
		public override Color LineColor => new Color(120, 80, 200);
	}

	public class BobberStorm : BobberBase
	{
		public override Color LineColor => new Color(200, 215, 235);
	}

	public class BobberCrystal : BobberBase
	{
		public override Color LineColor => new Color(230, 140, 210);
		protected override bool Glows => true;
	}

	public class BobberSpectral : BobberBase
	{
		public override Color LineColor => new Color(130, 245, 200);
		protected override bool Glows => true;
	}

	public class BobberShroomite : BobberBase
	{
		public override Color LineColor => new Color(90, 160, 255);
		protected override bool Glows => true;
	}
}
