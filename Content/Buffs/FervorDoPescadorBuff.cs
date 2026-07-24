using Terraria;
using Terraria.ModLoader;

namespace FishMania.Content.Buffs
{
	// Buff da Pocao do Pescador Supremo: +30 de poder de pesca.
	public class FervorDoPescadorBuff : ModBuff
	{
		public override void Update(Player player, ref int buffIndex) {
			player.fishingSkill += 30;
		}
	}
}
