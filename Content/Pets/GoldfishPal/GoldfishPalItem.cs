using FishMania.Content.Fish;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FishMania.Content.Pets.GoldfishPal
{
	// A bowl with a pet goldfish.
	[LegacyName("PeixinhoDouradoItem")]
	public class GoldfishPalItem : ModItem
	{
		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 1;
		}

		public override void SetDefaults() {
			Item.CloneDefaults(ItemID.ZephyrFish);
			Item.shoot = ModContent.ProjectileType<GoldfishPalProjectile>();
			Item.buffType = ModContent.BuffType<GoldfishPalBuff>();
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
				.AddIngredient<RiverDorado>()
				.Register();
		}
	}
}
