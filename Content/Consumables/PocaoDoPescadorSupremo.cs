using FishMania.Content.Buffs;
using FishMania.Content.Fish;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Consumables
{
	// Pocao que concede +30 de poder de pesca por 8 minutos.
	public class PocaoDoPescadorSupremo : ModItem
	{
		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 20;
		}

		public override void SetDefaults() {
			Item.width = 16;
			Item.height = 26;
			Item.useStyle = ItemUseStyleID.DrinkLiquid;
			Item.useAnimation = 17;
			Item.useTime = 17;
			Item.useTurn = true;
			Item.UseSound = SoundID.Item3;
			Item.maxStack = Item.CommonMaxStack;
			Item.consumable = true;
			Item.rare = ItemRarityID.Orange;
			Item.value = Item.sellPrice(silver: 40);
			Item.buffType = ModContent.BuffType<FervorDoPescadorBuff>();
			Item.buffTime = 8 * 60 * 60; // 8 minutos
		}

		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient(ItemID.BottledWater)
				.AddIngredient<DouradoDoRio>()
				.AddIngredient(ItemID.Waterleaf)
				.AddTile(TileID.Bottles)
				.Register();
		}
	}
}
