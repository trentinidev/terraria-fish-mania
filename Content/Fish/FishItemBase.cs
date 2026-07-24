using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Fish
{
	// Base comum de todos os peixes do mod: empilhavel, vendavel, sem uso direto.
	public abstract class FishItemBase : ModItem
	{
		protected virtual int Rarity => ItemRarityID.White;
		protected virtual int SellValue => Item.sellPrice(silver: 10);

		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 3;
		}

		public override void SetDefaults() {
			Item.width = 30;
			Item.height = 28;
			Item.maxStack = Item.CommonMaxStack;
			Item.rare = Rarity;
			Item.value = SellValue;
		}
	}
}
