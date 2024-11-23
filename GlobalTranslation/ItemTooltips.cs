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
				//sb.Replace("", "");
				sb.Replace("-Dedicated Content-", "-专属内容-");
				sb.Replace("-Crossover Content-", "-联动内容-");
				sb.Replace("Trinket", "密藏");
				sb.Replace("Artifact", "祭品");
				sb.Replace("Prize Token", "游戏币");
				sb.Replace("Current Reward:", "当前奖励: ");

				sb.Replace("True Melee ", "真");
				sb.Replace("active summon ", "主动");
				sb.Replace("transformation summon ", "变身");
				sb.Replace("No Random Crit Chance", "无暴击率");
				sb.Replace(" combo power cost", "点连击能量消耗");

				//上海套装效果
				sb.Replace("Taking heart while having full hp spawn dolls that attack close enemies\nIf player have ability to flight they also gain that ability",
							"满血状态获得心时，生成攻击敌人的玩偶\n玩偶会复制玩家的攻击手段");
				
				//点金石
				sb.Replace("It could be placed on philospher's table by RC on its tile while holding this item", "手持点金石右键放在转化工作台上");
				//卫星数据收集器
				Player player = Main.player[Main.myPlayer];
				sb.Replace("Players current position: " + (int)player.position.X + " X and " + (int)player.position.Y + " Y",
							"玩家当前位置坐标: (" + (int)player.position.X/16 + ", " + (int)player.position.Y/16 + ")");
				//雨伞
				sb.Replace("At the hands of nuclear moth it can break the solar storms", "在光辉蛾的手中，它可以打破太阳风暴");
				//暗影钥匙、圣骑士盾、圣骑士锤
				sb.Replace("Can be traded with holy knight", "可与神圣骑士进行交易");

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

				//飞镖枪武器
				sb.Replace("Uses darts as ammo", "使用飞镖作为弹药");
				sb.Replace("Base: Shoots a powerful, high velocity dart", "基础模式: 射出强力的高速飞镖");
				sb.Replace("Ligament Ejector: Hits sprays blood", "韧带弹射器: 命中后泼洒血液");
				sb.Replace("Vile Eruptor: Breathes cursed flames along with dart", "邪恶喷发器: 享受诅咒焰的洗礼");
				sb.Replace("Base: Cover the darts with darkness", "基础模式: 用暗影包裹飞镖");
				sb.Replace("Obsidian: Burn the darts with unholy flames", "黑曜石: 用邪恶的火焰燃烧飞镖");

				//绊之怒火
				sb.Replace("LC allow player to throw baseball for strike and RC does slam and upon slamming enough enemy player enter into berserk state\nRC uses baseballs as ammo and while no ball is thrown RC will throw ball and when there is a ball RC will do strike to mouse direction\n[c/ffff00:Slam Ability]: Hitting any enemy will inflict electrified + has a small chance to inflict Kizuna's attraction\nAny enemy that have this debuff cause them to have gravitational power towards each other\nIf any enemy collide with each other this power crush their inner organs which cause increase in true DoT for each enemy being in the area\n[c/ffff00:Strike Ability]: Overcharges every ball type which could be observed from its outer energy area\nWhen any ball is being charged they will attract weaker hostile projectile to itself + when ball hit any enemy it will release lightnings and decharge\n[c/ffff00:BERSERK]: Weapon do 150% increased modifiers.FinalDamage.Flat + 50% increased melee speed and +10 increased crit\nWhile in bersek ability player slams have a greatly increased chance of inflicting Kizuna's attraction + no strike but kill heals + refill berserk\n                                                   -Page 1-",
							"右键投出棒球，左键重击；当重击足够多敌人后，玩家进入狂暴状态\n左键消耗棒球作为弹药，空中无棒球时扔出棒球，而有棒球时则向光标方向进行打击\n[c/ffff00:重击能力]: 攻击任何敌人将造成带电效果，并有很小的几率施加羁绊引力\n带有此减益的敌人之间会相互吸引\n如果它们相互碰撞，这种力量将粉碎它们的内脏器官，并增加附近敌人受到的持续伤害\n[c/ffff00:打击能力]: 对所有类型的棒球弹药进行过载充能，改变其外观\n过载充能的棒球弹药会吸引较弱的敌对射弹，并在击中任何敌人时释放链状闪电\n[c/ffff00:狂暴状态]: 武器造成额外 150% 伤害，增加 50% 近战攻速度和 10% 暴击率\n狂暴状态下，玩家的猛击有很高的几率施加羁绊引力，非直接攻击但击杀敌人会治疗玩家并延长狂暴状态\n                                                   - 第一页 -");
				sb.Replace("Harvesting plants have a small chance to concentrate metals in their molecules which cause player to be able to collect ores from them\nKilling enemies have a small chance to harvest their souls\nEfficiency stat will increase the collection rate of the plants + hay when this tool will be used\nWhile equipped as trinket it will allow player to form electric dash with 1.5 second cooldown\nWhile doing electric dash player bypass projectile modifiers.FinalDamage.Flat + slamming enemy both generate lightning bolts + inflict electrified\n[c/FFC0CB:???]\nRC to item to generate pure enegy to use it as trinket\nWhen player press down along with trinket hotkey player will drop all trinkets and else cycle new one with olders\nWhen player is holding trinket by pressing trinket key it can unequip the trinket\n                                                   -Page 2-",
							"收割植物时有很小的几率富集金属，额外产生矿石\n杀死敌人时，有很小的几率收获他们的灵魂\n效率属性将提升此工具用于收割植物和干草时的采集速度\n右键生成羁绊火花\n装备在密藏栏时，玩家可以使用闪电冲刺，1.5 秒冷却时间\n无视射弹，撞击敌人时释放闪电并造成带电效果\n[c/FFC0CB:???]\n当玩家按下密藏快捷键时，将卸下所有密藏\n当玩家手持密藏按下密藏快捷键时，可以卸下密藏\n                          - 第二页 -");
				sb.Replace("Harvesting plants have a small chance to concentrate metals in their molecules which cause player to be able to collect ores from them\nKilling enemies have a small chance to harvest their souls\nEfficiency stat will increase the collection rate of the plants + hay when this tool will be used\nWhile equipped as trinket it will allow player to form electric dash with 1.5 second cooldown\nWhile doing electric dash player bypass projectile modifiers.FinalDamage.Flat + slamming enemy both generate lightning bolts + inflict electrified\n[c/FFC0CB:Mom's Box Effect]:Non boss enemy slam gain dynamic knockback + inflict Kizuna's Attraction\nRC to item to generate pure enegy to use it as trinket\nWhen player press down along with trinket hotkey player will drop all trinkets and else cycle new one with olders\nWhen player is holding trinket by pressing trinket key it can unequip the trinket\n                                                   -Page 2-",
							"收割植物时有很小的几率富集金属，额外产生矿石\n杀死敌人时，有很小的几率收获他们的灵魂\n效率属性将提升此工具用于收割植物和干草时的采集速度\n右键生成羁绊火花\n装备在密藏栏时，玩家可以使用闪电冲刺，1.5 秒冷却时间\n无视射弹，撞击敌人时释放闪电并造成带电效果\n[c/FFC0CB:收纳盒特殊能力]: 重击非Boss敌人造成强力击退，施加羁绊引力\n当玩家按下密藏快捷键时，将卸下所有密藏\n当玩家手持密藏按下密藏快捷键时，可以卸下密藏\n                             - 第二页 -");
				
				#region 妈妈的收纳盒产生的密藏特殊能力
				sb.Replace("[c/FFC0CB:Mom's Box Effect]:", "[c/FFC0CB:收纳盒特殊能力]: ");

				sb.Replace("An angelic sword will protect players back + if player holds true melee weapon additional angelic sword will spawn",
							"召唤一把天使之剑将保护玩家，如果玩家持有真近战武器，将会产生额外的天使之剑");
				sb.Replace("Instead of direct respawn it continue to protect player and slowly fades away",
							"重生后幽灵不会立刻消失，而是继续守护玩家一段时间，然后慢慢消失");
				sb.Replace("Taking damage higher than 5% of life have 10% chance to call a S.A.T.L.A.-001 to strike",
							"受到超过生命值5%的伤害时，有10%的几率召唤SATLA-001进行反击");
				sb.Replace("Bats have a chance to throw 2 baseball at the same time while doing RC ball throw",
							"使用棒球棍武器右键投球时，有几率同时投出两个棒球");
				sb.Replace("Instead of overheat damaging player it will now give player 20% increased mana usage + inferno buff",
							"过热产生的爆炸不会伤害玩家，而是使玩家的魔力消耗增加20%，并赋予狱火增益");
				sb.Replace("Convert feral bite into a positive effect buff which increase damage by 15% instead of 20% but randomly gives buffs instead of debuffs",
							"将野性咬噬转化为正面效果，增加15%伤害（而不是原版的20%），并随机赋予增益而不是减益");
				sb.Replace("When this effect happen player will also produce fart cloud which damage + poison any enemy that touch it",
							"当此效果触发时，玩家还会产生毒气云，对任何接触到它的敌人造成伤害并施加中毒");
				sb.Replace("Bomb effect activates twice",
							"炸弹效果触发两次");
				sb.Replace("Heal source now heal by 2 + immunity to bleeding",
							"任意来源的生命恢复量增加2点并免疫流血");
				sb.Replace("Attacks have a chance to be true damage",
							"任意攻击都有几率造成真实伤害");
				sb.Replace("Bounce type damage increase by 200% + immunity against oozed and slime",
							"反弹型伤害增加200%，免疫史莱姆粘液和食人魔唾液减益");
				sb.Replace("Player becomes a host and brain clot starts to attack close enemies",
							"玩家变成滴滴怪宿主，血栓触手开始攻击附近的敌人");
				sb.Replace("Increases the catch rate of rare fishes",
							"增加钓到稀有渔获的几率");
				sb.Replace("Hitting enemy with true melee sword have a chance to activate its ability twice",
							"用真近战剑命中敌人时，有几率触发其能力两次");
				sb.Replace("Consuming cookies will also make every buff that have 1-7 minute time left get refreshed to 7 minute",
							"吃掉饼干后，会使所有剩余时间为1-7分钟增益的效果持续时间刷新为7分钟");
				sb.Replace("Drastically increase damage bonus and penalty",
							"大幅增加伤害加成和惩罚的效果");
				sb.Replace("This effect activate while player is below 25% max hp",
							"当玩家生命值低于25%时触发密藏效果");
				sb.Replace("Hyperactive buff will also make projectiles gain 50% increased velocity",
							"多动症同时增加50%射弹的速度");
				sb.Replace("Player get random discounts and get part of its money back while buying from npc shop with RC",
							"当玩家右键从NPC商店购买物品时，会有随机折扣并获得部分退款");
				sb.Replace("Buff and debuff happen at the same time + debuffs duration is 5 second while buff duration is 15 second",
							"增益和减益会同时出现，增益持续15秒而减益持续5秒");
				sb.Replace("It may also appear between players and sentry or between sentries or minions",
							"玩家和哨兵之间、哨兵和哨兵之间也有几率产生电弧");
				sb.Replace("It will not lose its heat",
							"它将不会损失热量");
				sb.Replace("Hook produce stench aura that poisons enemies + additional junk get possiblity increase",
							"鱼钩产生对敌人施加中毒的恶臭气场，提高额外垃圾出现的几率");
				sb.Replace("Allows submerged with liquid effect with no restrictions",
							"可以无限制地视为浸没在液体中");
				sb.Replace("Speed stat cannot get lower than its initial value (Unless any mod does hardcoded speed adjust)",
							"玩家的速度不会低于其初始值（除非有其它模组进行了速度的硬编码调整）");
				sb.Replace("It provides immunity against chilled + gives warmth effect",
							"免疫冷冻并赋予保暖药水效果");
				sb.Replace("Player emit fear area and it turns into horror if player already have psychological aura",
							"玩家散发出施加恐惧的气场，如果玩家装备了尤里之眼，则会施加惊骇");
				sb.Replace("Non boss enemy slam gain dynamic knockback + inflict Kizuna's Attraction",
							"撞击非Boss敌人产生强力击退并施加羁绊引力");
				sb.Replace("When any feared enemy does contact damage there is a small chance to they hit themselves instead",
							"当任何受到恐惧减益的敌人造成接触伤害时，有很小的几率击伤自己");
				sb.Replace("It have a small chance to also protect player from death",
							"它也有很小的几率可以保护玩家免于死亡");
				sb.Replace("Taking projectile damage also hurt closest enemy with same amount + reflecting increase damage by 100%",
							"受到射弹伤害时，会以相同的数值伤害最近的敌人，并且反弹回去的射弹伤害增加100%");
				sb.Replace("Taking hit while tarot cooldown is active have a small chance to activate random tarot major effect",
							"当塔罗牌处于冷却时间时，受到攻击有很小的几率触发随机的塔罗牌主要能力");
				sb.Replace("Berserk state swings have a chance to shoot nails",
							"狂暴状态下的棒球棍攻击有几率射出钉子");
				sb.Replace("Any bugs have a chance to be stronger",
							"小寄生蜂有几率变得更强");
				sb.Replace("Instead of glitching out and despawn it now attacks player",
							"宝藏袋不会逃跑而是试图攻击玩家");
				sb.Replace("Picking item from ground 25% chance to quadruple the amount and 75% chance to nullify the item",
							"每次拾起物品都有25%的概率让数量变为四倍并有75%的概率使其消失");
				sb.Replace("Harvesters gain small chance to perform harvest crit which double efficiency",
							"有几率获得双倍效率提升");
				sb.Replace("Double tap down will spawn it to ground which spew out coins that inflict midas",
							"双击下键释放施加迈达斯减益的钱币云");
				sb.Replace("Trophy drop chance now increase by 20%",
							"纪念章掉落概率现在提升20%");
				sb.Replace("Elite enemy spawn frequency increase + they give a guaranteed heart and star on death",
							"精英敌人的生成概率增加，死亡时必定掉落一颗生命心和魔力星");
				sb.Replace("Taking damage higher than 5% of life have 10% chance to call a bunny zeppelin to strike",
							"受到超过生命值5%的伤害时，有10%的几率召唤兔子飞艇进行反击");
				sb.Replace("A mediocre electrician will help you to charge your enemies along with decrease cooldown of afkpets aiming sentries",
							"一个平庸的电工将帮助你电击你的敌人，同时减少本模组瞄准类型哨兵的冷却时间");
				sb.Replace("Occurance of this effect will additionally give player life drain",
							"此效果触发时还会使玩家的生命值流失");
				sb.Replace("Double tap down will make player strike below with anchor",
							"双击下键释放猛击地面的船锚");
				sb.Replace("Each active player get their soul shattered and piece of their soul protect the player and there can be max 5 active",
							"每个活跃玩家破碎灵魂的一部分都被用来保护玩家，最多同时存在5个灵魂碎片");
				sb.Replace("The spawned projectiles have 50% chance have base id -1 and 50% chance to have base id +1",
							"实际生成射弹的序号有50%的几率会比正常生成的少1位，有50%的几率会比正常生成的多1位");
				sb.Replace("This ability do not affect from having life regen less than 0",
							"当生命再生速率低于0时，此效果不受影响");
				sb.Replace("If player does not have any wing it grow harpy wings and if it does it gets increased wing time instead",
							"如果玩家没有翅膀，则长出鸟妖之翼；如果已经有翅膀，则增加翅膀的飞行时间");
				sb.Replace("Player gain endurance buff instead + spawn with full hp",
							"重生时恢复全部生命值，获得伤害减免而不是生命再生增益");
				sb.Replace("Player gain aura with respect to 5 different time period of day which increase specific stats",
							"玩家根据一天中的五个不同时间段获得光环，增加特定属性");
				sb.Replace("Player form dryad's bane aura around itself",
							"玩家生成围绕自身的树妖之环");
				sb.Replace("Minion hits have a chance to call a plane to do bloody rotor strike",
							"召唤物的攻击有几率召唤一架飞机进行血腥旋翼打击");
				sb.Replace("Effects will work until reaching below 75% of corresponding hp and mana",
							"在生命值和魔力值低于75%前，效果将持续激活");
				sb.Replace("If taking heart increase players life to above max it will make player grow snake head for a short time\nThere can be max 3 snake grow from player + after player have max snake taking heart from ground have a chance to clear debuffs",
							"如果拾取生命心后玩家的生命值超过最大值，则会在短时间内长出蛇头\n最多可以长出3条蛇头，此时从地面拾取生命心有几率直接清除减益");
				sb.Replace("Holding tools will also provide thorns effect + knockback immunity",
							"手持工具额外获得荆棘效果并免疫击退");
				#endregion

				#region 特殊词缀-来源于晦暝祭坛
				//真近战修饰语：
				sb.Replace("Random damage + inflicted buff + enemy location",
							"随机造成伤害、获得增益、敌人的位置");//随机
				sb.Replace("Hearts buff melee + Crit Kill heal + make happy",
							"生命心增强近战，暴击获得治疗");//欢乐
				sb.Replace("Flowers bloom, breaking summon guardian soul",
							"鲜花盛开，召唤守护之魂");//绽放
				sb.Replace("Defense increase by weapon base damage/8",
							"增加基础伤害八分之一的防御");//掩护
				sb.Replace("Hitting same enemy increase damage",
							"攻击同一敌人会增加伤害");//勾连
				sb.Replace("True damage but divided equal to any close enemy",
							"对附近的敌人造成平分的真实伤害");//共产
				sb.Replace("Attacks burn + may charm close enemies to become passive",
							"点燃敌人，有几率使附近的敌人变得消极");//摩托
				sb.Replace("Crit give flex which allow reflection of weaker projectiles",
							"暴击可以反弹较弱的射弹");//健美
				sb.Replace("Crit rain icicle + inflict frostburn",
							"暴击时有冰柱从天而降并施加霜冻");//高冷
				sb.Replace("Penetration III\nBlast Protection\nEfficiency II",
							"穿透 III\n爆炸保护\n效率 II");//附魔
				sb.Replace("Size increases by 250%",
							"物品大小变为2.5倍");//稽大
				sb.Replace("Crit have crit and its chance is determined by rarity",
							"根据物品稀有度，暴击时有几率造成额外伤害");//无政府主义
				sb.Replace("Hits have a chance to reflect one of your debuff back to enemy\nVanilla + AFKPets buffs are supported",
							"攻击有几率将减益反弹给敌人\n适配原版减益和本模组减益");//剑豪的
				sb.Replace("Hits form confusing shiny dust",
							"攻击产生令人困惑的闪光");//炫目
				sb.Replace("Attacks have a chance to inflict oiled\nPlayer have a chance to slip throw its weapon",
							"攻击有几率施加涂油\n玩家有几率扔出浸油剑");//浸油
				//魔法修饰语：
				sb.Replace("Mana stars also call fairies for help",
							"魔力星会召唤仙子帮助");//魔法师的
				sb.Replace("non boss enemies get unique ai, bosses get stat change",
							"攻击有几率使非Boss敌人获得独特AI并更改Boss的属性");//独特
				sb.Replace("No hitting and graze increase magic damage, taking hit reset",
							"无伤时增加魔法伤害，受击时重置");//灾劫
				sb.Replace("Weapon shoot twice with 45 degree difference and with 60% base damage",
							"魔杖以45度角发射造成60%基础伤害的两次攻击");//超频
				sb.Replace("Attacks have small chance to inflict soulblight",
							"攻击有几率施加灵魂枯萎");//灾厄
				sb.Replace("Hit enemies debuffs have small chance to spread",
							"攻击使敌人的减益有几率传播");//恶毒
				sb.Replace("Damage become true damage which bypass defense + DR",
							"攻击造成无视防御和减伤的真实伤害");//现实主义
				sb.Replace("Attacks have small chance to call rainbow stars",
							"攻击有几率召唤彩虹星星");//闪亮
				sb.Replace("Attacks have small chance to spook your foes",
							"攻击有几率惊吓敌人");//战兢
				sb.Replace("Coins also give mana",
							"钱币可以恢复魔力");//贪婪
				sb.Replace("Hostile spiritual pigeons may spawn but these also drop soul heart + arcane mana",
							"有几率生成掉落灵魂之心和奥术法力的灵鸽");//魔术师
				sb.Replace("Attacks have small chance to inflict explosive chemical",
							"攻击有几率施加化学易爆性");//泄露
				sb.Replace("Player drain town npc life for increased mana + life regen while not have max mana",
							"伤害城镇NPC可以增加魔力和生命再生");//虐待狂
				sb.Replace("Attacks form shadows that channel damage to actual one",
							"攻击形成暗影，暗影受到伤害时敌人也会受到伤害");//扭曲
				sb.Replace("Weapon have chance to shoot additional spell",
							"攻击有几率额外释放魔法射弹");//古老
				//射手修饰语：
				sb.Replace("Arrow gain slight homing",
							"箭矢可以轻微追踪");//神射手的
				sb.Replace("Arrow may bounce to closest enemy",
							"箭矢不能穿甲但有几率弹射攻击最近的敌人");//弹力
				sb.Replace("Shoot copy of shot arrow 180 degrees from its trajectory angle",
							"发射相反的额外箭矢");//对称
				sb.Replace("25% chance to not use ammo + hits have 10% chance to refund arrow",
							"25%的几率不消耗弹药，攻击有10%的几率回收箭矢");//节约
				sb.Replace("Pierce up + first pierce attack ignore half of enemy defense",
							"穿刺，第一次攻击忽视敌人一半的防御");//穿透
				sb.Replace("1000% increased arow size",
							"箭矢大小变为10倍");//龙爪
				sb.Replace("First hit inflict random afk pets or vanilla debuff",
							"第一次攻击随机施加原版或本模组的减益");//涂刷
				sb.Replace("Shooting bow have 20% chance to make an orbiting arrow as same type",
							"有20%几率射出相同类型的轨道箭");//轨道
				sb.Replace("Crit will rain cluster of arrow from sky that target same",
							"暴击将降下攻击相同目标的箭雨");//暴雨
				sb.Replace("Aim get inaccurate",
							"瞄准变得不准确");//酒醉
				sb.Replace(" Non boss hits cause dynamic knockback + 20% of enemy defense is ignored",
							"命中非Boss敌人造成强力击退，忽视敌人20%的防御");//主宰
				sb.Replace("No penetration + no tile collision + same type arrow hit trajectory aim",
							"相同类型的箭矢会修正弹道，无护甲穿透但可以穿墙");//自瞄
				sb.Replace("Hit make arrow divide into smaller arrows in different directions",
							"命中后分裂成不同方向的箭矢");//弹片
				sb.Replace(" Hitting a new npc do 15% more damage but same npc do 10% less damage",
							"击中新的敌人造成15%额外伤害，击中相同敌人降低10%伤害");//扩散
				#endregion

				//婚戒
				sb.Replace("A beautiful ring designed for owner of your heart\nYour heart is beating one with the designer\nWhen you take damage you have 5% chance to take half from it and 5% take 75% of it\nHer love will increase your maximum health and life regen\nBeing close to your love will increase your endurance by 4% and protect her from taking damage",
							"一枚为你心爱之人设计的美丽戒指\n你的心跳与设计者共同跳动\n受到伤害时，有 5% 的几率只受到一半的伤害，5% 的几率受到75%的伤害\n她的爱会增加你的最大生命值和生命再生速度\n当你靠近心爱的人时，增加4%伤害减免，并保护她免受伤害");
				sb.Replace("A beautiful ring designed for owner of your heart\nYour heart is beating one with the yandere\nHitting enemies with true melee give you heart of a killer buff which will increase your damage\nWhen you have less than 20% life your yandere instinct will activate and your movement speed increase by 10%\nIn yandere state your damage increase by 3% and critical hit chance by 5% but you will lose half of your defense and life regen\nBeing close to your love will increase your endurance by 4% and protect her from taking damage",
							"一枚为你心爱之人设计的美丽戒指\n你的心跳与病娇公主共同跳动\n用真近战武器击中敌人时，获得杀手之心增益，增加伤害\n当生命值低于20%时，触发病娇本能，增加 10% 移动速度\n在此状态下，增加 3% 伤害和 5% 暴击率，但失去一半的防御和生命再生\n当你靠近心爱的人时，增加4%伤害减免，并保护她免受伤害");
				sb.Replace("A beautiful ring designed for owner of your heart\nIt will have no effect until your heart have enough love",
							"一枚为你心爱之人设计的美丽戒指\n除非你的心有足够的爱，否则它不会起作用");
				
				#region 盒中伙伴
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
							"[c/ffff00:突袭骑士]\n标记最近的敌人，在该敌人周围形成禁忌仪式\n[c/ffff00:群落特殊能力]: 在他周围生成一个灾难区域，经过该区域的召唤物可能被标记\n标记后被削弱，但所有攻击造成真实伤害，同时有几率施加灵魂枯萎");
				sb.Replace("[c/ffff00:Tiny Ninja]\nHe will strike close enemies with shurikens + RC will teleport them around your mouse location\n[c/ffff00:Biome specific Ability]: He will form shadow clones around the enemy that do katana strike",
							"[c/ffff00:忍者]\n用手里剑攻击附近的敌人，右键会将他们传送到光标位置\n[c/ffff00:群落特殊能力]: 在敌人周围生成用武士刀攻击的影分身");
				sb.Replace("[c/ffff00:Tiny Goblin Archer]\nHe will shoot your foes down with arrows which gets changed with respect to enviromental conditions\n[c/ffff00:Biome specific Ability]: Upon hitting enemy the arrows will split into 2 weaker that moves backwards",
							"[c/ffff00:哥布林弓手]\n射出根据环境群落改变的箭攻击你的敌人\n[c/ffff00:群落特殊能力]: 击中敌人后分裂出两个较弱的向后移动的箭");
				#endregion

				#region 塔罗牌
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

				sb.Replace("'A divine relic which made from great harpy bars'", "'这是由鹰身女妖制成的圣物'");
				sb.Replace("'The legends tell if you sip from the chocolate milk you will bless with the wisdom of how to find Pandaen Ore'\nWhen you use item when the lord have already awoken she will light your path with true wisdom.", "''传说，如果你品尝这巧克力牛奶，你将会被赐予寻找潘达恩矿石智慧的祝福'\n当你使用这件物品时，如果领主已经觉醒，她将会用真正的智慧照亮你的道路");
				sb.Replace("It has been cursed by a powerful Hell Beast'", "它被地狱的血肉之墙诅咒了");
				sb.Replace("It has been cursed by the Eldritch of Darkness'", "它被月亮领主的黑暗神秘力量诅咒了");
				sb.Replace("It has been cursed by a powerful jungle creature'", "它被强大的丛林之花诅咒了");
				sb.Replace("Become usable after you prove yourself via taking head of the false lunatic cultist'", "当你击败拜月邪教后，可以使用此物品");
				#endregion

				#region 失落-彩蛋
				sb.Replace("1.Neutral:If you do not do any emotional change for some time it convert back to default and have following effects:\n-Nopperabou: Enemy aggro decrease + all ghost type enemies show no aggro\n-Towel: Immunity to being we + chilled + you may sneeze which inflict every close enemy fear due to coronavirus\n-Cat: A koban coin rotate around you which inflict midas + enemy aggro increase\n-Lamp: You generate light + when non boss enemies get close to you they may feel dizzy",
							"1.中立: 如果你一段时间内没有情绪变化，它将回归初始状态并获得以下效果:\n-幽灵: 减少敌人仇恨，所有鬼魂类敌人对你无仇恨\n-毛巾: 免疫虚弱和寒冷，打喷嚏可使周围敌人因冠状病毒而恐惧\n-猫: 一个异域硬币围绕你旋转，对敌人施加迈达斯并增加仇恨\n-灯: 你发出光芒，非Boss敌人靠近你可能会眩晕");

				sb.Replace("2.Happy:If you drink potion, get heal with heart or talk to any town npc you get this emotion and it have following effects:\n-Bicycle: While on mount your defensive stats increase + you produce light and while not on mount your speed increase\n-Buyo Buyo: There is a 10% chance to not take damage from any attack and instead make squish sound\n-Neon: RAINBOW + gain flight based stat increase\n-Long Hair: You feel happy + crit chance increase + your beauty convince shop keepers to decrease the price",
							"2.快乐: 当你饮用药水、被生命心治疗或与城镇NPC交谈，则获得此状态并获得以下效果:\n-自行车: 使用坐骑时防御提升并发光，不使用坐骑时速度增加\n-槟榔: 10%几率免疫任何攻击，发出咯吱声\n-氖: 彩虹效果，飞行属性提升\n-长发: 感到快乐，暴击率提升，你的美貌使得商店降级售价");

				sb.Replace("3.Sad:When any friendly npc or any player in mp dies you get this emotion and it have following effects:\n-Poop Hair: You periodically generate flies + flying bug type enemies show no aggro on you\n-Severed Head: A severed head will point to your mouse direction along with hurting enemies + having a chance to reflect enemy projectiles\n-Fat: Gain defensive stat increase but movement speed decrease\n-Midget: +1 minion + minions may spray blood",
							"3.悲伤: 如果友好NPC或多人游戏中的玩家死亡，则获得此状态并获得以下效果:\n-脏发: 周期性生成苍蝇，飞行虫类敌人对你无仇恨\n-断头: 被斩首的头颅指向光标方向，伤害敌人，有机会反弹敌人的射弹\n-肥胖: 防御提升，但移动速度下降\n-侏儒: 增加一个仆从栏，仆从可能喷血");

				sb.Replace("4.Angry: When you take hit while there is no boss you get this emotion and it have following effects:\n-Knife: A kitchen knife will protect you and its attacks counted as minion damage\n-Demon: Generate lightnings around you periodically\n-Witch: Your magic casts may form additional dark based spells\n-Yuki-onna: Rain snow from above + enemies that get close have a chance to get frozen",
							"4.愤怒: 当你在无Boss时受到攻击，则获得此状态并获得以下效果:\n-刀: 一把厨房刀会保护你，其攻击算作召唤伤害\n-恶魔: 周期性生成闪电环绕你\n-巫师: 魔法攻击可能形成额外的黑暗系法术\n-雪女: 从天空中降下雪花，有几率冰冻靠近的敌人");

				sb.Replace("5.Stressed: When you take hit while there is boss you get this emotion and it have following effects:\n-Frog: Gain autojump + jump stat increase + walking on water\n-Umbrella: Forms a cloud that above your mouse which periodically rains\n-Hat and Scarf: Gain immunity against cold based debuffs + defensive stat increase + warmth effect\n-Flute: Cause living human based enemies show no aggro on you + periodically generate music notes in random direction",
							"5.紧张: 当你在有Boss时受到攻击，则获得此状态并获得以下效果:\n-青蛙: 自动跳跃，跳跃属性提升，能在水上行走\n-伞: 在光标上方形成云，周期性降雨\n-帽子和围巾: 免疫寒冷减益效果，防御提升，有温暖效果\n-笛子: 使人形敌人对你无仇恨，周期性在随机方向生成音符");

				sb.Replace("6.Afraid: When you are close to death you get this emotion and it have following effects:\n-Medamaude: You gain immunity against chaos state + your location get unstable\n-Blonde Hair: Collect all town npc close you periodically to fight for you + periodically heal them\n-Triangle Kerchief: Lose DR but you periodically gain immunity frames\n-Stoplight: Briefly stop time",
							"6.恐惧: 当你接近死亡时，则获得此状态并获得以下效果:\n-梅达莫德: 免疫混乱状态，你的位置变得不稳定\n-金发: 定期召集周围城镇NPC为你而战，并治疗他们\n-三角头巾: 失去伤害减免，但定期获得无敌帧\n-交通信号灯: 短暂停止时间");
				#endregion
				
				#region wiki说明
				sb.Replace("It drops from [c/FF0000:Cookie Crate]\n[c/FF0000:Cookie Crate] could be fished from ocean and its a strong enemy",
							"[c/FF0000:饼干板条箱]掉落\n使用复合亮片诱饵或在海洋环境有几率钓到 [c/FF0000:饼干板条箱]，它是一个强大的敌人");
				sb.Replace("Could be obtained from [c/FF0000:Cookie Box]\nIt become fishable in ocean after player equip [c/FF0000:Cookie Badge] which drop from [c/FF0000:Cookie Crate]\n[c/FF0000:Cookie Crate] could be fished from ocean and its a strong enemy\nIf player activate no fish mechanic option from mod config it bypass this",
							"可以从 [c/FF0000:饼干盒] 获得\n装备 [c/FF0000:饼干板条箱] 掉落的 [c/FF0000:饼干徽章] 后，钓鱼有几率获得 [c/FF0000:饼干盒]\n使用复合亮片诱饵或在海洋环境有几率钓到 [c/FF0000:饼干板条箱]，它是一个强大的敌人\n如果在设置中启用了禁用额外的钓鱼机制选项，将绕过此限制");
				sb.Replace("It drops from [c/FF0000:Spirit of Gluttory]\nFirst defeat [c/FF0000:Cookie Crate]\nThen burn [c/FF0000:Cookie Badge] item with [c/FF0000:Lamb Sauce][c/FF0000:Cookie Crate] could be awoken from fishing her in ocean",
							"[c/FF0000:贪食之魂]掉落\n首先击败 [c/FF0000:饼干板条箱]\n然后在友好的饼干魂面前用 [c/FF0000:羊酱汁] 燃烧 [c/FF0000:饼干徽章] 以激怒它\n使用复合亮片诱饵或在海洋环境有几率钓到 [c/FF0000:饼干板条箱]，它是一个强大的敌人");
				sb.Replace("Could be obtained from [c/FF0000:Cookie Crate] and [c/FF0000:Cookie Box]\n[c/FF0000:Cookie Crate] could be fished from ocean and its a strong enemy\nCheck [c/FF0000:Cookie Box] lil wiki entry for more info for it",
							"可以从 [c/FF0000:饼干板条箱] 和 [c/FF0000:饼干盒] 获得\n使用复合亮片诱饵或在海洋环境有几率钓到 [c/FF0000:饼干板条箱]，它是一个强大的敌人\n查看 [c/FF0000:饼干盒] 以获取更多信息");

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
				sb.Replace("Sold by [c/FF0000:Cyborg]", "[c/FF0000:机器侠]在派对期间售卖（当前有BUG不会售卖，请等待AFK本体更新）");
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
				
				sb.Replace("[c/FF0000:Potted Baum]: DAW MAH GAWD Did you see that pro acorn planting?\nAttacks enemies with leaves and places explosive acorns around itself\n[c/FF0000:Potted Cactus]: Still trying to find a holiday between halloween and Christmas for England\nDoes 1000 needle technique against close targets and half alive tick needle agaist far away ones",
							"");
				
				tooltipLine.Text = Regex.Replace(sb.ToString(), @"^Hold Shift while hovering on item to.*", "光标放在物品上并按住Shift键，查看 Wiki 上的详细说明");
				#endregion
			}
		}
	}
}