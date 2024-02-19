using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions; 
using Terraria;
using Terraria.ModLoader;
using AFKPETS.Items.Weapons.Melee.Bats;
using AFKPETS.Items.Tools.Tarots;

namespace AFKPETSandmorezhcn.GlobalTranslation
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
				sb.Replace("Current Reward:", "当前奖励: ");

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
				
				//盒中伙伴
				sb.Replace("Current Buddy: ", "当前伙伴: ");
				sb.Replace("[c/ffff00:Tiny Janissary]\nHe will shoot your enemies down with respect to the bullet player holds\nWhile player is below 50% life he gets angry and start to deal contact damage + its attacks get faster\n[c/ffff00:Biome specific Ability]: He will order the army to rain down arrows and cannon shoots",
							"[c/ffff00:禁卫军]\n根据玩家持有的子弹射击敌人\n当玩家生命值低于50%时进入愤怒状态，造成接触伤害并提高攻击速度\n[c/ffff00:群落特殊能力]: 命令军队降下箭雨和炮火掩护");
				sb.Replace("[c/ffff00:Tiny Conductor]\nGenerates static cogs + decrease cooldown of close afkpets aim sentries\n[c/ffff00:Biome specific Ability]: Starts to place Tesla turrets that electrify close enemies",
							"[c/ffff00:指挥官]\n生成静电齿轮，减少附近模组哨兵的冷却时间\n[c/ffff00:群落特殊能力]: 放置特斯拉炮塔，对附近敌人造成电击伤害");
				sb.Replace("[c/ffff00:Tiny Herbalist]\nShe will throw seed that inflict poison area upon hitting enemy + grow tangle kelp on hitting ground\n[c/ffff00:Biome specific Ability]: She will now have a chance to throw pea shooter seeds that attack close enemies + seeds will not die from enemy hit\nGrown pea shooters attack to mouse direction",
							"[c/ffff00:草药师]\n扔出施加中毒的种子，击中地面时生长出缠绕海带\n[c/ffff00:群落特殊能力]: 有几率扔出能攻击近距离敌人的豌豆射手种子，种子不会因击中敌人而消失\n豌豆射手向光标方向攻击");
				sb.Replace("[c/ffff00:Tiny Clothier]\nHe will cast cursed skulls upon your foes + curses close enemies\n[c/ffff00:Biome specific Ability]: Awakens a guardian above players head that drain close enemies life as it uses it to heal player",
							"[c/ffff00:服装师]\n向敌人扔出被诅咒的头骨，诅咒附近的敌人\n[c/ffff00:群落特殊能力]: 在玩家头顶唤醒一个守护者，吸收附近敌人的生命来治疗玩家");
				sb.Replace("[c/ffff00:Tiny Star Chef]\nShe will throw scorched cookies at your enemies + enemy killing blow form rainbow cookie\n[c/ffff00:Biome specific Ability]: Each time player takes heart while having full heart she store a small amount of it and heal player when it take damage\nEach minion could store up to 10 life + give low duration rapid healing buff",
							"[c/ffff00:星级厨师]\n向你的敌人投掷烧焦的曲奇饼干，击杀敌人会生成彩虹曲奇饼干\n[c/ffff00:群落特殊能力]: 她会储存一部分玩家在满血状态下拾取的生命心，并在受到伤害时治疗玩家\n每个仆从最多可以储存10点生命值，并赋予短暂的快速治疗增益");
				sb.Replace("[c/ffff00:Tiny Ice Fairy]\nShe will strike close enemies by icicles\n[c/ffff00:Biome specific Ability]: Icicles and frost flames start to rain below her",
							"[c/ffff00:寒冰精灵]\n用冰柱攻击附近的敌人\n[c/ffff00:群落特殊能力]: 在她下方降下冰柱和冰霜火焰");
				sb.Replace("[c/ffff00:Tiny Raid Knight]\nHe marks closest enemy to form a forbidden ritual around that enemy\n[c/ffff00:Biome specific Ability]: Generates a calamitous area around himself which cause minion projectiles in this area may get marked\nThis projectiles have a chance to inflict soulblight + weaken them but make damage dealt become true damage",
							"[c/ffff00:突袭骑士]\n标记最近的敌人，在该敌人周围形成禁忌仪式\n[c/ffff00:群落特殊能力]: 在他周围生成一个灾难区域，经国该区域的召唤物可能被标记\n标记后被削弱，但所有攻击造成真实伤害，同时有几率施加灵魂枯萎");
				sb.Replace("[c/ffff00:Tiny Ninja]\nHe will strike close enemies with shurikens + RC will teleport them around your mouse location\n[c/ffff00:Biome specific Ability]: He will form shadow clones around the enemy that do katana strike",
							"[c/ffff00:忍者]\n用手里剑攻击附近的敌人，右键会将他们传送到光标位置\n[c/ffff00:群落特殊能力]: 在敌人周围生成用武士刀攻击的影分身");
				sb.Replace("[c/ffff00:Tiny Goblin Archer]\nHe will shoot your foes down with arrows which gets changed with respect to enviromental conditions\n[c/ffff00:Biome specific Ability]: Upon hitting enemy the arrows will split into 2 weaker that moves backwards",
							"[c/ffff00:哥布林弓手]\n射出根据环境群落改变的箭攻击你的敌人\n[c/ffff00:群落特殊能力]: 击中敌人后分裂出两个较弱的向后移动的箭");

				//塔罗牌
				sb.Replace("Millenium: Double Tab down while being on a solid block to call tiny imp to help. Max 1 can be active", "隐藏: 站在物块上双击<下>键召唤小恶魔，最多只能同时存在1个");
				sb.Replace("Millenium: All of potion based buffs get disabled", "隐藏: 禁用所有药水增益");
				sb.Replace("Millenium: Taking money gives buff with respect to money type", "隐藏: 根据获得的钱币种类获得增益");
				sb.Replace("Millenium: Taking heart will cause a blood pulse which damage close enemies", "隐藏: 捡起红心会释放符阵伤害靠近的敌人");
				sb.Replace("Millenium: Moonlight sparkles form around you randomly", "隐藏: 月光在你周围随机闪烁");
				sb.Replace("Millenium: You leave stars with short life time in your behind while moving", "隐藏: 你在移动时留下短暂存在的星星");
				sb.Replace("Millenium: Summon a hell raven which aim closest enemy and explode", "隐藏: 召唤一只地狱乌鸦，攻击最近的敌人并爆炸");
				sb.Replace("Millenium: Stone walls which damage enemies rise from ground randomly", "隐藏: 随机从地面升起伤害敌人的石墙");
				sb.Replace("Millenium: +100 extra max mana", "隐藏: 最大魔力值 +100");
				sb.Replace("Millenium: You stop time for 1 second", "隐藏: 暂停 1 秒时间");

				sb.Replace("A divine relic which made from great harpy bars", "这是由鹰身女妖制成的圣物");
				sb.Replace("It has been cursed by a powerful Hell Beast'", "它被地狱的血肉之墙诅咒了");
				sb.Replace("It has been cursed by the Eldritch of Darkness'", "它被月亮领主的黑暗神秘力量诅咒了");
				sb.Replace("It has been cursed by a powerful jungle creature'", "它被强大的丛林之花诅咒了");
				sb.Replace("Become usable after you prove yourself via taking head of the false lunatic cultist'", "当你击败拜月邪教后，可以使用此物品");

				//点金石
				sb.Replace("It could be placed on philospher's table by RC on its tile while holding this item", "手持点金石右键放在转化工作台上");

				//wiki说明 sb.Replace("", "");
				sb.Replace("It drops from [c/FF0000:Cookie Crate]\n[c/FF0000:Cookie Crate] could be fished from ocean and its a strong enemy",
							"[c/FF0000:饼干板条箱]掉落\n海洋环境有几率钓到 [c/FF0000:饼干板条箱]，它是一个强大的敌人");
				sb.Replace("Could be obtained from [c/FF0000:Cookie Box]\nIt become fishable in ocean after player equip [c/FF0000:Cookie Badge] which drop from [c/FF0000:Cookie Crate]\n[c/FF0000:Cookie Crate] could be fished from ocean and its a strong enemy\nIf player activate no fish mechanic option from mod config it bypass this",
							"可以从 [c/FF0000:饼干盒] 获得\n装备 [c/FF0000:饼干板条箱] 掉落的 [c/FF0000:饼干徽章] 后，可以通过钓鱼获得\n海洋环境有几率钓到 [c/FF0000:饼干板条箱]，它是一个强大的敌人\n如果在设置中启用了禁用额外的钓鱼机制选项，将绕过此限制");
				sb.Replace("It drops from [c/FF0000:Spirit of Gluttory]\nFirst defeat [c/FF0000:Cookie Crate]\nThen burn [c/FF0000:Cookie Badge] item with [c/FF0000:Lamb Sauce][c/FF0000:Cookie Crate] could be awoken from fishing her in ocean",
							"[c/FF0000:贪食之魂]掉落\n首先击败 [c/FF0000:饼干板条箱]\n然后在友好的饼干魂面前用 [c/FF0000:羊酱汁] 燃烧 [c/FF0000:饼干徽章] 以激怒它\n海洋环境有几率钓到 [c/FF0000:饼干板条箱]，它是一个强大的敌人");
				sb.Replace("Could be obtained from [c/FF0000:Cookie Crate] and [c/FF0000:Cookie Box]\n[c/FF0000:Cookie Crate] could be fished from ocean and its a strong enemy\nCheck [c/FF0000:Cookie Box] lil wiki entry for more info for it",
							"可以从 [c/FF0000:饼干板条箱] 和 [c/FF0000:饼干盒] 获得\n海洋环境有几率钓到 [c/FF0000:饼干板条箱]，它是一个强大的敌人\n查看 [c/FF0000:饼干盒] 以获取更多信息");

				sb.Replace("It requires at least 50% full fishing power to be caught\nFull fishing power = fishing power + bait power\n",
							"要求最少有50%的总渔力才能钓到\n总渔力包括药水、饰品、套装和鱼饵\n");
				sb.Replace("\nIf not disabled it have strong fish minigame to catch",
							"\n如果在设置中启用了禁用额外的钓鱼机制选项，则不需要完成蓄力条也能钓到");
				sb.Replace("It could be only caught in forest in hardmode", "只能在困难模式的森林钓到");
				sb.Replace("It could be only caught in desert in hardmode", "只能在困难模式的沙漠钓到");
				sb.Replace("It could be only caught in underworld lava in hardmode", "只能在困难模式的地狱岩浆钓到");
				sb.Replace("It could be only caught in sky or higher height", "只能在太空钓到");
				sb.Replace("It could be only caught in forest", "只能在森林钓到");
				sb.Replace("It could be only caught in desert", "只能在沙漠钓到");		

				sb.Replace("It could bought from witch doctor after plantera has been defeated", "击败 [c/FF0000:世纪之花] 后，[c/FF0000:巫医]售卖");
				sb.Replace("Has a chance to sold by [c/FF0000:Wandering Samurai]", "[c/FF0000:流浪武士]有几率售卖");
				sb.Replace("Sold by [c/FF0000:Fallen Angel] after [c/FF0000:Laval Golem]", "击败 [c/FF0000:拉瓦尔傀儡] 后，[c/FF0000:坠落天使]售卖");
				sb.Replace("Sold by [c/FF0000:Cyborg]", "[c/FF0000:机器侠]在自然生成的派对期间售卖");
				sb.Replace("Sold by [c/FF0000:Pirate Captain(Vanilla Town NPC)]\n", "[c/FF0000:海盗船长]售卖");

				sb.Replace("Drops from [c/FF0000:Mothron]", "[c/FF0000:蛾怪]掉落");
				sb.Replace("Drop from Okiku\nAfter Okiku's defeat also drop from blood zombies + dripplers", "[c/FF0000:盘子女鬼]掉落\n击败盘子女鬼后，血腥僵尸和滴滴怪也有几率掉落");
				sb.Replace("Obtain from killing [c/FF0000:Fallen Angel] in front of any effect egg\n", "在任何彩蛋面前击杀 [c/FF0000:坠落天使] 后获得");
				sb.Replace("Obtained from breaking vanilla pots", "打破原版的罐子有几率获得");
				sb.Replace("Obtained from completing [c/FF0000:Bounty Hunters] quests", "完成 [c/FF0000:赏金猎人] 任务获得");
				sb.Replace("Could be obtained from [c/FF0000:Hunters] duck hunt minigame\nHe have a chance to spawn around noon hours", "完成 [c/FF0000:猎犬] 鸭子狩猎小游戏获得\n它有几率在正午时分出现");
				sb.Replace("It drop from [c/FF0000:SATLA-001] if player know all questions correct\nQuestion answers are A-C-B-A", "玩家正确回答 [c/FF0000:SATLA-001] 的所有问题后获得\n正确答案是：A-C-B-A");
				sb.Replace("Obtained from harvesting vanilla tall grasses", "收割原版的高草丛后有几率获得");
				sb.Replace("Could be obtained from [c/FF0000:Box]\n[c/FF0000:Box] drops from [c/FF0000:Isaac]", "可以从 [c/FF0000:以撒的箱子] 获得\n[c/FF0000:以撒的箱子] 掉落自 [c/FF0000:以撒]");

				sb.Replace("Could be obtained from [c/FF0000:Arcade Machine]\nUpon player enter Konami code in game select of arcade machine it makes game enter into error state\nKonami Code is up, up, down, down, left, right, left, right\nPlayer could buy this item from error entity for 1 [c/FF0000:game mastery token]\nGame mastery token is obtained through completing a arcade machine game",
							"可以从 [c/FF0000:商场游戏机] 获得\n当玩家在商场游戏机的游戏选择界面中输入科乐美秘籍时，会进入调试状态\n科乐美秘籍是上、上、下、下、左、右、左、右\n玩家可以从调试状态下花费一个 [c/FF0000:精英游戏币] 购买此物品\n[c/FF0000:精英游戏币]通过完成街机游戏获得");				

				sb.Replace("Sold by [c/FF0000:Big Game Hunter] after player play any npc based minigame\nHunters Duck hunt, lost ghosts trivia and assistants memeory game are accepted",
							"完成任何NPC的小游戏后，[c/FF0000:Boss狩猎商人]售卖\n小游戏包括: 猎犬的鸭子狩猎、幽灵夫人的琐事、助教的记忆游戏");
				
				sb.Replace("In order to get netherite bar/ore player need to use [c/FF0000:Pouch of Phoenix Ash] on [c/FF0000:hellstone bar/ore tiles]\nThe conversion logic work similar to purification powder style\n[c/FF0000:Pouch of Phoenix Ash] drops from [c/FF0000:Laval Golem]",
							"对 [c/FF0000:狱石/狱石锭] 使用 [c/FF0000:凤凰灰烬袋] 获得下界合金/下界合金锭\n使用效果类似于净化粉\n[c/FF0000:拉瓦尔傀儡] 掉落 [c/FF0000:凤凰灰烬袋]");

				sb.Replace("It's seeds could be bought from [c/FF0000:Fallen Angel]\nFor spawning fallen angel check [c/FF0000:Icarus's Mirror]",
							"种子可从 [c/FF0000:坠落天使] 处购买\n查看[c/FF0000:伊卡洛斯的镜子]以了解如何吸引坠落天使");

				sb.Replace("Active NPC +(Optional)Item in Inventory +(Optional)Time = Item get from sacrifice\nGuide + Guide Voodoo = Death Coin\nClothier + Clothier Voodoo = Broken Washing Machine\nParty Girl + Portarit of Markov + Blood Moon = Yuri's Eye",
							"存活的NPC +（可选）背包中特定物品 +（可选）特定时间 = 献祭获得的物品\n向导 + 向导巫毒娃娃 = 死亡硬币\n服装商 + 服装商巫毒娃娃 = 破碎的洗衣机\n派对女孩 + 马尔科夫的肖像 + 血月 = 尤里之眼");
		
				sb.Replace("Each piece have seperate way to obtain\nPiece A:Crafted with dark shard and some more\nPiece B:In hardmode big game hunter sells it\nHe sells it at the first 10 second of day\nPiece C: Drops from Planterra",
							"每个部件都有不同的获取方式\n破损钥匙-阿尔法: 暗黑碎块和其它材料制作\n破损钥匙-贝塔: 困难模式，Boss狩猎商人售卖\n在每一天开始的前10秒钟售卖\n破损钥匙-伽马: 世纪之花掉落");
			
				sb.Replace("[c/FF0000:Stone]: Stronger + faster + upon hit tile become rounder and act similar to boulders with remaining penetrations\n[c/FF0000:Stinky]: Generates a low damage poison area which inflicts high duration of poisoned + rot out\n[c/FF0000:Corn]: Poop is covered by blue flies and upon poop gets destroyed they get released and attack close enemies\n[c/FF0000:Black]: Generate short living shadow smoke that empower players ranged attacks + decrease enemy aggro + give chance to dodge\n[c/FF0000:White]: While in its area player gain all stats up + upon throwing it player gain a slight holy protection\n[c/FF0000:Fiery]: Generate lingering flames while being thrown + cause a firey vortex upon hit any place\n[c/FF0000:Bomb]: Explode upon hitting any enemy + do not get destroy from hitting tile + explode into smaller poop shards",
							"[c/FF0000:碎石]: 提升伤害、速度，击中地面时变圆润并像巨石一样穿透敌人\n[c/FF0000:恶臭]: 生成低伤害的毒区，造成长时间的中毒和腐烂\n[c/FF0000:谷粒]: 便便上覆盖着蓝色苍蝇，当便便被摧毁时，它们会离开攻击附近的敌人\n[c/FF0000:黑烟]: 生成短暂的暗影烟雾，增强远程攻击、降低敌人的攻击欲望并有几率闪避\n[c/FF0000:白晕]: 在其区域内，提升所有属性，扔出时获得神圣保护\n[c/FF0000:炽热]: 扔出时生成火焰，击中后引发火焰漩涡\n[c/FF0000:炸弹]: 击中任何敌人时爆炸成更小的便便碎片，不会因碰撞物块而消失");

				sb.Replace("[c/FF0000:Hallow]: Tiny Janissary - Death from Above\n[c/FF0000:Desert]: Tiny Conductor - Attractive Engineering\n[c/FF0000:Jungle]: Tiny Herbalist - Garden Warfare\n[c/FF0000:Dungeon]: Tiny Clothier - Guardian Call\n[c/FF0000:Ocean]: Tiny Star Chef - Overhealing\n[c/FF0000:Snow]: Tiny Ice Fairy - Icicle Fall\n[c/FF0000:Underworld]: Tiny Raid Knight - Calamitous Ritual\n[c/FF0000:Evil Biome]: Tiny Goblin Archer - Hex Arrows\n[c/FF0000:Forest + Default]: Tiny Ninja - Shadow Clone Strike",
							"[c/FF0000:神圣]: 禁卫军 - 天降横祸\n[c/FF0000:沙漠]: 指挥官 - 魅力工程\n[c/FF0000:丛林]: 草药师 - 花园战争e\n[c/FF0000:地牢]: 服装师 - 守卫召唤\n[c/FF0000:海洋]: 星级厨师 - 过量治疗\n[c/FF0000:雪原]: 寒冰精灵 - 冰柱坠落\n[c/FF0000:地狱]: 突袭骑士 - 灾难仪式\n[c/FF0000:邪恶群落]: 哥布林弓手 - 厄运之箭\n[c/FF0000:默认森林]: 忍者 - 影分身突袭");
				sb.Replace("[c/FF0000:Ship Crasher]: Targets and then strikes from targets above\n[c/FF0000:'Bat Eye' Shelley]: Target and attacks with baby bats\n[c/FF0000:S. Bones]: Attacks mouse direction with inkshots + generates aquatic tornados\n[c/FF0000:Bubble Raider]: Flies with Bubble and strikes with flies. When bubble get hit it pops but raider get more aggressive",
							"[c/FF0000:跳帮者]: 瞄准并从目标上方攻击\n[c/FF0000:蝙蝠眼雪莉]: 用蝙蝠宝宝瞄准并攻击\n[c/FF0000:碎颅]: 用墨迹向光标位置攻击，生成水龙卷\n[c/FF0000:泡泡突袭者]: 用泡泡飞行，用苍蝇攻击。当泡泡被击中时，突袭者会变得更具攻击性");
				
				tooltipLine.Text = Regex.Replace(sb.ToString(), @"^Hold Shift while hovering on item to.*", "光标放在物品上并按住Shift键，查看 Wiki 上的详细说明");
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