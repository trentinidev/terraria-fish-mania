using Terraria;
using Terraria.ID;

namespace FishMania.Content.Fish
{
	// Peixes lendarios e fantasiosos, raros em qualquer lugar.

	public class CarpaLendaria : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightPurple;
		protected override int SellValue => Item.sellPrice(gold: 2, silver: 50);
	}

	public class PeixeRobo : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightPurple;
		protected override int SellValue => Item.sellPrice(gold: 2, silver: 50);
	}

	public class PeixeEstrelaCadente : FishItemBase
	{
		protected override int Rarity => ItemRarityID.LightPurple;
		protected override int SellValue => Item.sellPrice(gold: 3);
	}

	public class PeixeDoVazio : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Purple;
		protected override int SellValue => Item.sellPrice(gold: 5);
	}

	public class ReiDosPeixes : FishItemBase
	{
		protected override int Rarity => ItemRarityID.Red;
		protected override int SellValue => Item.sellPrice(gold: 25);

		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 1;
		}
	}
}
