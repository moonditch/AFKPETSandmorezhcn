using Terraria.ModLoader;
using AFKPETS.Buffs.PlayerDebuff;
using AFKPETS.Buffs.EffectBuff;
using AFKPETS.Buffs.Summoner;

namespace AFKPETSandmorezhcn.GlobalTranslation
{
	public class BuffText : GlobalBuff
	{
		public override void ModifyBuffText(int type, ref string buffName, ref string tip, ref int rare)
		{
			if (type == ModContent.BuffType<Hangover>())
			{
				if (tip == "Drinking more may cause cognitive effects\nCurrently following effects are active:\n-Decreased life regen")
					tip = "饮酒过多可能导致认知障碍\n当前受到以下影响:\n-减少生命再生";
				if (tip == "Drinking more may cause cognitive effects\nCurrently following effects are active:\n-Decreased life regen\n-Decreased hand-eye coordination")
					tip = "饮酒过多可能导致认知障碍\n当前受到以下影响:\n-减少生命再生\n-降低手眼协调能力";
				if (tip == "Drinking more may cause cognitive effects\nCurrently following effects are active:\n-Decreased life regen\n-Decreased hand-eye coordination\n-Lack of coordination")
					tip = "饮酒过多可能导致认知障碍\n当前受到以下影响:\n-减少生命再生\n-降低手眼协调能力\n-失去平衡";
			}
			if (type == ModContent.BuffType<SufiBuff>())
			{
				if (tip == "Increases defense by 6%, endurance by 4% and attacker get 3x contact damage back")
					tip = "增加 6% 防御、4% 伤害减免、攻击者受到三倍返回伤害";
				if (tip == "Increases movement + wing + jump stats + player get blessed double jump and no fall damage")
					tip = "免疫摔落伤害、增加移动飞行跳跃速度、获得祝福二段跳能力";
				if (tip == "life + mana regen increase along with player attract life hearts and mana stars")
					tip = "生命和魔力再生随玩家拾取的红心和魔力星数量而增加";
				if (tip == "Damage + crit increase")
					tip = "增加伤害和暴击率";
				if (tip == "Player get small amount of offensive + defensive + movement")
					tip = "小幅提升威胁度、防御和移动速度";
			}
		}
	}
}	