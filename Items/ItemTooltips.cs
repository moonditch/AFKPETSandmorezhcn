using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions; 
using Terraria;
using Terraria.ModLoader;
using AFKPETS.Items.Weapons.Melee.Bats;
using AFKPETS.Items.Tools.Tarots;

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
				sb.Replace("Trinket", "密藏");
				sb.Replace("Artifact", "祭品");

				sb.Replace("True Melee ", "真");
				sb.Replace("active summon ", "主动");
				sb.Replace("transformation summon ", "变身");
				sb.Replace("No Random Crit Chance", "无暴击率");
				sb.Replace(" combo power cost", "点连击能量消耗");

				//上海套装效果
				sb.Replace("Taking heart while having full hp spawn dolls that attack close enemies\nIf player have ability to flight they also gain that ability",
							"满血状态获得心时，生成攻击敌人的玩偶\n玩偶会复制玩家的攻击手段");
				
				//血月
				sb.Replace("There are few notes being take in red but sadly they are not readable\nMaybe they become readable in scarlet nights",
							"有一些字迹是用红色写的，但遗憾的是无法辨认\n也许在猩红的夜晚它们会变得可以阅读");
				sb.Replace("Research Log XXX:\nIn order to break the curse of elder lord many cellular lifeforms have been experimented and one is found useful\nAs each cell contains weighted DNA targetting enzymes these lifeforms could forcefuly stop the crimson via bio targetting\nBut such powers come at cost and that is upon expermienting these cellular lifeforms gain complex behaviour and tissue formation as result of mutations\nResearch Log XXV:\nIt was a mistake, these micro terrors gain ability to spread via both liquid and in air while they start to mutate every complex animal into some sort of shrimps\nWhile they have consciousness they prefer not to damage nerve system and watch their prey as a mastermind, I'm afraid soo they built their own empire\nCurrently more research on their habitat is being made in order to find their inhibitors for genetically producing bio weapons against them",
							"研究日志 XXX：\n为了打破长老的诅咒，许多细胞生命体已被实验，并发现其中一个是有用的\n由于每个细胞都含有靶向酶的加权DNA，这些生命体可以通过生物靶向来强制停止猩红的蔓延\n但这种力量是有代价的，那就是在实验过程中，这些细胞生命体因突变而获得了复杂的行为和组织形成\n研究日志 XXV：\n这是一个错误，这些微小的恐怖生物获得了通过液体和空气传播的能力，同时它们开始将每个复杂的动物突变成某种虾类\n虽然它们有意识，但它们更喜欢不损害神经系统，并像高等生命一样观察它们的猎物，我担心它们已经建立了自己的统治模式\n目前正在进行更多关于它们栖息地的研究，以找到抑制它们的方法，从而生产针对它们的遗传生物武器");
				sb.Replace("Research Log XXL:\nFinally we found the national predators of the micro lifeforms being known as shrimples\nThese basic cells manage to control their own DNA replication and upon observe any error destroy themselves with cataclysmic enzymes\nThey could be finally be the light against the terror shrimple lifeforms spread but still its too early to talk before experiments\nResearch Log XXC:\nWe manage to stop the infection but what in return? These micro lifeforms show no mercy and upon they feel being in threatened they will damage nerve system\nThe more they spread the more anomally in animals behaviour is detected. More research on if these lifeforms is required\n",
							"研究日志 XXL：\n我们终于找到了被称为“虾虫”的微小生命体的天敌\n这些基本细胞能够控制自己的DNA复制，并在发现任何错误时使用灾难性的酶来自我毁灭\n它们可能是对抗恐怖虾虫生命体扩散的希望，但在进行实验之前，谈论这些还为时过早\n研究日志 XXC：\n我们成功阻止了感染，但代价是什么？这些微小生命体毫不留情，一旦它们感到受到威胁，就会破坏神经系统\n随着它们的扩散，越来越多地检测到动物行为的异常。需要进一步研究这些生命体");

				//炼金死亡使者
				sb.Replace("'Gregg approves'\n'Critical hits will give player random buff for 20 second and increase number of alchemical flasks by 1'\n'RC will throw rainbow alchemical flask that will form different elemental clouds'\n'Player can maximum store 5 rainobw alchemical flask'\n'Each cloud will give 5 second of its respective debuff and decrease targets immunity frames'\n'Also if player have more than 50% life it will increase its damage by 5% and otherwise it will increase players life regen by 2'\n'Harvesting have a chance to give player random buff for 20 second'\n'Efficiency stat will increase the collection rate of the plants + hay when this tool will be used'",
							"'Gregg赞成'\n暴击将使玩家获得20秒的随机增益，并使炼金瓶数量增加1\n右键将扔出彩虹炼金瓶，形成不同的元素云\n玩家最多可以储存5个彩虹炼金瓶\n每种元素云都将施加5秒的减益，并减少目标的无敌帧\n如果玩家的生命值超过50%，将增加5%伤害，否则增加2点生命再生\n收获时，玩家有几率获得一个20秒的随机增益\n使用此工具时，效率属性将提高植物和干草的收集速度");

				//绊之怒火
				sb.Replace("LC allow player to throw baseball for strike and RC does slam and upon slamming enough enemy player enter into berserk state\nRC uses baseballs as ammo and while no ball is thrown RC will throw ball and when there is a ball RC will do strike to mouse direction\n[c/ffff00:Slam Ability]: Hitting any enemy will inflict electrified + has a small chance to inflict Kizuna's attraction\nAny enemy that have this debuff cause them to have gravitational power towards each other\nIf any enemy collide with each other this power crush their inner organs which cause increase in true DoT for each enemy being in the area\n[c/ffff00:Strike Ability]: Overcharges every ball type which could be observed from its outer energy area\nWhen any ball is being charged they will attract weaker hostile projectile to itself + when ball hit any enemy it will release lightnings and decharge\n[c/ffff00:BERSERK]: Weapon do 150% increased modifiers.FinalDamage.Flat + 50% increased melee speed and +10 increased crit\nWhile in bersek ability player slams have a greatly increased chance of inflicting Kizuna's attraction + no strike but kill heals + refill berserk\n                                                   -Page 1-",
							"右键投出棒球，左键重击；当重击足够多敌人后，玩家进入狂暴状态\n左键消耗棒球作为弹药，空中无棒球时扔出棒球，而有棒球时则向光标方向进行打击\n[c/ffff00:重击能力]: 攻击任何敌人将造成带电效果，并有很小的几率施加羁绊引力\n带有此减益的敌人之间会相互吸引\n如果它们相互碰撞，这种力量将粉碎它们的内脏器官，并增加附近敌人受到的持续伤害\n[c/ffff00:打击能力]: 对所有类型的棒球弹药进行过载充能，改变其外观\n过载充能的棒球弹药会吸引较弱的敌对射弹，并在击中任何敌人时释放链状闪电\n[c/ffff00:狂暴状态]: 武器造成额外 150% 伤害，增加 50% 近战攻速度和 10% 暴击率\n狂暴状态下，玩家的猛击有很高的几率施加羁绊引力，非直接攻击但击杀敌人会治疗玩家并延长狂暴状态\n                                                   - 第一页 -");
				sb.Replace("Harvesting plants have a small chance to concentrate metals in their molecules which cause player to be able to collect ores from them\nKilling enemies have a small chance to harvest their souls\nEfficiency stat will increase the collection rate of the plants + hay when this tool will be used\nWhile equipped as trinket it will allow player to form electric dash with 1.5 second cooldown\nWhile doing electric dash player bypass projectile modifiers.FinalDamage.Flat + slamming enemy both generate lightning bolts + inflict electrified\n[c/FFC0CB:???]\nRC to item to generate pure enegy to use it as trinket\nWhen player press down along with trinket hotkey player will drop all trinkets and else cycle new one with olders\nWhen player is holding trinket by pressing trinket key it can unequip the trinket\n                                                   -Page 2-",
							"收割植物时有很小的几率富集金属，额外产生矿石\n杀死敌人时，有很小的几率收获他们的灵魂\n效率属性将提升此工具用于收割植物和干草时的采集速度\n右键生成羁绊火花\n装备在密藏栏时，玩家可以使用闪电冲刺，1.5 秒冷却时间\n无视射弹，撞击敌人时释放闪电并造成带电效果\n[c/FFC0CB:???]\n当玩家按下密藏快捷键时，将卸下所有密藏\n当玩家手持密藏按下密藏快捷键时，可以卸下密藏\n                          - 第二页 -");
				sb.Replace("Harvesting plants have a small chance to concentrate metals in their molecules which cause player to be able to collect ores from them\nKilling enemies have a small chance to harvest their souls\nEfficiency stat will increase the collection rate of the plants + hay when this tool will be used\nWhile equipped as trinket it will allow player to form electric dash with 1.5 second cooldown\nWhile doing electric dash player bypass projectile modifiers.FinalDamage.Flat + slamming enemy both generate lightning bolts + inflict electrified\n[c/FFC0CB:Mom's Box Effect]:Non boss enemy slam gain dynamic knockback + inflict Kizuna's Attraction\nRC to item to generate pure enegy to use it as trinket\nWhen player press down along with trinket hotkey player will drop all trinkets and else cycle new one with olders\nWhen player is holding trinket by pressing trinket key it can unequip the trinket\n                                                   -Page 2-",
							"收割植物时有很小的几率富集金属，额外产生矿石\n杀死敌人时，有很小的几率收获他们的灵魂\n效率属性将提升此工具用于收割植物和干草时的采集速度\n右键生成羁绊火花\n装备在密藏栏时，玩家可以使用闪电冲刺，1.5 秒冷却时间\n无视射弹，撞击敌人时释放闪电并造成带电效果\n[c/FFC0CB:收纳盒特殊能力]: 重击非Boss敌人造成强力击退，施加羁绊引力\n当玩家按下密藏快捷键时，将卸下所有密藏\n当玩家手持密藏按下密藏快捷键时，可以卸下密藏\n                             - 第二页 -");
				
				//妈妈的收纳盒产生的密藏特殊能力
				sb.Replace("[c/FFC0CB:Mom's Box Effect]:",
							"[c/FFC0CB:收纳盒特殊能力]: ");

				//特殊修饰语 - 等模组修Bug
				//sb.Replace("", "");

				//婚戒
				sb.Replace("A beautiful ring designed for owner of your heart\nYour heart is beating one with the designer\nWhen you take damage you have 5% chance to take half from it and 5% take 75% of it\nHer love will increase your maximum health and life regen\nBeing close to your love will increase your endurance by 4% and protect her from taking damage",
							"一枚为你心爱之人设计的美丽戒指\n你的心跳与设计者共同跳动\n受到伤害时，有 5% 的几率只受到一半的伤害，5% 的几率受到75%的伤害\n她的爱会增加你的最大生命值和生命再生速度\n当你靠近心爱的人时，增加4%伤害减免，并保护她免受伤害");
				sb.Replace("A beautiful ring designed for owner of your heart\nYour heart is beating one with the yandere\nHitting enemies with true melee give you heart of a killer buff which will increase your damage\nWhen you have less than 20% life your yandere instinct will activate and your movement speed increase by 10%\nIn yandere state your damage increase by 3% and critical hit chance by 5% but you will lose half of your defense and life regen\nBeing close to your love will increase your endurance by 4% and protect her from taking damage",
							"一枚为你心爱之人设计的美丽戒指\n你的心跳与病娇公主共同跳动\n用真近战武器击中敌人时，获得杀手之心增益，增加伤害\n当生命值低于20%时，触发病娇本能，增加 10% 移动速度\n在此状态下，增加 3% 伤害和 5% 暴击率，但失去一半的防御和生命再生\n当你靠近心爱的人时，增加4%伤害减免，并保护她免受伤害");
				sb.Replace("A beautiful ring designed for owner of your heart\nIt will have no effect until your heart have enough love",
							"一枚为你心爱之人设计的美丽戒指\n除非你的心有足够的爱，否则它不会起作用");

				//塔罗牌
				sb.Replace("Millenium: Double Tab down while being on a solid block to call tiny imp to help. Max 1 can be active", "隐藏: 站在物块上双击<下>键召唤小恶魔，最多只能同时存在1个");
				sb.Replace("Millenium: All of potion based buffs get disabled", "隐藏: 禁用所有药水增益");
                sb.Replace("Millenium: Taking money gives buff with respect to money type", "隐藏: 根据获得的钱币种类获得增益");
                sb.Replace("Millenium: Taking heart will cause a blood pulse which damage close enemies", "隐藏: 捡起红心会释放符阵伤害靠近的敌人");
                sb.Replace("Millenium: Moonlight sparkles form around you randomly", "隐藏: 月光在你周围随机闪烁");
                sb.Replace("Millenium: You leave stars with short life time in your behind while moving", "隐藏: 你在移动时留下短暂存在的星星");
                sb.Replace("Millenium: Summon a hell raven which aim closest enemy and explode", "隐藏: 召唤一只地狱乌鸦，攻击最近的敌人并爆炸");
                sb.Replace("Millenium: Stone walls which damage enemies rise from ground randomly", "隐藏: 随机从地面升起伤害敌人的石墙");
                sb.Replace("Millenium: +100 extra max mana", "M隐藏: 最大魔力值 +100");
                sb.Replace("Millenium: You stop time for 1 second", "隐藏: 暂停 1 秒时间");

                sb.Replace("A divine relic which made from great harpy bars", "这是由鹰身女妖制成的圣物");
				sb.Replace("It has been cursed by a powerful Hell Beast'", "它被地狱的血肉之墙诅咒了");
				sb.Replace("It has been cursed by the Eldritch of Darkness'", "它被月亮领主的黑暗神秘力量诅咒了");
				sb.Replace("It has been cursed by a powerful jungle creature'", "它被强大的丛林之花诅咒了");
				sb.Replace("Become usable after you prove yourself via taking head of the false lunatic cultist'", "当你击败拜月邪教后，可以使用此物品");

				//wiki说明
				tooltipLine.Text = Regex.Replace(sb.ToString(), @"^Hold Shift while hovering on item to.*", "光标放在物品上并按住Shift键，查看 Wiki 上的详细说明");
				//sb.Replace("", "");
			}
		}

		/*public override void HoldItem(Item item, Player player)
		{
			if (item.type == ModContent.ItemType<BlankCard>())
			{
				string text = "                                     [c/FF00FF:-塔罗牌获取-]\n0.愚者: 击杀死灵傀儡法师会转化此塔罗牌\nI.魔术师: 击杀提姆或符文巫师会转化此塔罗牌\nVI.恋人: 生命值低于一半时找护士治疗会转化此塔罗牌\nIX.隐者: 找哥布林工匠重铸物品会转化此塔罗牌\nXV.恶魔: 击杀血肉之墙会转化此塔罗牌\nXVI.塔: 用物块建造有低概率转化此塔罗牌\nXVII.星星: 击杀全息史莱姆会转化此塔罗牌\nXVIII.月亮: 在夜晚的天空有低概率转化此塔罗牌\nXIX.太阳: 击杀英勇史莱姆会转化此塔罗牌\nXXI.世界: 没有激活的Boss时有低概率转化此塔罗牌\n";

                //"                                     [c/FF00FF:-Obtaining Cards-]\n0.Fool:Killing Antony, the Novice Necromancer will transform the card\nI.Magician:Killing Tim or rune wizard will transform the card\nVI.Lovers: Healing from nurse while having less than 50% life will transform it\nIX.Hermit:Doing a reforge from goblin tinkerer will transform it\nXVI.Devil:Killing Wall of Flesh will transform it\nXVI.Tower:Building stuff with tiles have a small chance to transform it\nXVII.Stars:Killing holographic slime will transform it\nXVIII.Moon:Visiting sky at night have a small chance to transform it\nXIX.Sun:Killing heroic slime will transform it\nXXI.World: Making a trip while no boss is active have small chance to transform it\n")
			}

		}*/
	}
}