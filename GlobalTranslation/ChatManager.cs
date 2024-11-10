using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.ModLoader;
using Terraria.UI.Chat;

namespace AFKPETSandmorezhcn.GlobalTranslation
{
	public class ChatManager : ModSystem
	{
		//此文件内的翻译不包含CombatText
		public override void Load()
		{
			On_ChatManager.ParseMessage += Translate;
		}
        public override void Unload()
		{
			On_ChatManager.ParseMessage -= Translate;
		}
		private static List<TextSnippet> Translate(On_ChatManager.orig_ParseMessage orig, string text, Color baseColor)
		{
			foreach (var kvp in ChatManagerText)
			{
				text = text.Replace(kvp.Key, kvp.Value);
			}
			return orig.Invoke(text, baseColor);
		}
		private static readonly Dictionary<string, string> ChatManagerText = new()
		{
			/*
			{"ORIGIN TEXT", "翻译的文字"},
			{"", ""},
			{"", ""},
			{"", ""},
			{"", ""},
			{"", ""},
			{"", ""},
			{"", ""},
			{"", ""},
			{"", ""},
			{"", ""},
			{"", ""},
			{"", ""},
			{"", ""},
			{"", ""},
			{"", ""},
			*/
			//街机游戏UI
			{"MINIGAMES", "迷 你 小 游 戏"},
			{"Sokoban", "推箱子"},
			{"SOKOBAN", "推 箱 子"},
			{"Minesweepers", "扫雷"},
			{"MINESWEEPERS", "扫 雷"},
			{"Thin Ice", "薄冰"},
			{"THIN ICE", "薄 冰"},
			{"Skill Issue", "重置"},
			{" Mines Placed", "个地雷"},
			{"Sorry, you press to the mine", "不好意思你按到地雷了"},
			{"Congrats you find all of the mines", "恭喜你找到了所有的地雷"},
			{"Press retry to start again", "按重新开始重新开始"},
			{"Retry", "重置"},
			{"Start Playing", "开始游戏"},
			{"Level", "关卡"},
			{" is solved", " 已完成"},

			#region NPC对话按钮
			//游戏精灵
			{"Prize Shop", "奖励商店"},
			//猎犬
			{"Start the hunt", "开始狩猎"},
			//流浪武士
			{"Eastern Shop", "车万商店"},
			//艺术家
			{"Art Shop", "艺术商店"},
			//坠落天使
			{"Angelic Shop", "天使商店"},
			//设计师
			{"Vanity Shop", "外观商店"},
			{"Help Her", "帮助她"},
			//研究员
			{"Research Shop", "研究员商店"},
			{"Fix Weapon", "修理武器"},
			//Boss狩猎商人
			{"Base Shop", "基础商店"},
			{"Reward Shop", "奖励商店"},
			{"Next Boss", "下个Boss"},
			{"Give Trophy", "给予纪念章"},
			{"Change Option Type", "更改选项类型"},
			//死灵傀儡法师
			{"Start Training", "开始训练"},
			//水族智者
			{"Start the Challenge", "开始挑战"},
			//幽灵陶伊
			{"Start Trivia", "冷知识开始"},
			//神圣骑士，艺术家
			{"Exchange", "交换"},
			//刺客
			{"Weapon Imbue Fear Toxin", "武器灌注恐惧毒素"},
			//神圣骑士，黑暗女猎手，皇家卫士，刺客
			{"Shop", "商店"},
			#endregion
			

			#region Boss聊天语句
			//死灵傀儡法师
			{"Since contact is obvious I mostly want to talk about two specific magic attacks", "由于接触是显而易见的，我主要想谈谈两个具体的魔法攻击"},
			{"While magic can be used to bring happiness and welfare, it also have a dark side", "虽然魔法可以带来快乐和幸福，但它也有黑暗的一面"},
			{"So it would be nice if we test your dodging skills", "所以最好测试一下你的闪避技巧"},
			{"Could you dodge the upcoming attack", "你能闪避即将到来的攻击吗我们能不能先友好地决斗一下"},
			{"For next attack could you not move", "下次进攻可以不移动吗"},
			{"For next attack could you continuously move", "下次进攻可以连续移动吗"},
			{"I guess this much knowledge is enough for today", "我想今天讲这么多就可以了"},
			{"What, I have never fight with anyone but if you think it will be helpful", "什么，我从来没有和其他人打架过，但你认为这对你有帮助的话"},
			{"What is happening", "发生了什么"},
			{"Human please help me, it hurts", "人类，请帮帮我，很疼"},
			{"I feel like something ripping apart", "我好像有什么东西要裂开了"},
			{"That look on your face", "你脸上的表情"},
			{"Do you really wish this", "你真的希望这样吗"},
			{"I only want to help you", "我只是想帮你"},
			{"Could we make a friendly duel before we stop", "我们能不能先友好地决斗一下"},

			//恶魔杀手
			{"-Secret Art- Wind of Justice", "-秘密艺术-正义之风"},
			{"You feel now you can help the tied dark huntress without any problem", "现在你可以直接地帮助束缚黑暗女猎手"},
			{"Why did you kill that Dryad", "你为什么要杀那个树妖"},
			{"They are so kind to every creature around them", "她对周围的每一个人都很好"},
			{"Maybe it's time for cleaning this world from one more bandit", "也许是时候让我让这个世界再少一个邪恶了"},

			//盘子女鬼
			{"Even rats are more useful than you, Akiko", "老鼠都比你有用，明子"},
			{"AKIKO BREAK THE PLATE, SHE IS THE CUILT", "明子 打 碎 了 盘 子，她 是 祭 品"},
			{"Akiko, how you menage to be good at nothing", "明子，你就是废物"},
			{"You greedy pig, isn't half bowl is enough for you Akiko", "你这贪吃的猪，明子，半碗还不够你吃吗"},
			{"You will sleep outside Akiko, you have on worth here", "你睡外面，明子，你在这里没有价值"},

			//皇家风暴鸟号
			{"Collect clear air bubbles to survive", "请收集干净的气泡存活"},
			{"Brother, we have a problem here", "兄弟，我们有麻烦了"},
			{"Storm Diver roger, target locked", "风暴潜水员收到，目标锁定"},
			{"Sister you look hurt", "妹妹，你看起来受伤了"},
			{"Retreat to the distance and recover", "先退到远处然后恢复"},
			{"Now this is personal", "这是我个人问题"},
			{"I no longer care for ethics", "我不再需要道德底线了"},
			{"Look at my face and keep that hook away. I have a surprise for you", "看着我的脸，把武器拿开，我有惊喜要给你"},
			//（无法读写）{"Other Harpies find me childish and idiotic but you've shown me ture care", "其他鹰身女妖觉得我幼稚愚蠢但你给了我真正的关心"},
			{"Use Movement Keys to Pop Bubbles", "使用移动键击碎气泡"},			
			{"Thank you for shining as a summer sun in my foolish life, brother", "感谢你在我愚蠢的生命中像夏日的太阳照耀着我，兄弟"},

			//不死厨师
			{"Go away, I'm busy with choosing the dessert", "走开，我正忙着选甜点呢"},
			{"How you even manage to burn down such a beauty", "你是怎么烧出这么好的东西的"},
			{"let me show our hospitality", "让我来表示我们的热情"},

			//史莱姆复仇联盟
			{"Let's beat", "朋友们"},
			{"this murderer", "让我们一起"},
			{"together friends", "杀死这个杀人犯"},
			{"I will hide our aura", "我会隐藏我们的气味"},
			{"Shadow Clone Jutsu", "影分身の術"},
			{"How you kill him you heartless monster", "你怎么把他杀了，你这个无情的怪物"},
			{"Time for the shinobi execution", "是时候处决你了"},
			{"Oh no, Shogun slime please don't left us", "不，幕府将军，请不要离开我们"},
			{"You...Let's finish this in Danmaku style", "你……让我们用这种状态谢幕"},
			{"FRIENDS CANNOT FOUND. SADNESS MODULE ACTIVATED.", "朋 友 不 见 了，悲 伤 模 式 激 活."},
			{"ENRAGEMEND PROTOCOL ACTIVATED", "暴 怒 模 式 激 活."},
			{"She couldn't manage to protect her bodys density", "她无法保护自己的身体"},

			//冰之守护者
			{"I'm sorry human but I cannot let ice elementals extinct one more time", "很抱歉，人类，但我不能让冰元素灭绝了"},
			{"You may kill me but please don't hurt my little sister", "你可以杀了我，但请不要伤害我的妹妹"},
			{"She may be a little wild but she have a heart of gold", "她也许有点野，但她有一颗善良的心"},
			{"I feel my primal instincts start to take control over my mind", "我的原始本能开始控制我的思想"},
			{"I'm sorry for things that happen next", "接下来发生的事我很抱歉"},
			{"Primal instincts start to take control of his mind", "原始本能开始控制他的思想"},

			//史莱姆二阶段
			{"I have been given flesh by all lifeforms horrors, To be your tormentor", "我被所有生命形式的恐怖思想赋予肉体，把你作为折磨者"},
			{"Your end is nigh", "你的末日即将来临"},
			
			//SATLA-001
			{"No need to escape while we are having fun together", "我们在一起玩的时候，没必要逃跑"},
			{"Hello there. Thank you for your kindness to invite me.", "你好，谢谢你盛情邀请我"},
			{"Before I give you your reward shall we play a nice game", "在我给你奖励之前，我们玩个游戏可以吗"},
			{"For the game please cancel the answer buff for the answer you think is correct before time out.", "请在时间截至前，在左上角增益栏右键取消你认为正确的答案"},
			{"Wrong Answer", "回答错误"},
			{"Correct", "回答正确"},
			{"Time is up. Have a nice gift", "时间到，接受礼物吧"},
			{"It's quite interesting that you answer the questions upon now correct.", "非常有趣的是，你现在回答的问题是正确的"},
			{"Even through final question waits, I will reward your efford with a tras- I mean small gift.", "即使在最后一个问题等待期间，我也会用一份小礼物来奖励你的努力"},
			{"W H Y  Y O U  A R E  S T I L L  A L I V E ?", "你 为 什 么 还 活 着？"},
			{"It seems I cannot play with you without breaking your resistance first", "看来我好像得先粉碎你的抵抗才能跟你一起玩"},
			{"Recharge units, show my hospitality", "充能单元，展示我的好客之道"},
			{"I even send Martians false information to make them believe this planet is worthless", "我甚至给火星人发送虚假信息，让他们相信这个星球一文不值"},
			{"Because this planet is full of lifeforms to play", "因为这个星球上充满了可供玩乐的泰拉人"},
			{"How ironic that the lifeform I played most will bring my end", "真是讽刺，我最喜爱的玩具最终将终结我"},
			{"Let's dance one last time, shall we", "让我们最后再跳一支舞，好吗"},
			{"SYSTEM DAMAGED. CONNECTION TO MLA IS LOST.", "系统受损，与火星的连接已断开"},

			{"Let's start with easy one", "让我们从简单的开始"},
			{"Time for the great reward and final question", "是时候问最后一个问题了"},
			{"What is 91 divided by 7?\nA. 169^0.5\nB. 12.33337\nC. 0x192C", "91除以7等于多少?\nA. 根号169\nB. 12.33337\nC. 0x192C"},
			{"What is 2+4", "2加4等于多少"},
			{"What is the billionth digit of pi", "π的10亿位数是多少"},
			{"How many equal sides do Icosahedrons have", "十面体有多少条等边"},

			{"Which organ can regenerate naturally from half of itself?\nA. Heart\nB. Brain\nC. Liver", "哪个器官可以自己再生?\nA. 心脏\nB. 脑子\nC. 肝脏"},
			{"In which part of the human body do the smallest bones occur?\nA. Leg\nB. Finger\nC. Ear", "人体的哪个部位有最小的骨骼?\nA. 腿\nB. 手指\nC. 耳朵"},
			{"Which is the largest organ in human body?\nA. Eye\nB. Lung\nC. Skin", "人体最大的器官是什么?\nA. 眼\nB. 肺\nC. 皮肤"},
			{"What is the average lifespan of a red blood cell in human body?\nA. Around 1 day\nB. Around 1 week\nC. Around 120 days", "红细胞在人体内的平均寿命是多少?\nA. 大约 1 天\nB. 大约 1 星期\nC. 大约 120 天"},

			{"Which metal have the highest tensile strength?\nA. Titanium\nB. Tungsten\nC. Gold", "哪种金属的拉力强度最高?\nA. 钛\nB. 钨\nC. 金"},
			{"What is the percentage of metals in periodic table", "元素周期表中金属元素占多少"},
			{"Which metal is ferromagnetic?\nA. Gold\nB. Iron\nC. Copper", "哪种金属是有磁性的?\nA. 金\nB. 铁\nC. 铜"},
			{"Which metal is liquid in room temperature?\nA. Lead\nB. Mercury\nC. Silver", "哪种金属在常温下是液态的?\nA. 铅\nB. 汞\nC. 银"},

			{"Which of the component doesn't have a specific region condition?\nA. Resistor\nB. MOSFET\nC. BJT", "哪个组件没有特定的工作条件?\nA. 电阻器\nB. 金属氧化物半导体场效应晶体管\nC. 双极结晶体管"},
			{"What is a dual-element fuse is used for?\nA. Operate in higher current\nB. Operate in lower current\nC. Protect the transistor", "双元件保险丝的用途是什么?\nA. 在高电流下工作\nB. 在低电流下工作\nC. 保护晶体管"}, 
			{"What happens when AC voltage is applied to pure resistive circuit?\nA. Current is in phase with voltage\nB. Current leads voltage\nC. Current lags voltage", "当交流电压遇到电阻会发生什么?\nA. 电流与电压相一致\nB. 电流引线电压\nC. 电流滞后电压"},
			{"Which instrument below detects electric current?\nA. Galvanometer\nB. Voltmeter\nC. Wattmeter", "下面哪个仪器可以检测电流?\nA. 电流计\nB. 电压表\nC. 瓦特计"},
			#endregion

			//npc击败并离开这个世界
			//死灵傀儡法师
			{"Antony's spirit find a way to escape", "安东尼的灵魂找到了逃跑的路线"},

			//恶魔杀手
			{"It seems chemicals leaked from his jetpack burn him alive", "喷气背包泄露的化学物质似乎把他活活烧死了"},

			//盘子女鬼
			{"Scarlet nights are fueled with her blood", "猩红之夜沾染上了她的血液"},

			//以撒
			{"Isaac start to see the bigger picture and remeber the souls warn", "以撒开始看到更大的世界并记住灵魂的警告"},
			{"He reject the heavens to take his friend back, NOW", "现在他正在拒绝上天接纳他的朋友"},
			{"As he rejected above for seeing his friend again", "因为他拒绝上天接纳他的朋友"},
			{"Below awaits until he is being forgiven", "在火湖等待着被他宽恕"},

			//皇家鸟妖风暴号
			{"Brother...NO", "哥哥...不"},
			{"Please don't leave me alone", "请不要丢下我一个人"},
			{"It hurts...but that's ok...I will see brother again instead of being alone", "这让我很伤心……不过没关系……我将再次见到哥哥，而不是自己一个"},
			{"Thank you human...For ending my life...Rather than ending my honor", "谢谢你，人类……为了结束我的生命…而不是结束荣誉"},
			{"This is the end...Sister...I'll be there soon", "这就结束了……妹妹……我马上就到"},
			{"A man that cannot protect his family...Has no right to live...", "一个不能保护家人的我…没有生存的权利..."},

			//胎儿博士
			{"Dr Fetus start to get serious", "胎儿博士开始变得严肃起来"},
			{"It's now defenseless", "它现在毫无防备"}
		};
	}
}