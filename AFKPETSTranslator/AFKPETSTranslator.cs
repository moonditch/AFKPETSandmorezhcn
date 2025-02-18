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
				#region AFKPETS.UI.MinesweeperUI
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.UI.MinesweeperUI", "OnInitialize", new ()
				{
					{"-MINESWEEPERS-","-扫    雷-"},
					{"10 Mines Placed","10 个地雷"},
					{"Retry","重置"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.UI.MinesweeperUI", "Update", new ()
				{
					{"Press retry to start again","点击重新开始"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.UI.MinesweeperUI", "click_mine", new ()
				{
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
					{"Level:","阶级："},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.UI.SokobanUI", "Update", new ()
				{
					{" is solved","已完成"},
					{"Congrats you beat all of the levels","恭喜你通关！"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.UI.SokobanUI", "player_move", new ()
				{
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.UI.SokobanUI", "player_position", new ()
				{
				});
				#endregion AFKPETS.UI.SokobanUI


				#region AFKPETS.UI.ThinIceUI
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.UI.ThinIceUI", "OnInitialize", new ()
				{
					{"-THIN ICE-","-薄      冰-"},
					{"Level:","阶级："},
					{"Skill Issue?","技术问题？"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.UI.ThinIceUI", "Update", new ()
				{
					{" is solved","已完成"},
					{"Congrats you beat all of the levels","恭喜你通关！"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.UI.ThinIceUI", "player_move", new ()
				{
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.UI.ThinIceUI", "player_position", new ()
				{
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
				});
				#endregion AFKPETS.NPCs.TravellingNPCs.Elitist


				#region AFKPETS.NPCs.TravellingNPCs.WanderingSamurai
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.TravellingNPCs.WanderingSamurai", "SetChatButtons", new ()
				{
					{"Eastern Shop","车万商店"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.TravellingNPCs.WanderingSamurai", "OnChatButtonClicked", new ()
				{
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
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.TownNPCs.FallenAngel", "AddShops", new ()
				{
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
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.TownNPCs.Yandere", "AddShops", new ()
				{
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
					{"For the game please cancel the answer buff for the answer you think is correct before time out.","请在时间截至前，在左上角增益栏右键取消你认为正确的答案."},
					{"Correct","回答正确"},
					{"Wrong Answer","回答错误"},
					{"Time is up. Have a nice gift","时间到，接受礼物吧"},
					{"It's quite interesting that you answer the questions upon now correct.","真厉害，你现在回答的问题是正确的"},
					{"Even through final question waits, I will reward your efford with a tras- I mean small gift.","即使在最后一个问题等待期间，我也会用一份小礼物来奖励你的努力."},
					{"Time for the great reward and final question","是时候问最后一个问题了"},
					{"W H Y  Y O U  A R E  S T I L L  A L I V E ?","你 为 什 么 还 活 着？"},
					{"It seems I cannot play with you without breaking your resistance first","看来我好像得先粉碎你的抵抗才能跟你一起玩."},
					{"Recharge units, show my hospitality","充能单元，展示我的好客之道."},
					{"I even send Martians false information to make them believe this planet is worthless","我甚至给火星人发送虚假信息，让他们相信这个星球一文不值."},
					{"Because this planet is full of lifeforms to play","因为这个星球上充满了可供玩乐的泰拉人"},
					{"How ironic that the lifeform I played most will bring my end","真是讽刺，我最喜爱的玩具最终将终结我"},
					{"Let's dance one last time, shall we?","让我们最后再跳一支舞，好吗？"},
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.SATLA001.SATLA001", "PostDraw", new ()
				{
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
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.MiniGameNPCs.GameGenie", "AddShops", new ()
				{
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
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.BiomeNPCs.Assistant", "AddShops", new ()
				{
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
				});
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.BiomeNPCs.HolyKnight", "AddShops", new ()
				{
				});
				#endregion AFKPETS.NPCs.BiomeNPCs.HolyKnight


				#region AFKPETS.NPCs.Antony.NecromancerDummyNpc
				TranslatorLoad.LocalizeByTypeFullName("AFKPETS.NPCs.Antony.NecromancerDummyNpc", "SetChatButtons", new ()
				{
					{"Start Training","开始训练"},
				});
				#endregion AFKPETS.NPCs.Antony.NecromancerDummyNpc


			}
		}
	}
}
