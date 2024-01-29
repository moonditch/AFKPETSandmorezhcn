using System.Collections.Generic;
using System.Text;
using Terraria;
using Terraria.ModLoader;

namespace AFKPETSandmorezhcn.Items
{
	public class ItemTooltips : GlobalItem
	{
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			foreach (TooltipLine tooltipLine in tooltips)
			{
				StringBuilder sb = new StringBuilder(tooltipLine.Text);
				sb.Replace("-Dedicated Content-", "-专属内容-");
				sb.Replace("-Crossover Content-", "-联动内容-");
				sb.Replace("Trinket", "杂货");
				sb.Replace("Artifact", "遗物");
				
				sb.Replace("True Melee ", "真");
				sb.Replace("active summon ", "主动");
				sb.Replace("transformation summon ", "变身");
				sb.Replace("No Random Crit Chance", "无暴击率");
				sb.Replace(" combo power cost", "点连击能量消耗");

				//上海套装效果
				sb.Replace("Taking heart while having full hp spawn dolls that attack close enemies\nIf player have ability to flight they also gain that ability",
							"满血状态获得心时，生成攻击敌人的玩偶\n玩偶会复制玩家的攻击手段");

				//炼金死亡使者
				sb.Replace("'Gregg approves'\n'Critical hits will give player random buff for 20 second and increase number of alchemical flasks by 1'\n'RC will throw rainbow alchemical flask that will form different elemental clouds'\n'Player can maximum store 5 rainobw alchemical flask'\n'Each cloud will give 5 second of its respective debuff and decrease targets immunity frames'\n'Also if player have more than 50% life it will increase its damage by 5% and otherwise it will increase players life regen by 2'\n'Harvesting have a chance to give player random buff for 20 second'\n'Efficiency stat will increase the collection rate of the plants + hay when this tool will be used'",
							"'Gregg赞成'\n暴击将使玩家获得20秒的随机增益，并使炼金瓶数量增加1\n右键将扔出彩虹炼金瓶，形成不同的元素云\n玩家最多可以储存5个彩虹炼金瓶\n每种元素云都将施加5秒的减益，并减少目标的无敌帧\n如果玩家的生命值超过50%，将增加5%伤害，否则增加2点生命再生\n收获时，玩家有几率获得一个20秒的随机增益\n使用此工具时，效率属性将提高植物和干草的收集速度");
				
				/*绊之怒火
				sb.Replace("LC allow player to throw baseball for strike and RC does slam and upon slamming enough enemy player enter into berserk state\nRC uses baseballs as ammo and while no ball is thrown RC will throw ball and when there is a ball RC will do strike to mouse direction\n[c/ffff00:Slam Ability]: Hitting any enemy will inflict electrified + has a small chance to inflict Kizuna's attraction\nAny enemy that have this debuff cause them to have gravitational power towards each other\nIf any enemy collide with each other this power crush their inner organs which cause increase in true DoT for each enemy being in the area\n[c/ffff00:Strike Ability]: Overcharges every ball type which could be observed from its outer energy area\nWhen any ball is being charged they will attract weaker hostile projectile to itself + when ball hit any enemy it will release lightnings and decharge\n[c/ffff00:BERSERK]: Weapon do 150% increased modifiers.FinalDamage.Flat + 50% increased melee speed and +10 increased crit\nWhile in bersek ability player slams have a greatly increased chance of inflicting Kizuna's attraction + no strike but kill heals + refill berserk\n                                                   -Page 1-",
							"")
				sb.Replace("Harvesting plants have a small chance to concentrate metals in their molecules which cause player to be able to collect ores from them\nKilling enemies have a small chance to harvest their souls\nEfficiency stat will increase the collection rate of the plants + hay when this tool will be used\nWhile equipped as trinket it will allow player to form electric dash with 1.5 second cooldown\nWhile doing electric dash player bypass projectile modifiers.FinalDamage.Flat + slamming enemy both generate lightning bolts + inflict electrified\n" + mompart + "RC to item to generate pure enegy to use it as trinket\nWhen player press down along with trinket hotkey player will drop all trinkets and else cycle new one with olders\nWhen player is holding trinket by pressing trinket key it can unequip the trinket\n                                                   -Page 2-",
							"")*/

				sb.Replace("A divine relic which made from great harpy bars", "这是由鹰身女妖制成的圣物");				
				sb.Replace("It has been cursed by a powerful Hell Beast'", "它被地狱的血肉之墙诅咒了");
				sb.Replace("It has been cursed by the Eldritch of Darkness'", "它被月亮领主的黑暗神秘力量诅咒了");
				sb.Replace("It has been cursed by a powerful jungle creature'", "它被强大的丛林之花诅咒了");
				sb.Replace("Become usable after you prove yourself via taking head of the false lunatic cultist'", "当你击败拜月邪教后，可以使用此物品");

				sb.Replace("Hold Shift while hovering on item to see lil wiki obtain entry", "光标放在物品上并按住Shift键，查看 Wiki 上的获取方式");
				sb.Replace("Hold Shift while hovering on item to see lil wiki secret + obtain entry", "光标放在物品上并按住Shift键，查看 Wiki 上的获取方式");
				sb.Replace("Hold Shift while hovering on item to learn more about potted pals", "光标放在物品上并按住Shift键，查看 Wiki 上的详细说明");
				sb.Replace("Hold Shift while hovering on item to see lil wiki blessing ability entry", "光标放在物品上并按住Shift键，查看 Wiki 上的详细说明");
				sb.Replace("Hold Shift while hovering on item to see lil wiki different poop types entry", "光标放在物品上并按住Shift键，查看 Wiki 上的详细说明");
				sb.Replace("Hold Shift while hovering on item to see lil wiki all tiny crew ability entry", "光标放在物品上并按住Shift键，查看 Wiki 上的详细说明");
				sb.Replace("Hold Shift while hovering on item to see lil wiki different poop types entry", "光标放在物品上并按住Shift键，查看 Wiki 上的详细说明");
				sb.Replace("Hold Shift while hovering on item to see lil wiki all buddies biome + biome specific special ability entry", "光标放在物品上并按住Shift键，查看 Wiki 上的详细说明");	
				tooltipLine.Text = sb.ToString();
			}

			//测试性能改进
            /*foreach (TooltipLine tooltipLine in tooltips)
			{
				tooltipLine.Text = tooltipLine.Text.Replace("-Dedicated Content-", "-专属内容-");
				tooltipLine.Text = tooltipLine.Text.Replace("-Crossover Content-", "-联动内容-");
				tooltipLine.Text = tooltipLine.Text.Replace("Trinket", "杂货");
				tooltipLine.Text = tooltipLine.Text.Replace("Artifact", "遗物");
				tooltipLine.Text = tooltipLine.Text.Replace("No Random Crit Chance", "无暴击率");
				tooltipLine.Text = tooltipLine.Text.Replace(" combo power cost", "点连击能量消耗");
				tooltipLine.Text = tooltipLine.Text.Replace("A divine relic which made from great harpy bars", "这是由鹰身女妖制成的圣物");
				tooltipLine.Text = tooltipLine.Text.Replace("Hold Shift while hovering on item to see lil wiki obtain entry", "鼠标指针放在物品上并按住Shift键，能看到lil wiki上面的获取方式");
				tooltipLine.Text = tooltipLine.Text.Replace("True Melee ", "真");
				tooltipLine.Text = tooltipLine.Text.Replace("active summon ", "主动");
				tooltipLine.Text = tooltipLine.Text.Replace("transformation summon ", "变身");
			}*/
		}
	}
}