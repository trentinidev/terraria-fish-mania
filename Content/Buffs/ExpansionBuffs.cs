using Terraria;
using Terraria.ModLoader;

namespace FishMania.Content.Buffs
{
	// Lucky Angler Potion: +20 fishing power and sonar.
	public class LuckyAnglerBuff : ModBuff
	{
		public override void Update(Player player, ref int buffIndex) {
			player.fishingSkill += 20;
			player.sonarPotion = true;
		}
	}

	// Depths Elixir: temporary lava fishing and +10 fishing power.
	public class DepthsElixirBuff : ModBuff
	{
		public override void Update(Player player, ref int buffIndex) {
			player.accLavaFishing = true;
			player.fishingSkill += 10;
		}
	}
}
