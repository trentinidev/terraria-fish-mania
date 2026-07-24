using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Fish
{
	// Common base for every fish in the mod: stackable, sellable, no direct use.
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
