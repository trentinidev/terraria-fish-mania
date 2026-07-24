using FishMania.Content.Fish;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Pets.PeixinhoDourado
{
	// Aquario com um peixinho dourado de estimacao.
	public class PeixinhoDouradoItem : ModItem
	{
		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 1;
		}

		public override void SetDefaults() {
			Item.CloneDefaults(ItemID.ZephyrFish);
			Item.shoot = ModContent.ProjectileType<PeixinhoDouradoProjectile>();
			Item.buffType = ModContent.BuffType<PeixinhoDouradoBuff>();
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
				.AddIngredient<DouradoDoRio>()
				.Register();
		}
	}
}
