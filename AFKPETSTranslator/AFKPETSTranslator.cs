using AFKPETSandmorezhcn.Systems;
using System.Collections.Generic;
using Terraria.ModLoader;
namespace AFKPETSandmorezhcn.AFKPETSTranslator
{
	public class AFKPETSTranslator
	{
		private class AFKPETS{}
		[ExtendsFromMod("AFKPETS"), JITWhenModsEnabled("AFKPETS")]
		private class TranslatorLoad : ForceLocalizeSystem<AFKPETS, TranslatorLoad>{}
		public static void LoadTranslator()
		{
			if(ModLoader.TryGetMod("AFKPETS",out var mod))
			{
				#region AFKPETS.AFKPetsCurrency
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.AFKPetsCurrency", "GetPriceText", new ()
				{
					{"Prize Token","游戏币"},
				});
				#endregion AFKPETS.AFKPetsCurrency


				#region AFKPETS.UI.MinesweeperUI
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.UI.MinesweeperUI", "OnInitialize", new ()
				{
					{"-MINESWEEPERS-","-扫    雷-"},
					{"10 Mines Placed","10 个地雷"},
					{"Retry","重置"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.UI.MinesweeperUI", "Update", new ()
				{
					{"Congrats you find all of the mines","恭喜你找到了所有地雷"},
					{"Press retry to start again","点击重新开始"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.UI.MinesweeperUI", "click_mine", new ()
				{
					{"Sorry, you press to the mine","不好意思你按到地雷了"},
					{"Press retry to start again","点击重新开始"},
				});
				#endregion AFKPETS.UI.MinesweeperUI


				#region AFKPETS.UI.MinigameUI
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.UI.MinigameUI", "OnInitialize", new ()
				{
					{"[c/ff0000:-MINIGAMES-]","[c/ff0000:-迷 你 小 游 戏-]"},
					{"Start Playing","开始游戏"},
					{"1.Sokoban","1.推箱子"},
					{"2.Minesweepers","2.扫雷"},
					{"3.Thin Ice","3.薄冰"},
				});
				#endregion AFKPETS.UI.MinigameUI


				#region AFKPETS.UI.SokobanUI
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.UI.SokobanUI", "OnInitialize", new ()
				{
					{"-SOKOBAN-","-推  箱  子-"},
					{"Level:","关卡："},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.UI.SokobanUI", "Update", new ()
				{
					{"Level:","关卡："},
					{"Level ","关卡"},
					{" is solved","已完成"},
					{"Congrats you beat all of the levels","恭喜你通关！"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.UI.SokobanUI", "player_move", new ()
				{
					{"There is an error so please tell Sir AFK","程序发生错误，请通知作者或汉化组"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.UI.SokobanUI", "player_position", new ()
				{
					{"There is an error so please tell Sir AFK","程序发生错误，请通知作者或汉化组"},
				});
				#endregion AFKPETS.UI.SokobanUI


				#region AFKPETS.UI.ThinIceUI
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.UI.ThinIceUI", "OnInitialize", new ()
				{
					{"-THIN ICE-","-薄      冰-"},
					{"Level:","关卡："},
					{"Skill Issue?","技术问题？"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.UI.ThinIceUI", "Update", new ()
				{
					{"Level:","关卡："},
					{"Level ","关卡"},
					{" is solved","已完成"},
					{"Congrats you beat all of the levels","恭喜你通关！"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.UI.ThinIceUI", "player_move", new ()
				{
					{"There is an error so please tell Sir AFK","程序发生错误，请通知作者或汉化组"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.UI.ThinIceUI", "player_position", new ()
				{
					{"There is an error so please tell Sir AFK","程序发生错误，请通知作者或汉化组"},
				});
				#endregion AFKPETS.UI.ThinIceUI


				#region AFKPETS.Tiles.MagneticStorageUnit
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Tiles.MagneticStorageUnit", "RightClick", new ()
				{
					{"Wrong Answer","回答错误"},
				});
				#endregion AFKPETS.Tiles.MagneticStorageUnit


				#region AFKPETS.NPCs.TravellingNPCs.BountyHunter
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.TravellingNPCs.BountyHunter", "SetChatButtons", new ()
				{
					{"Quest","任务"},
				});
				#endregion AFKPETS.NPCs.TravellingNPCs.BountyHunter


				#region AFKPETS.NPCs.TravellingNPCs.Designer
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.TravellingNPCs.Designer", "SetChatButtons", new ()
				{
					{"Vanity Shop","外观商店"},
					{"You can share your heart with me","你可以和我说说心里话"},
					{"Help Her","帮助她"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.TravellingNPCs.Designer", "OnChatButtonClicked", new ()
				{
					{"Vanity Shop","外观商店"},
				});
				#endregion AFKPETS.NPCs.TravellingNPCs.Designer


				#region AFKPETS.NPCs.TravellingNPCs.Elitist
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.TravellingNPCs.Elitist", "SetChatButtons", new ()
				{
					{"Art Shop","艺术商店"},
					{"Exchange","交换"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.TravellingNPCs.Elitist", "OnChatButtonClicked", new ()
				{
					{"Art Shop","艺术商店"},
				});
				#endregion AFKPETS.NPCs.TravellingNPCs.Elitist


				#region AFKPETS.NPCs.TravellingNPCs.WanderingSamurai
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.TravellingNPCs.WanderingSamurai", "SetChatButtons", new ()
				{
					{"Eastern Shop","车万商店"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.TravellingNPCs.WanderingSamurai", "OnChatButtonClicked", new ()
				{
					{"Eastern Shop","车万商店"},
				});
				#endregion AFKPETS.NPCs.TravellingNPCs.WanderingSamurai


				#region AFKPETS.NPCs.TownNPCs.BossHunterMerchant
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.TownNPCs.BossHunterMerchant", "SetChatButtons", new ()
				{
					{"Base Shop","基础商店"},
					{"Reward Shop","奖励商店"},
					{"Next Boss","下个Boss"},
					{"Give Trophy","给予纪念章"},
					{"Boss Bag Shop","宝藏袋商店"},
					{"Change Option Type","更改选项类型"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.TownNPCs.BossHunterMerchant", "OnChatButtonClicked", new ()
				{
					{"Base Shop","基础商店"},
					{"Reward Shop","奖励商店"},
				});
				#endregion AFKPETS.NPCs.TownNPCs.BossHunterMerchant


				#region AFKPETS.NPCs.TownNPCs.FallenAngel
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.TownNPCs.FallenAngel", "SetChatButtons", new ()
				{
					{"Angelic Shop","天使商店"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.TownNPCs.FallenAngel", "OnChatButtonClicked", new ()
				{
					{"Angelic Shop","天使商店"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.TownNPCs.FallenAngel", "AddShops", new ()
				{
					{"Angelic Shop","天使商店"},
				});
				#endregion AFKPETS.NPCs.TownNPCs.FallenAngel


				#region AFKPETS.NPCs.TownNPCs.Yandere
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.TownNPCs.Yandere", "SetChatButtons", new ()
				{
					{"Shop","商店"},
					{"Give Her Letter","给她情书"},
					{"Give Her Bride Costume","给她婚裙和面纱"},
					{"Give Her Both Your Heart and Ring","将镌刻爱的戒指给她"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.TownNPCs.Yandere", "OnChatButtonClicked", new ()
				{
					{"Shop","商店"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.TownNPCs.Yandere", "AddShops", new ()
				{
					{"Shop","商店"},
				});
				#endregion AFKPETS.NPCs.TownNPCs.Yandere


				#region AFKPETS.NPCs.SlimeArmy.Tier2.SuspiciousSlime
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.SlimeArmy.Tier2.SuspiciousSlime", "AI", new ()
				{
					{"Help","帮助"},
				});
				#endregion AFKPETS.NPCs.SlimeArmy.Tier2.SuspiciousSlime


				#region AFKPETS.NPCs.SecurityBot.JumpscareFella
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.SecurityBot.JumpscareFella", "SetChatButtons", new ()
				{
					{"You are an Idiot","你是个笨蛋"},
				});
				#endregion AFKPETS.NPCs.SecurityBot.JumpscareFella


				#region AFKPETS.NPCs.SATLA001.SATLA001
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.SATLA001.SATLA001", "AI", new ()
				{
					{"No need to escape while we are having fun together","我们在一起玩的时候，没必要逃跑"},
					{"Hello there. Thank you for your kindness to invite me.","你好，谢谢你盛情邀请我。"},
					{"Before I give you your reward shall we play a nice game?","在我给你奖励之前，我们玩个游戏可以吗？"},
					{"For the game please cancel the answer buff for the answer you think is correct before time out.","请在时间截至前，在左上角增益栏右键取消你认为正确的答案"},
					{"Correct","回答正确"},
					{"Wrong Answer","回答错误"},
					{"Time is up. Have a nice gift","时间到，接受礼物吧"},
					{"It's quite interesting that you answer the questions upon now correct.","真厉害，你现在回答的问题是正确的"},
					{"Even through final question waits, I will reward your efford these tras- I mean small gifts","即使在最后一个问题等待期间，我也会用一些小礼物来奖励你的努力"},
					{"Time for the great reward and final question","是时候问最后一个问题了"},
					{"W H Y  Y O U  A R E  S T I L L  A L I V E ?","你 为 什 么 还 活 着？"},
					{"It seems I cannot play with you without breaking your resistance first","看来我好像得先粉碎你的抵抗才能跟你一起玩"},
					{"Recharge units, show my hospitality","充能单元，展示我的好客之道"},
					{"I even send Martians false information to make them believe this planet is worthless","我甚至给火星人发送虚假信息，让他们相信这个星球一文不值"},
					{"Because this planet is full of lifeforms to play","因为这个星球上充满了可供玩乐的泰拉人"},
					{"How ironic that the lifeform I played most will bring my end","真是讽刺，我最喜爱的玩具最终将终结我"},
					{"Let's dance one last time, shall we?","让我们最后再跳一支舞，好吗？"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.SATLA001.SATLA001", "PostDraw", new ()
				{
					{"Let's start with easy one. What is 2+4?\nA. (0!+0!+0!)!\nB. 0001 + 0100\nC. 24","让我们从简单的开始。2+4等于多少？\nA.(0!+0!+0!)!\nB. 0001 + 0100\nC. 24"},
					{"Let's start with easy one. How many equal sides do Icosahedrons have?\nA. 20\nB. 0xFFF\nC. i","让我们从简单的开始。十面体有多少条等边？\nA. 20\nB. 0xFFF\nC. i"},
					{"Let's start with easy one. What is the billionth digit of Pi?\nA. 9\n0xA\nC. 0.5","让我们从简单的开始。π的10亿位数是多少？\nA. 9\nB.0xA\nC. 0.5"},
					{"Let's start with easy one. What is 91 divided by 7?\nA. 169^0.5\nB. 12.33337\nC. 0x192C","让我们从简单的开始。91除以7等于多少?\nA. 根号169\nB. 12.33337\nC. 0x192C"},
					{"Which organ can regenerate naturally from half of itself?\nA. Heart\nB. Brain\nC. Liver","哪个器官可以自己再生?\nA. 心脏\nB. 脑子\nC. 肝脏"},
					{"In which part of the human body do the smallest bones occur?\nA. Leg\nB. Finger\nC. Ear","人体的哪个部位有最小的骨骼?\nA. 腿\nB. 手指\nC. 耳朵"},
					{"Which is the largest organ in human body?\nA. Eye\nB. Lung\nC. Skin","人体最大的器官是什么?\nA. 眼\nB. 肺\nC. 皮肤"},
					{"What is the average lifespan of a red blood cell in human body?\nA. Around 1 day\nB. Around 1 week\nC. Around 120 days","红细胞在人体内的平均寿命是多少?\nA. 大约 1 天\nB. 大约 1 星期\nC. 大约 120 天"},
					{"Which metal have the highest tensile strength?\nA. Titanium\nB. Tungsten\nC. Gold","哪种金属的拉力强度最高?\nA. 钛\nB. 钨\nC. 金"},
					{"What is the percentage of metals in periodic table\nA. 69%\nB. 75%\nC. 80%","元素周期表中金属元素占多少？\nA.69%\nB.75%\nC.80%"},
					{"Which metal is ferromagnetic?\nA. Gold\nB. Iron\nC. Copper","哪种金属是有磁性的?\nA. 金\nB. 铁\nC. 铜"},
					{"Which metal is liquid in room temperature?\nA. Lead\nB. Mercury\nC. Silver","哪种金属在常温下是液态的?\nA. 铅\nB. 汞\nC. 银"},
					{"Which of the component doesn't have a specific region condition?\nA. Resistor\nB. MOSFET\nC. BJT","哪个组件没有特定的工作条件?\nA. 电阻器\nB. 金属氧化物半导体场效应晶体管\nC. 双极结晶体管"},
					{"What is a dual-element fuse is used for?\nA. Operate in higher current\nB. Operate in lower current\nC. Protect the transistor","双元件保险丝的用途是什么?\nA. 在高电流下工作\nB. 在低电流下工作\nC. 保护晶体管"},
					{"What happens when AC voltage is applied to pure resistive circuit?\nA. Current is in phase with voltage\nB. Current leads voltage\nC. Current lags voltage","当交流电压遇到电阻会发生什么?\nA. 电流与电压相一致\nB. 电流引线电压\nC. 电流滞后电压"},
					{"Which instrument below detects electric current?\nA. Galvanometer\nB. Voltmeter\nC. Wattmeter","下面哪个仪器可以检测电流?\nA. 电流计\nB. 电压表\nC. 瓦特计"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.SATLA001.SATLA001", "OnKill", new ()
				{
					{"SYSTEM DAMAGED. CONNECTION TO MLA IS LOST.","系 统 受 损，与 火 星 的 连 接 已 断 开"},
				});
				#endregion AFKPETS.NPCs.SATLA001.SATLA001


				#region AFKPETS.NPCs.RoyalHarpyAirForce.BoundGuardian
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.RoyalHarpyAirForce.BoundGuardian", "SetChatButtons", new ()
				{
					{"Help","帮助"},
				});
				#endregion AFKPETS.NPCs.RoyalHarpyAirForce.BoundGuardian


				#region AFKPETS.NPCs.Misc.RoyalGuard
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.Misc.RoyalGuard", "SetChatButtons", new ()
				{
					{"Shop","商店"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.Misc.RoyalGuard", "OnChatButtonClicked", new ()
				{
					{"Shop","商店"},
				});
				#endregion AFKPETS.NPCs.Misc.RoyalGuard


				#region AFKPETS.NPCs.Misc.TiedYandere
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.Misc.TiedYandere", "SetChatButtons", new ()
				{
					{"Help...?","帮助...？"},
					{"Help","帮助"},
				});
				#endregion AFKPETS.NPCs.Misc.TiedYandere


				#region AFKPETS.NPCs.MiniGameNPCs.GameGenie
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.MiniGameNPCs.GameGenie", "SetChatButtons", new ()
				{
					{"Prize Shop","奖励商店"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.MiniGameNPCs.GameGenie", "OnChatButtonClicked", new ()
				{
					{"Prize Shop","奖励商店"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.MiniGameNPCs.GameGenie", "AddShops", new ()
				{
					{"Prize Shop","奖励商店"},
				});
				#endregion AFKPETS.NPCs.MiniGameNPCs.GameGenie


				#region AFKPETS.NPCs.MiniGameNPCs.HunterDog
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.MiniGameNPCs.HunterDog", "SetChatButtons", new ()
				{
					{"Start the hunt","开始狩猎"},
				});
				#endregion AFKPETS.NPCs.MiniGameNPCs.HunterDog


				#region AFKPETS.NPCs.BiomeNPCs.Assistant
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.BiomeNPCs.Assistant", "SetChatButtons", new ()
				{
					{"Shop","商店"},
					{"Memory Test","记忆测试"},
					{"Start","开始"},
					{"Talk about Minigame","关于小游戏"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.BiomeNPCs.Assistant", "OnChatButtonClicked", new ()
				{
					{"Shop","商店"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.BiomeNPCs.Assistant", "AddShops", new ()
				{
					{"Shop","商店"},
				});
				#endregion AFKPETS.NPCs.BiomeNPCs.Assistant


				#region AFKPETS.NPCs.BiomeNPCs.HolyKnight
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.BiomeNPCs.HolyKnight", "SetChatButtons", new ()
				{
					{"Shop","商店"},
					{"Exchange","交换"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.BiomeNPCs.HolyKnight", "OnChatButtonClicked", new ()
				{
					{"Shop","商店"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.BiomeNPCs.HolyKnight", "AddShops", new ()
				{
					{"Shop","商店"},
				});
				#endregion AFKPETS.NPCs.BiomeNPCs.HolyKnight


				#region AFKPETS.NPCs.Antony.NecromancerDummyNpc
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.Antony.NecromancerDummyNpc", "SetChatButtons", new ()
				{
					{"Start Training","开始训练"},
				});
				#endregion AFKPETS.NPCs.Antony.NecromancerDummyNpc


				#region AFKPETS.Items.AFKPETSGlobalItem
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.AFKPETSGlobalItem", "ModifyTooltips", new ()
				{
					{"Penetration III\nBlast Protection\nEfficiency II","穿透 III\n防爆\n效率II"},
				});
				#endregion AFKPETS.Items.AFKPETSGlobalItem


				#region AFKPETS.Items.Weapons.Melee.Yoyos.Gemstorm
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Weapons.Melee.Yoyos.Gemstorm", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Weapons.Melee.Yoyos.Gemstorm


				#region AFKPETS.Items.Weapons.Melee.TrueMelee.DiamondSword
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Weapons.Melee.TrueMelee.DiamondSword", "ModifyTooltips", new ()
				{
					{"No Random Crit Chance","无暴击率"},
				});
				#endregion AFKPETS.Items.Weapons.Melee.TrueMelee.DiamondSword


				#region AFKPETS.Items.Weapons.Melee.ProjectileMelee.CactusSword
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Weapons.Melee.ProjectileMelee.CactusSword", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Weapons.Melee.ProjectileMelee.CactusSword


				#region AFKPETS.Items.Weapons.Melee.Fists.FistBase
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Weapons.Melee.Fists.FistBase", "ModifyTooltips", new ()
				{
					{"-Crossover Content-","-联动内容-"},
					{"No Random Crit Chance","无暴击率"},
				});
				#endregion AFKPETS.Items.Weapons.Melee.Fists.FistBase


				#region AFKPETS.Items.Weapons.Melee.Bats.KizunasWrath
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Weapons.Melee.Bats.KizunasWrath", "ModifyTooltips", new ()
				{
					{"\nEfficiency ","\n效率"},
					/*{"RC to item to generate pure enegy to use it as trinket\nWhen player press down along with trinket hotkey player will drop all trinkets and else cycle new one with olders\nWhen player is holding trinket by pressing trinket key it can unequip the trinket\n                                                   -Page 2-","右键投出棒球，左键重击；当重击足够多敌人后，玩家进入狂暴状态\n左键消耗棒球作为弹药，空中无棒球时扔出棒球，而有棒球时则向光标方向进行打击\n[c/ffff00:重击能力]: 攻击任何敌人将造成带电效果，并有很小的几率施加羁绊引力\n带有此减益的敌人之间会相互吸引\n如果它们相互碰撞，这种力量将粉碎它们的内脏器官，并增加附近敌人受到的持续伤害\n[c/ffff00:打击能力]: 对所有类型的棒球弹药进行过载充能，改变其外观\n过载充能的棒球弹药会吸引较弱的敌对射弹，并在击中任何敌人时释放链状闪电\n[c/ffff00:狂暴状态]: 武器造成额外 150% 伤害，增加 50% 近战攻速度和 10% 暴击率\n狂暴状态下，玩家的猛击有很高的几率施加羁绊引力，非直接攻击但击杀敌人会治疗玩家并延长狂暴状态        - 第一页 -\n\n收割植物时有很小的几率富集金属，额外产生矿石\n杀死敌人时，有很小的几率收获他们的灵魂\n效率属性将提升此工具用于收割植物和干草时的采集速度\n右键生成羁绊火花\n装备在密藏栏时，玩家可以使用闪电冲刺，1.5 秒冷却时间\n无视射弹，撞击敌人时释放闪电并造成带电效果\n[c/FFC0CB:收纳盒特殊能力]: 重击非Boss敌人造成强力击退，施加羁绊引力\n当玩家按下密藏快捷键时，将卸下所有密藏\n当玩家手持密藏按下密藏快捷键时，可以卸下密藏   - 第二页 -"},*/
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Weapons.Melee.Bats.KizunasWrath


				#region AFKPETS.Items.Weapons.Summoner.StaffoftheSpiritualist
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Weapons.Summoner.StaffoftheSpiritualist", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Weapons.Summoner.StaffoftheSpiritualist


				#region AFKPETS.Items.Weapons.Summoner.Transformation.TransformationBase
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Weapons.Summoner.Transformation.TransformationBase", "ModifyTooltips", new ()
				{
					{" transformation summon ","变身"},
				});
				#endregion AFKPETS.Items.Weapons.Summoner.Transformation.TransformationBase


				#region AFKPETS.Items.Weapons.Summoner.SupporterSouls.MothLamp
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Weapons.Summoner.SupporterSouls.MothLamp", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Weapons.Summoner.SupporterSouls.MothLamp


				#region AFKPETS.Items.Weapons.Summoner.SummonWeapon.ActiveMinionBase
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Weapons.Summoner.SummonWeapon.ActiveMinionBase", "ModifyTooltips", new ()
				{
					{" active summon ","主动"},
				});
				#endregion AFKPETS.Items.Weapons.Summoner.SummonWeapon.ActiveMinionBase


				#region AFKPETS.Items.Weapons.Summoner.SummonWeapon.CaitlinsFaith
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Weapons.Summoner.SummonWeapon.CaitlinsFaith", "AdditionalTooltip", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Weapons.Summoner.SummonWeapon.CaitlinsFaith


				#region AFKPETS.Items.Weapons.Summoner.SummonWeapon.CataclismicMug
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Weapons.Summoner.SummonWeapon.CataclismicMug", "AdditionalTooltip", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Weapons.Summoner.SummonWeapon.CataclismicMug


				#region AFKPETS.Items.Weapons.Summoner.Sentries.DavesRemoteControl
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Weapons.Summoner.Sentries.DavesRemoteControl", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Weapons.Summoner.Sentries.DavesRemoteControl


				#region AFKPETS.Items.Weapons.Summoner.Minion.CorruptedArcStaff
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Weapons.Summoner.Minion.CorruptedArcStaff", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Weapons.Summoner.Minion.CorruptedArcStaff


				#region AFKPETS.Items.Weapons.Summoner.Minion.LifebringerStaff
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Weapons.Summoner.Minion.LifebringerStaff", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Weapons.Summoner.Minion.LifebringerStaff


				#region AFKPETS.Items.Weapons.Ranged.Misc.SadCatMeowmere
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Weapons.Ranged.Misc.SadCatMeowmere", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Weapons.Ranged.Misc.SadCatMeowmere


				#region AFKPETS.Items.Weapons.Ranged.Guns.ForgottenGun
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Weapons.Ranged.Guns.ForgottenGun", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Weapons.Ranged.Guns.ForgottenGun


				#region AFKPETS.Items.Weapons.Ranged.Guns.Redemption
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Weapons.Ranged.Guns.Redemption", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Weapons.Ranged.Guns.Redemption


				#region AFKPETS.Items.Weapons.Explosives.PlantsTerror
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Weapons.Explosives.PlantsTerror", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Weapons.Explosives.PlantsTerror


				#region AFKPETS.Items.Tools.Pickaxes.Fury
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Tools.Pickaxes.Fury", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Tools.Pickaxes.Fury


				#region AFKPETS.Items.Tools.Harvesters.AlchemistSickle
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Tools.Harvesters.AlchemistSickle", "ModifyTooltips", new ()
				{
					{"\nEfficiency ","\n效率"},
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Tools.Harvesters.AlchemistSickle


				#region AFKPETS.Items.Tools.Harvesters.HarvesterBase
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Tools.Harvesters.HarvesterBase", "ModifyTooltips", new ()
				{
					{"\nEfficiency ","\n效率"},
				});
				#endregion AFKPETS.Items.Tools.Harvesters.HarvesterBase


				#region AFKPETS.Items.Vanity.GoldfishMask
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Vanity.GoldfishMask", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Vanity.GoldfishMask


				#region AFKPETS.Items.Trinkets.AFKPetsTrinketSlot
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Trinkets.AFKPetsTrinketSlot", "OnMouseHover", new ()
				{
					{"Trinket","密藏"},
				});
				#endregion AFKPETS.Items.Trinkets.AFKPetsTrinketSlot


				#region AFKPETS.Items.Trinkets.AFKPetsTrinketSlot2
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Trinkets.AFKPetsTrinketSlot2", "OnMouseHover", new ()
				{
					{"Trinket","密藏"},
				});
				#endregion AFKPETS.Items.Trinkets.AFKPetsTrinketSlot2


				#region AFKPETS.Items.Trinkets.TrinketBase
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Trinkets.TrinketBase", "ChangeLine", new ()
				{
					{"[c/008000:Trinket]","[c/008000:密藏]"},
				});
				#endregion AFKPETS.Items.Trinkets.TrinketBase


				#region AFKPETS.Items.Potions.BuffPotions.NullSoup
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Potions.BuffPotions.NullSoup", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Potions.BuffPotions.NullSoup


				#region AFKPETS.Items.Minions.ChaliceofChocolateMilk
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Minions.ChaliceofChocolateMilk", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Minions.ChaliceofChocolateMilk


				#region AFKPETS.Items.Minions.EyeinaGlassJar
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Minions.EyeinaGlassJar", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Minions.EyeinaGlassJar


				#region AFKPETS.Items.Minions.SkullwithWire
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Minions.SkullwithWire", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Minions.SkullwithWire


				#region AFKPETS.Items.FunctionalTiles.FestivePlant
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.FunctionalTiles.FestivePlant", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.FunctionalTiles.FestivePlant


				#region AFKPETS.Items.FunctionalTiles.Misc.CourageStatue
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.FunctionalTiles.Misc.CourageStatue", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.FunctionalTiles.Misc.CourageStatue


				#region AFKPETS.Items.FunctionalTiles.Misc.FallingSlimeStatue
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.FunctionalTiles.Misc.FallingSlimeStatue", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.FunctionalTiles.Misc.FallingSlimeStatue


				#region AFKPETS.Items.FunctionalTiles.Misc.KindnessStatue
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.FunctionalTiles.Misc.KindnessStatue", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.FunctionalTiles.Misc.KindnessStatue


				#region AFKPETS.Items.FunctionalTiles.CraftingStations.FuriousAnvil
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.FunctionalTiles.CraftingStations.FuriousAnvil", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.FunctionalTiles.CraftingStations.FuriousAnvil


				#region AFKPETS.Items.Accessories.AuroraThirdEye
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Accessories.AuroraThirdEye", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Accessories.AuroraThirdEye


				#region AFKPETS.Items.Accessories.Misc.ThirdEye
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Accessories.Misc.ThirdEye", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Accessories.Misc.ThirdEye


				#region AFKPETS.Items.Accessories.Minion.CreeperNecklace
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Accessories.Minion.CreeperNecklace", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Accessories.Minion.CreeperNecklace


				#region AFKPETS.Items.Accessories.Magic.EtherealOffering
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Accessories.Magic.EtherealOffering", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Accessories.Magic.EtherealOffering


				#region AFKPETS.Items.Accessories.Combat.BlueScarab
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Accessories.Combat.BlueScarab", "ModifyTooltips", new ()
				{
					{"-Dedicated Content-","-专属内容-"},
				});
				#endregion AFKPETS.Items.Accessories.Combat.BlueScarab


				#region AFKPETS.Items.Accessories.Combat.SecretFormula
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.Items.Accessories.Combat.SecretFormula", "ModifyTooltips", new ()
				{
					{"Could be obtained from rainbow wheel of fortune\nWheel of fortune could be activated via RC to heart of forest while holding a radiant star\nRadiant star could be obtained from cookie crates secret phase","在命运之轮中获得"},
				});
				#endregion AFKPETS.Items.Accessories.Combat.SecretFormula


			}
		}
	}
}
