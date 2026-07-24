using Terraria;
using Terraria.ModLoader;

namespace FishMania.Content.Buffs
{
	// Supreme Angler Potion buff: +30 fishing power.
	[LegacyName("FervorDoPescadorBuff")]
	public class AnglersFervorBuff : ModBuff
	{
		public override void Update(Player player, ref int buffIndex) {
			player.fishingSkill += 30;
		}
	}
}
