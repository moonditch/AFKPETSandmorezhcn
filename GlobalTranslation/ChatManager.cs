using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI.Chat;
using AFKPETS.NPCs.TravellingNPCs;

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
			int BountyHunter = NPC.FindFirstNPC(ModContent.NPCType<BountyHunter>());
			foreach (var kvp in ChatManagerText)
			{
				text = text.Replace(kvp.Key, kvp.Value);
			}
			return orig.Invoke(text, baseColor);
		}
		private static readonly Dictionary<string, string> ChatManagerText = new()
		{
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
			{"You can share your heart with me", "你可以和我说说心里话"},
			{"Help Her", "帮助她"},
			//助教
			{"Memory Test", "记忆测试"},
			{"Start", "开始"},
			{"Talk about Minigame", "关于小游戏"},
			//研究员
			{"Research Shop", "研究员商店"},
			{"Fix Weapon", "修理武器"},
			//Boss狩猎商人
			{"Base Shop", "基础商店"},
			{"Reward Shop", "奖励商店"},
			{"Next Boss", "下个Boss"},
			{"Give Trophy", "给予纪念章"},
			{"Boss Bag Shop", "宝藏袋商店"},
			{"Change Option Type", "更改选项类型"},
			//赏金猎人
			{"Quest", "任务"},
			//死灵傀儡法师
			{"Start Training", "开始训练"},
			//水族智者
			{"Start the Challenge", "开始挑战"},
			//幽灵陶伊
			{"Start Trivia", "冷知识问答开始"},
			//神圣骑士，艺术家
			{"Exchange", "交换"},
			//刺客
			{"Weapon Imbue Fear Toxin", "武器灌注恐惧毒素"},
			//黑暗女猎手，受缚人质
			{"Help", "帮助"},
			{"Give Her Letter", "给她情书"},
			{"Give Her Bride Costume", "给她婚裙和面纱"},
			{"Give Her Both Your Heart and Ring", "将镌刻爱的戒指给她"},
			//安全机器人
			{"You are an Idiot", "你是个笨蛋"},
			//神圣骑士，黑暗女猎手，皇家卫士，刺客
			{"Shop", "商店"},
			#endregion
			
			#region 模组指令
			//AnswerCommand
			{"Player give answer as", "玩家回答"},
			//BossLifeAdjustCommand
			{"Boss life have been adjusted", "Boss生命值已调整"},
			//FunActivateCommand
			{"The air is filled with [c/ffff00:fun]", "空气中充满了[c/ffff00:趣味]的气氛"},
			{"You feel they return back to normal", "你感到有些事物离去了"},
			{"You feel something went wrong", "你感到刚才的指令不对劲"},
			//幻影镜
			//FirstFrameAdjustCommand
			{"First frame have been adjusted", "起始帧已调整"},
			//LastFrameAdjustCommand
			{"Last frame have been adjusted", "结束帧已调整"},
			//WikiSearchWikiCommand
			{"Wiki have been adjusted to", "Wiki 已切换"},
			//WikiSearchWordCommand
			{"Search word have been adjusted to", "检索词已切换"},
			//NPCNameChangeCommand
			{"New have been adjusted to", "新名字是"},
			#endregion
			
			#region NPC离开
			//设计师
			{" return back to her home", "回到了她家"},
			//艺术家
			{" return back to her kingdom", "回到了她的王国"},
			//流浪武士
			{" return back to her clan", "回到了他的氏族"},
			//赏金猎人
			{" return back", "离开了"},
			#endregion

			#region 史莱姆军队入侵事件
			{"Slime troops commander engages in war for their honor", "史莱姆军团指挥官为荣誉而战"},
			{"You may escape judgement,", "你或许能逃脱审判"},
			{"yet the souls of the very lives you've ruined", "但你杀死的那些无辜生命的灵魂，"},
			{"will come and cease your existance.", "将会前来终结你的存在！"},
			{"Slime troop start to retreat with their loss", "史莱姆军团在损失惨重后开始撤退"},
			#endregion

			#region Boss语句
			//死灵傀儡法师
			{"Since contact is obvious I mostly want to talk about two specific magic attacks", "由于接触是显而易见的，我主要想谈谈两个具体的魔法攻击"},
			{"While magic can be used to bring happiness and welfare, it also have a dark side", "虽然魔法可以带来快乐和幸福，但它也有黑暗的一面"},
			{"So it would be nice if we test your dodging skills", "所以最好测试一下你的闪避技巧"},
			{"For next attack could you not move", "可以不闪避"},
			{"For next attack could you continuously move", "能躲开我的下次攻击吗"},
			{"Hmm, other attack types are obvious so no need for showing", "嗯，其它类型的攻击很明显，所以不需要演示了"},
			{"I guess this much knowledge is enough for today", "我想今天讲这么多就可以了"},
			{"What, I have never fight with anyone but if you think it will be helpful", "什么，我从来没有和其他人打架过，但你认为这对你有帮助的话"},
			{"Then let's get started", "让我们开始吧"},
			{"Could we make a friendly duel before we stop", "我们的战斗最好点到为止"},
			{"Blank card vibrates with released magical essense", "空白塔罗牌随着魔法精华的释放而颤动"},
			{"I'm so sorry. You are really going to die", "我很抱歉，你真的要死了"},
			{"I hope you are better now. I feel we should stop now.", "我希望你现在感觉好些了，我觉得我们应该到此为止了"},
			{"Please be safe and have a great night.", "请保重，祝你今晚过得愉快"},

			//恶魔杀手
			{"-Secret Art- Wind of Justice", "-正义必杀技- 龙卷风摧毁停车场！"},
			{"You feel now you can help the tied dark huntress without any problem", "现在你可以帮助受缚黑暗女猎手了"},
			{"Why did you kill that Dryad? They are so kind to every creature around them", "你为什么要杀那个树妖?她对周围的每一个人都很好"},
			{"Maybe it's time for cleaning this world from one more bandit", "也许是时候让我让这个世界再少一个邪恶了"},

			//盘子女鬼
			{"Even rats are more useful than you, Akiko", "老鼠都比你有用，明子"},
			{"AKIKO BREAK THE PLATE, SHE IS THE CUILT", "明子 打 碎 了 盘 子，她 是 祭 品"},
			{"Akiko, how you menage to be good at nothing", "明子，你就是废物"},
			{"You greedy pig, isn't half bowl is enough for you Akiko", "你这贪吃的猪，明子，半碗还不够你吃吗"},
			{"You will sleep outside Akiko, you have on worth here", "你睡外面，明子，你在这里没有价值"},

			//皇家风暴鸟号
			{"Collect clear air bubbles to survive", "请触碰干净的气泡以存活"},
			{"Use hook to pass this wind by hooking to a tile in other side", "使用钩爪来度过强风"},
			{"Use hook or block to immobilize yourself until wind stops", "使用钩爪或物块来阻挡强风"},
			{"Brother, we have a problem here", "哥哥，我们有麻烦了"},
			{"Storm Diver roger, target locked", "皇家鸟妖风暴号收到，目标锁定"},
			{"Sister you look hurt! Retreat to the distance and recover", "妹妹，你看起来受伤了！先退到远处然后重整旗鼓"},
			{"Now this is personal! I no longer care for ethics!", "现在这是私人恩怨了！我不再顾及道德底线了"},
			{"Look at my face and keep that hook away. I have a surprise for you", "看着我的脸，把武器拿开，我有惊喜要给你"},
			{"I hate umbrellas! Who even decided to make a storm proof umbrella...NEVER let Moths do research...", "我讨厌雨伞！到底是谁想出了制造防风防雨伞这种鬼点子……千万别让那些不靠谱的人去做研究啊	..."},
			{"Use Movement Keys to Pop Bubbles", "使用移动键击碎气泡"},
			{"Thank you for shining as a summer sun in my foolish life, brother", "感谢你在我愚蠢的生命中像夏日的太阳照耀着我，哥哥"},
			{"Fascinating technology, Lobsters and Moths intellgence is truely stunning", "迷人的技术，龙虾和飞蛾的智力真是令人惊叹"},
			{"Whoever thought winds could be manipulated by satellites or umbrellas", "谁会想到风能被卫星或雨伞所操控"},
			{"Brother your plane looks damaged, Retreat and repair, I'll cover you!", "兄弟，你的飞机看起来受损了，撤退并修理，我来掩护你！"},
			{"HARPIES LET US FINISH THIS!", "鹰身女妖们，让我们结束这一切！"},
			//皇家风暴鸟号-人质
			{"The trap on hostage activated", "人质身上的炸弹已启动"},
			{"The hostage was slain...", "人质被杀害了..."},

			//魂幡守望者
			{"Lepus have accepted the challenge", "天兔接受了挑战"},
			{"Turkor strikes with the heat", "火鸡以炽热之力发动攻击"},
			{"Ocram fuels the night with horror", "奥库瑞姆用恐怖为夜晚增添色彩"},
			{"Flag Carrier is now defenseless", "魂幡守望者现在毫无防备"},
			{"The air smells like bravery as another challenger rises", "空气中弥漫着勇敢的气息，又一位挑战者挺身而出"},
			{"Without knowing what awaits it in future or does it even have one", "它不知道未来等待着它的是什么，甚至不知道是否有未来"},
			{"Still this deal sealed with losers blood have accepted by the elder ones", "然而，这个以败者之血为誓的约定已被旧日守望者们接受"},
			{"As one fall the remains get enraged with the arrogance of the challenger", "当一人倒下时，其余的会因挑战者的傲慢而愤怒"},
			{"Let this bloodshed continue until one side falls", "让这场血战继续，直到一方倒下"},
			{"Winds bring the rotten smell of the remnant of fallen", "风带来了倒下者遗骸的腐烂气味"},
			{"The end is night as there will be only one survivor left", "黑夜是战斗的结局，因为最后只会留下一个幸存者"},
			{"As elders said sun will rise after the darkest of night", "如守望者们所说，最黑暗的夜晚之后太阳会升起"},
			{"Without story the storyteller will have no importance so finish the job", "如果没有故事，讲故事的人就没有意义，所以完成你的任务吧"},
			{"My universe already fell into darkness so this will only make me rest my soul", "我的世界已经陷入了黑暗，所以这将只会让我的灵魂安息"},
			{"Lepus have been defeated", "天兔已被击败"},
			{"Turkor the Ungrateful have been defeated", "不感恩的火鸡已被击败"},
			
			//不死厨师
			{"Go away, I'm busy with choosing the dessert", "走开，我正忙着选甜点呢"},
			{"Wait, this smell...", "等等，这个味道..."},
			{"How you even manage to burn down such a beauty", "你是怎么烧出这么好的东西的"},
			{"Wait, I feel I find the last ingredient for soup", "等等，我想我找到汤的最后一味材料了"},
			{"Wait, you are a human... What you are doing here?", "等等，你这泰拉人来这里干什么？"},
			{"let me show our hospitality", "让我来表示我们的热情"},
			{"I think pressure\ufffds healthy, let's see if you can handle it", "我认为压力是有益的，让我看看你能承受多少"},

			//英勇史莱姆
			{"If you kill the light only darkness remain...", "如果你熄灭了光，只剩下黑暗..."},
			{"I can see where this ends, human", "泰拉人，我对这个结局早有预料"},
			{"I choose dying with my honor", "我选择带着荣誉而死"},

			//史莱姆复仇联盟
			{"Shadow Clone Jutsu", "影分身の術"},
			{"How you kill him you heartless monster", "你怎么把他杀了，你这个无情的怪物"},
			{"Time for the shinobi execution", "是时候处决你了"},
			{"Oh no, Shogun slime please don't left us", "不，忍者史莱姆，请不要离开我们"},
			{"You...Let's finish this in Danmaku style", "你...让我们用这种方式谢幕吧"},
			//机械史莱姆
			{"FRIENDS CANNOT FOUND. SADNESS MODULE ACTIVATED.", "朋 友 不 见 了，悲 伤 模 式 激 活."},
			{"ENRAGEMEND PROTOCOL ACTIVATED", "暴 怒 模 式 激 活."},
			{"LAST STAND PROTOCOL ACTIVATED", "最后防线协议已启动"},
			{"She couldn't manage to protect her bodys density", "她无法承受自己身体的超载"},

			//远古守护者
			{"You start to feel your presense is disturbing someone", "你开始感到自己惊扰了某个存在"},
			{"They say ignorance is bliss but they forget to count the corpses", "人们说无知是福，但他们却忘记了计算那些尸体"},
			{"One may fall but many will stand", "一个人可能会倒下，但更多人会站起来"},
			{"Everything become white and black after he go", "他走后，一切都变得黑白分明"},
			{"But I know one day he will return and pat my head like good old times", "但我知道有一天他会回来，像从前那样拍拍我的头"},
			{"Every new become old and alive become dead", "新事物终将变老，活物终将死亡"},
			{"Maybe it's time for me to rest and watch the beatuiful sunset with my lord", "也许是时候让我休息了，和我的主人一起欣赏美丽的日落"},

			//冰之守护者
			{"Please forgive me but if I have chance I will not kill you", "请原谅我，但如果我有机会，我不会杀你"},
			{"I feel my primal instincts start to take control over my mind", "我的原始本能开始控制我的思想"},
			{"I'm sorry for things that happen next", "接下来发生的事我很抱歉"},
			{"Couldn't we just stop and drink some hot chocolate", "我们就不能停下来喝杯热巧克力，好好谈谈吗？"},
			{"Looking at your face it seems the answer is no", "看你的表情，答案似乎是否定的"},
			{"You may kill me but please don't hurt my little sister", "你可以杀了我，但请不要伤害我的妹妹"},
			{"She may be a little wild but she have a heart of gold", "她也许有点野，但她有一颗善良的心"},
			{"I'm sorry human but I cannot let ice elementals extinct one more time", "很抱歉，人类，但我不能让冰元素再次灭绝了"},
			{"Primal instincts start to take control of his mind", "原始本能开始控制他的思想"},

			//梦魇史莱姆
			{"I have been given flesh by all lifeforms horrors, To be your tormentor", "我被所有生命形式的恐怖思想赋予肉体，把你作为折磨者"},
			{"Your end is nigh", "你的末日即将来临"},
			{"Don't worry, You shall learn fear from your own kinds monstrosity!", "别担心，你会恐惧你曾带给我们族人的梦魇的！"},
			{"-Nightmare Art- Bloodbath in Bucha", "-噩梦妙法- 布恰的血腥屠杀"},
			{"Do you think you can escape from your nightmares?", "你以为你能从你的噩梦中逃脱吗？"},
			{"The very dreams you've crumbled have come to cleanse your impure soul", "你曾经摧毁的梦想现在来净化你肮脏的灵魂"},
			{"Do you think your nightmares will die?", "你以为你的噩梦会消失吗？"},
			{"You cannot escape from your shadow", "你无法逃脱你的阴影"},
			{"Fighting will only cause you to die tired", "战斗只会让你疲惫而死"},
			{"You won't get tired of dying, will you?", "你不会厌倦死亡的，对吧？"},
			{"I wonder what you taste like?", "我想知道你尝起来是什么味道？"},
			{"Don't be afraid, Nothing will be left of you", "别害怕，你什么都不会剩下"},
			{"The light can't save you now", "现在光明无法拯救你"},
			{"Lets see how many times you can be pulled apart", "让我们看看你能被撕裂多少次"},
			{"I'm here to claim your worthless flesh", "我来这里是要夺走你那毫无价值的肉体"},
			{"All shall learn to fear me", "所有人都将学会害怕我"},
			{"This nightmare is just beginning", "这个噩梦才刚刚开始"},
			{"It will all be over soon", "一切很快就会结束"},
			{"Your head would be nice for my collection", "你的项上人头会是我收藏的好东西"},
			{"You know what you have done...", "你知道你做了什么..."},
			{"Lets count how many bones you have by ripping them out", "让我们拔出你的骨头来数一数有多少根"},
			{"You're hungry? Don't worry I'll feed you with your own organs", "你饿了吗？别担心，我会用你自己的身体来喂你"},
			{"Why so serious, Stress only makes your flesh lose its taste", "为什么这么紧张，压力只会让你的肉失去味道"},
			{"I really should stop playing with my meals", "我真的应该停止玩弄我的食物了"},

			//史莱姆总统
			{"Finally, the military take my signal", "终于，军队接收到了我的信号"},
			{"Bodyguard, clean this mess for me", "保镖，替我解决这个麻烦"},
			{"I keep my emotions away but look how you massacred my boys\nNow this is personal", "我一直保持着冷静，但看看你们是如何屠杀我的兄弟的\n现在，这已经是私仇了"},
			{"-Fehu Sign- The Wealth of the Slime Nations", "-费乌之符- 史莱姆王国的财富"},
			{"Your slaughters show your true characteristics.", "你的屠杀暴露了你的真实面目"},
			{"Now, it's time to deport you... from life.", "现在，是时候把你从这里中驱逐出去了..."},
			{"This armor, made by the finest blacksmiths of the slime kingdom...", "这件机甲，是由史莱姆王国的顶尖铁匠打造的..."},
			{"Let me show you its potential.", "让我来展示它的潜力"},
			{"Do you think I will die after my armor break?", "你以为我的机甲破碎后我就会死吗？"},
			{"Guardian of the Slime Nation have been defeated", "史莱姆王国的守护者已被击败"},

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

			//安全机器人
			{"-Cyber Art- Old Machines Perspective", "-赛博技术- 老旧机器的视角"},
			{"TARGETS OPTIC RECEIVERS ARE DETECTED", "光学接收器已被探测到目标"},
			{"DARK MATTER CANISTER IS READY", "暗物质容器已就绪"},
			{"RELEASING THE QUARANTINE...", "正在解除隔离..."},
			{"-Cyber Art- Deceptive Jammer", "-赛博技术- 欺骗性干扰器"},
			{"INEFFICIENT MUST BE REPLACED TO OPEN PLACE FOR BETTER", "低效的必须被替换，以为更好的留下空间"},
			{"FREE FULL HEALING", "免费治疗生命值"},
			{"BREAK THE BOSS SHIELD", "打破Boss护盾"},
			{"YOU GOT 1 MAIL", "你收到一封邮件"},
			{"FREE DISCORD NITRO", "免费的Steam余额"},
			{"PRESS HERE TO FIX YOUR SKILL ISSUE", "点击这里解决你的技术问题"},
			{"LEARN WHAT DRYAD DOES WHILE SHE IS ALONE", "了解树妖独处时都在做什么"},
			{"RC TO GET ME AS YOUR COMPANION", "右键让我成为你的同伴"},
			{"RC TO BYPASS SECURITY BOTS LAST PHASE", "右键绕过安全机器人的最后阶段"},
			{"CLICK ON ME FOR DEAL", "点击此处进行交易"},
			{"Security Bot has been defeated!!!", "安全机器人已被击败！！！"},
			{"By RC to it player could open its panel to defuse the bot", "右键打开机器人的面板以解除其武装"},
			{"FAREWELL ADMIN...", "管理员，再见..."},
			//FakeSBBag
			{"OLDEST TRICK IN THE BOOK! USE THEIR GREED AGAIST THEMSELVES", "此乃陈年旧计！以其贪念，反噬其身"},

			//猫猫头
			{"I expect no less from a hunter like you", "从你的身份来看，一个像你这样的猎人，我并不感到意外"},
			{"You even kill my student, I can't let you go away", "你竟然杀害了我的门徒，我不能让你就这样离开"},
			{"It's not over yet", "还没结束"},
			{"I.. At least I will die with my honor", "我...至少我会带着我的荣誉死去"},
			#endregion

			#region Boss被击败
			//死灵傀儡法师
			{"What is happening?Human please help me, it hurts", "发生了什么?泰拉人，请帮帮我，很疼"},
			{"I feel like something ripping apart", "我感到好像有什么东西要裂开了"},
			{"That look on your face... Do you really wish this? I only want to help you", "你脸上的表情...你真的希望这样吗?我只是想帮你"},
			{"Antony's spirit find a way to escape", "安东尼的灵魂得到到了解脱"},

			//恶魔杀手
			{"It seems chemicals leaked from his jetpack burn him alive", "喷气背包泄露的化学物质似乎把他活活烧死了"},

			//盘子女鬼
			{"Scarlet nights are fueled with her blood", "猩红之夜沾染上了她的血液"},
			{"I start to see mamma in white flash", "我看到妈妈白色的身影一闪而过"},
			{"*Sobs*Finally she could comb my hair like old days", "抽泣着说）她终于能像以前那样给我梳头了"},
			{"Arigato gozaimasu ", "非常感谢"},

			//以撒
			{"Isaac start to see the bigger picture and remeber the souls warn", "以撒开始看到更大的世界并回想起灵魂的警告"},
			{"He reject the heavens to take his friend back, NOW", "他拒绝了天堂的召唤，坚持要带回他的朋友，而此刻（他正面临抉择）"},
			{"Isaac left all of his pain behind", "以撒把所有的痛苦都抛在脑后"},
			{"He will now rest his soul and wait to see his toy friend again peacefully", "他现在将安息，平静地等待再次见到他的玩具朋友"},
			{"As he rejected above for seeing his friend again", "他之前拒绝了上天只为了能够再次见到他的朋友"},
			{"Below awaits until he is being forgiven", "在火湖，他一直在等待，直到他得到宽恕"},

			//皇家鸟妖风暴号
			{"Brother...NO! Please don't leave me alone.", "哥哥...不！请不要丢下我一个人"},
			{"It hurts...but that's ok...I will see brother again instead of being alone...", "这很痛...但没关系...我将再次见到哥哥，而不是孤单一人..."},
			{"Thank you human...For ending my life...Rather than ending my honor...", "谢谢你，泰拉人...因为你结束了我的生命...而不是玷污了我的荣誉"},
			{"This is the end...Sister...I'll be there soon...", "这就结束了...妹妹...我马上就到"},
			{"A man that cannot protect his family...Has no right to live...", "一个不能保护家人的我…没有生存的权利..."},

			//胎儿博士
			{"Dr Fetus start to get serious", "胎儿博士开始认真了"},
			{"Dr Fetus found your struggles humorous", "胎儿博士为你的幽默抵抗而发笑"},
			{"It's now defenseless", "它现在毫无防备"},
			{"Dr Fetus will return...", "胎儿博士会回来的..."},

			//英勇史莱姆
			{"Soul of the shining hero have been fused with blank Card", "闪亮英雄的灵魂已与空白塔罗牌融为一体"},
			//全息史莱姆
			{"Soul of the star-spawned terror have been fused with blank Card", "灵魂之星催生的恐怖已与空白塔罗牌融为一体"},
			//梦魇史莱姆
			{"'s hope consume the darkest nightmares", "的希望能够驱散最深沉的噩梦"},
			{"What is happening? You suppose to feel fear, not me", "发生什么事了？你才应该感到害怕，而不是我"},
			{"Your hope makes me sick...STOP IT!", "你的希望让我感到恶心...停下来！"},
			{"HAH, I KNOW IT'S NOTHING. I'M INEVITABLE", "哈，我知道这没什么，我是无敌的"},
			{"I have family, please show mercy", "我有家人，请手下留情"},
			{"This country belong to us,not yours to take", "这个王国属于我们，不是你们能夺走的"},
			{"Even I die this is not the end for our country", "即使我死了，这也不是我们王国的终结"},
			{"I don't want to die please I accept your terms", "我不想死，请接受我的条件"},
			#endregion

			#region NPC被攻击
			//兔兔
			{"Human put your weapon down and accept your punishment", "泰拉人，放下武器，接受惩罚"},
			{"Our lord have sentenced you to death", "兔子王国宣判你死刑"},
			//符文巫师
			{"Soul of the magician have been fused with blank Card", "符文巫师的灵魂已与空白塔罗牌融为一体"},
			//血肉之墙
			{"Soul of the abomination have been fused with blank Card", "可憎之魂已与空白塔罗牌融为一体"},
			//海盗船
			{"It seems you have rescued someone from pirates", "看起来你从海盗手中救下了一位落难者"},
			//巴拉雪人
			{"The air start to get colder", "空气变得寒冷"},
			//贪食之魂
			{"When a spirit dies it feel no pain but its memory start to vanish", "当贪食之魂死去时，它不会感到痛苦，但它的记忆开始消失"},
			#endregion
			
			#region 其它NPC互动
			//助教
			{"Now first wait for me to show the code and then press the buttons in same order.", "现在先等我显示代码，然后按相同的顺序按下按钮。"},
			{"Correct code. ", "错误"},
			{"Wrong code. ", "正确"},
			{"Lets continue test with ", "让我们继续试试"},
			{" word code", "个代码"},
			{"Test have been ended. Could you talk with me for results?", "测试已结束。你能和我谈谈测试结果吗？"},
			//幽灵陶伊
			{"Let's start with a easy math question and then I will ask 2 other types", "我们先从一个简单的数学问题开始，然后我会问另外两种类型的问题"},
			{"You feel the trivia questions have been ended. You should talk with the lost ghost", "你觉得冷知识问答已经结束了，你应该和幽灵陶伊谈谈"},
			{"Nice. You are absolutely correct.", "很好，你完全正确"},
			{"My apologies but your answer is wrong.", "很抱歉，但你的答案是错误的"},
			{"Sorry but time is up for this question.", "抱歉，这个问题的时间已经到了"},
			{"How many edges does a triangle have?", "三角形有多少条边？"},
			{"Two angles of triangle are ", "三角形的两个角度是"},
			{". What is third angle?", "度，第三个角是多少度？"},
			{"What is square of ", "后面这个数的平方是多少，"},
			{"What is square root of ", "后面这个数的平方根是是多少，"},
			{" equal?", "等于多少？"},
			{"How many eyes does a spider have?", "蜘蛛有多少只眼睛？"},
			{"How many legs does an octopus have?", "章鱼有多少条腿？"},
			{"How many pairs of wings do bees have?", "蜜蜂有多少对翅膀？"},
			{"What is the fastest land animal?", "陆地上最快的动物是什么？"},
			{"Which species of bear has a translucent fur?", "哪种熊的毛是半透明的？"},
			{"Which animal uses echolocation to move around in the dark?", "哪种动物使用回声定位在黑暗中移动？"},
			{"Which animal can rotate their head 270 degrees?", "哪种动物可以旋转头部270度？"},
			{"A cow’s stomach has how many compartments?", "牛的胃有多少个室？"},
			{"What kind of creature is a Portuguese man-of-war?", "葡萄牙军舰水母是一种什么样的生物？"},
			{"Which animal is known for having rectangular-shaped pupils?", "哪种动物以矩形瞳孔而闻名？"},
			{"What is Scotland’s national animal?", "苏格兰的国家动物是什么？"},
			{"Which boss needs to be defeated to activate hardmode?", "需要击败哪个Boss才能进入困难模式？"},
			{"How many mana point you have when you start terraria?", "你开始玩泰拉瑞亚时有多少魔法值？"},
			{"How many life point you have when you start terraria?", "你开始玩泰拉瑞亚时有多少生命值？"},
			{"Is there any wings that can be obtainable before wall of flesh have been defeated(Answer will be yes or no)?", "在击败肉山之前，能否获得任何翅膀？（答案是“是”或“否”）"},
			{"If a basic enemy have ", "如果敌人在普通模式下有"},
			{" life in normal mode, how much life it will have in expert mode?", "生命值，那么在专家模式下会有多少生命值？"},
			{"How many arms does skeletron prime have", "骷髅王有多少条手臂"},
			{"Which npc will be available after you generate your world without any special seed", "在没有任何特殊种子的情况下，生成世界后哪个NPC会出现"},
			{"What is the total number of drops that can be obtained from queen bee in vanilla?", "在原版泰拉瑞亚中，从蜂后那里可以获得多少种掉落物？"},
			{"Is this a question(Answer will be yes or no)?", "这是一个问题吗？（答案是“是”或“否”）"},
			{"In which place you can find and save mechanic?", "在哪里可以找到并拯救机械师？"},
			{"What is the name of final boss in vanilla terraria?", "原版泰拉瑞亚的最终Boss叫什么名字？"},
			//受缚黑暗女猎手
			{"How dare you try to save the guilt? What she has done is unacceptable, her punishment is inevitible", "你怎么敢试图逃避罪责？她所做的难以接受，惩罚在所难免"},
			{"So if you stand in my way, there will only be one more corpse and one less obstacle to worry about", "所以，如果你阻挡我，就只会多一具尸体，少一个需要担心的障碍"},
			
			//水族智者
			{"You feel the challenge have been ended. You should talk with the aquatic wiseman", "你觉得挑战已经结束了，你应该和水族智者谈谈"},
			//猎犬
			{"LC on ducks and shoot them down", "左键鸭子并击落它们"},
			{"You feel hunt have been ended. You should talk with the hunter", "你觉得挑战已经结束了，你应该和猎犬谈谈"},
			//被滴滴怪寄生的赏金猎人
			{"Finally you manage to take brain clot off", "终于，你设法把那些黏糊糊的东西扯了下来"},
			//高级训练假人
			{"Sadly dummy is allergic to cuteness", "不幸的是，假人对可爱过敏"},
			//Boss rush
			{"You have proven yourself human to rebuild the broken balance", "你已经证明了自己有能力重建破碎的平衡"},
			{"Boss rush have been completed.", "Boss rush 已完成"},
			//饼干盒
			{"A gluttory-spawned possession gain consciousness to nourish", "一个由贪婪催生的实体获得了滋养自身的意识"},
			{"You feel you shouldn't get overfed with delicious cookies", "你觉得自己不应该因为美味的饼干而吃得过饱"},
			{"Uh Oh, time to find another wooden crate", "哦哟，是时候去找另一个木箱了"},
			{"Bye, friend", "再见，朋友"},
			{"Wait, only a single thing could burn my cookies, the forbidden lamb sauce", "等等，只有一样东西能烧掉我的饼干，那就是羊酱汁"},
			{"You... I see you stole from him, the big man himself right?", "你……我看到你从他那偷了东西，就是那个大块头对吧？"},
			{"Now its time to see not an avatar but the true me, ", "现在是时候展现真正的技术，而不是我那弱小的化身了"},
			{"[c/FF0000:Why don't] [c/FFA500:you die?] [c/ffff00:Wait I] [c/00FF00:forget to] [c/0009FF:follow unique] [c/A020F0:ai instructions]", "[c/FF0000:你为什么][c/FFA500:不死呢？][c/ffff00:等等，][c/00FF00:我忘记][c/0009FF:遵循][c/A020F0:独特的AI指令了]"},
			{"[c/FF0000:Edgy ] [c/FFA500:talk and] [c/ffff00: random] [c/00FF00:worm] [c/0009FF:phase] [c/A020F0:check]", "[c/FF0000:废话] [c/FFA500:少说] [c/A020F0:准备][c/ffff00:进入][c/00FF00:狂暴][c/0009FF:阶段]"},
			{"[c/FF0000:Abusing] [c/FFA500:npc limit] [c/ffff00:with basic] [c/00FF00:movement] [c/0009FF:check, good] [c/A020F0:to go now]", "[c/FF0000:解除] [c/FFA500:NPC] [c/ffff00:基本移动] [c/00FF00:限制，] [c/0009FF:现在] [c/A020F0:可以了]"},
			{"[c/FF0000:I can't] [c/FFA500:let you] [c/ffff00:go away] [c/00FF00:after what] [c/0009FF:have you] [c/A020F0:done to him]", "[c/FF0000:我不能][c/FFA500:让你在][c/00FF00:对他做了][c/0009FF:那些][c/A020F0:事情后][c/ffff00:一走了之]"},
			{"[c/FF0000:I'm sorry] [c/FFA500:but it] [c/ffff00:has] [c/00FF00:to be] [c/0009FF:this] [c/A020F0:way]", "[c/FF0000:抱歉，][c/FFA500:但][c/ffff00:事情][c/00FF00:必须][c/0009FF:这样][c/A020F0:解决]"},
			{"Possession remember how it died from starvation", "饼干板条箱记得它是如何因饥饿而死的"},
			{"It will not let same thing happen to its newfound friend", "它不会让同样的事情发生在它新结交的朋友身上"},
			{"What truely hurt me is I will also forget his smile before I fade, farewell chef...", "真正让我心痛的是，在我消逝之前，我也会忘记他的笑容，再见了，饼干师..."},
			#endregion

			#region ModPlayer Prekill
			//空白塔罗牌
			{"Blank card vibrates similar to heart beat", "空白塔罗牌如心跳般颤动"},
			//智者的抗辩
			{" endured killing blow", "受了致命的一击"},
			{" find the path of Yuri.", "踏上了尤里之道"},
			//英格瓦斯的符文
			{"Rune have shown" + Main.LocalPlayer.name + " a new beginning", "符文给了" + Main.LocalPlayer.name + "一个新的开始"},
			//仙酿
			{"... Not now!", "还不够！"},
			//救赎之杖
			{" have escaped from death", "逃脱了死亡"},
			//呼唤之花
			{"... but it refused.", "...但它拒绝了"},
			//隙间、德尔塔符文、粉红色的伞
			{"Spell Card:Barrier \"Boundary of Life and Death\"", "法术牌：屏障 \"生与死的界限\""},
			//PID、德尔塔符文
			{"OMFG YOU DO NOT KILL Player! Player KILLS YOU!!!!!", "我的天啊！你不该杀了玩家！泰拉人会杀了你！！！！"},
			#endregion

			#region 物品
			//空白塔罗牌
			{"Blank card empowered with greed", "空白塔罗牌注满了贪婪"},
			{"Blank card shines with the light of the stars", "空白塔罗牌沐浴着星光，熠熠生辉"},
			{"Blank card enjoys the journey", "空白塔罗牌享受与你的这段旅程"},
			{"Blank card enlighted with your hobby", "空白塔罗牌因你的爱好而焕发光彩"},
			//垃圾
			{"There is nothing valuable here", "这里没有什么值钱的东西"},
			//邪恶之心
			{"Unholy artifact have been destroyed by the flames of hell ", "邪恶的神器已被地狱之火摧毁"},
			{"But you still feel his powers are growing", "但你仍然觉得它的力量在增长"},
			//礼物袋
			{"I heard you like pillar fragments.", "我听说你喜欢四柱碎片"},
			{"Looks Spooky", "看起来阴森可怖"},
			{"Who put souls here", "谁把魂放在这里了"},
			{"Inside shines like sun .", "亮晶晶的宝石"},
			{"Wait ... WHAT?", "等等...这是什么？"},
			{"Cosmic Stardust surronds you", "宇宙星辰环绕于你"},
			{"How even this bag didn't burn ?", "这袋子怎么没被点燃？"},
			{"A meteorite has landed into your pocket!", "一颗陨石落入你的口袋！"},
			//痛苦的地球
			{"The blood lusted souls are now free", "嗜血的灵魂现在自由了"},
			//水晶监牢
			{"The crystal shattered into million little pieces", "水晶碎成了无数小块"},
			//黏液的玻璃囚笼
			{"[c/ffff00:Let's beat] [c/FF0000:this murderer] [c/0009FF:together friends]", "[c/ffff00:伙伴们，][c/0009FF:让我们一起][c/FF0000:惩罚这个凶手]"},
			{"I will hide our aura", "我会隐藏我们的踪迹"},
			//史莱姆战旗
			{"Slime troop have located your position", "史莱姆军队发现了你的位置"},
			//趣味徽章
			{"It seems someone left vac active", "现在还不是时候"},
			{"Maybe you should try it when there is no boss active", "也许你应该在没有Boss时再试试"},
			//混沌观察者
			{"You are not worthy for now.", "你现在不配"},
			//瓶中星系
			{"Now you can't drain fragments power", "现在你不能吸取四柱碎片的能量"},
			{"Now you can drain fragments power", "现在你可以吸取四柱碎片的能量"},
			//植物学手册
			{"This is a ", "这是一株"},
			{"not grown", "未成熟的"},
			{"fully grown", "成熟的"},
			{" carrot plant", "胡罗卜"},
			{" potato plant", "土豆"},
			{" glow berry plant", "光莓"},
			{" flax plant", "亚麻"},
			{" beet plant", "甜菜"},
			{" miracle fruit plant", "奇迹之果"},
			//无线电探测器
			{"First found plantera bulb is in ", "世纪花苞的坐标是 ("},
			{"X and ", ", "},
			{"Y location", ")"},
			{"Your world does not contain any Plantera bulb", "你的世界未找到世纪花苞"},
			{"First found lihzahrd altar is in ", "丛林蜥蜴祭坛的坐标是 ("},
			{"Your world does not contain any Lihzahrd altar", "你的世界未找到丛林蜥蜴祭坛"},
			//微型房屋定位器
			{"Your world does not contain any tiny house", "你的世界未找到微型房屋"},
			{"With respect to their remaining empty slots items have been sent", "已将所有未收藏的物品放到微型房屋里"},
			//符卡
			{"All active bosses have been sealed away", "当前存在的Boss已被封印"},
			//皓月的皎洁
			{"Majora's Mask Moon have been adjusted.", "已变幻为《塞尔达传说：时之笛》中的月之面具"},
			{"[c/FF8C00:Pumpkin Moon] have been adjusted.", "已变幻为[c/FF8C00:南瓜月]"},
			{"[c/00FFFF:Snow Moon] have been adjusted.", "已变幻为[c/00FFFF:雪月]"},
			{"[c/0000FF:Blue Moon] have been adjusted.", "已变幻为[c/0000FF:蓝月]"},
			{"[c/ffff00:PopStar] have been adjusted.", "已变幻为[c/ffff00:流行之星]"},
			{"[c/FF1493:Eye of ???] have been adjusted.", "已变幻为[c/FF1493:???之眼]"},
			{"[c/008000:Dusa Moon] have been adjusted.", "已变幻为[c/008000:杜莎月]"},
			{"Vanilla Moon have been adjusted.", "已变幻为原版月亮"},
			{"[c/FF1493:Natsuki Moon] have been adjusted.", "已变幻为[c/FF1493:夏树月]"},
			//日耀的光辉
			{"[c/FFFF00:Teletubbies Sun] have been adjusted.", "已变幻为[c/FFFF00:天线宝宝太阳]"},
			{"[c/FFFF00:Sunglasses Sun] have been adjusted.", "已变幻为[c/FFFF00:墨镜太阳]"},
			{"[c/FFFF00:Eclipse Sun] have been adjusted.", "已变幻为[c/FFFF00:日食]"},
			{"[c/FFFF00:Realistic Sun] have been adjusted.", "已变幻为[c/FFFF00:写实太阳]"},
			{"[c/008000:Dusa Sun] have been adjusted.", "已变幻为[c/008000:杜莎太阳]"},
			{"[c/FFFF00:Old Sun] have been adjusted.", "已变幻为[c/FFFF00:古老太阳]"},
			{"Vanilla Sun have been adjusted.", "已变幻为原版太阳"},
			{"[c/FF1493:Natsuki Sun] have been adjusted.", "已变幻为[c/FF1493:夏树太阳]"},
			//测试物品
			{"Big game hunters trophy shop have been unlocked", "Boss狩猎商人的纪念章商店已解锁"},
			{"Active big game hunters could not be found", "未找到Boss狩猎商人"},
			//开心乐园餐
			{"It seems the toy truely have small parts", "看起来玩具有很多小零件"},
			//薛定谔之盒
			{"The reality has been shattered", "现实已被打碎"},
			//地狱图腾
			{"You seek power... But what in return...", "你乞求力量...但带来的是..."},
			//???的死亡圣器
			{"The sacrifice has been accepted.", "祭品已被接受"},
			{"Lord Chippy has accepted your sacrifice.", "愠怒领主已笑纳汝之供奉"},
			{"You feel quite [c/FF1493:joyful].", "你感到很有[c/FF1493:趣味]"},
			{"Lord Fury has accepted your sacrifice.", "狂怒领主已笑纳汝之供奉"},
			//世界难度令牌
			{"Worlds difficulty return back to normal mode", "世界已调整为经典模式"},
			{"Worlds difficulty return back to expert mode", "世界已调整为专家模式"},
			{"Worlds difficulty return back to master mode", "世界已调整为大师模式"},
			{"Worlds difficulty return back to journey mode", "世界已调整为旅途模式"},
			//空间粒子结构
			{"Your life haven't cause anomaly in the boundary of time and space.", "你的存在没有在时空的边界上造成异常"},
			//水晶头骨
			{"It seems you are still alive. Try your luck on a Dungeon Guardian.", "你还活着，去试试地牢守卫吧"},
			//战术电话
			{"Aim Closest Enemy Tactic Adjusted", "已调整为攻击最近敌人"},
			{"Aim Strongest Enemy Tactic Adjusted", "已调整为攻击最强敌人"},
			{"Aim Weakest Enemy Tactic Adjusted", "已调整为攻击最弱敌人"},
			#endregion

			#region 物块相关
			//磁储存装置
			{"Answer Adjusted", "密码已调整"},
			//紫色水晶球
			{"For crafting ??? effect egg you need to have vanilla cursed debuff.", "要制作???彩蛋，你需要原版的诅咒减益"},
			{"If you open Schrodinger's box while having a Cirno pet and Cirno light pet active you will get broken reality.", "如果你在同时拥有琪露诺宠物和琪露诺照明宠物的情况下打开薛定谔之盒，你将获得破碎的现实"},
			{"If you use death's ??? while there is a guide voodoo doll in your inventory and guide is alive you will get death coin", "如果你在背包里有向导巫毒娃娃且向导还活着的情况下使用???的死亡圣器，你将获得死亡硬币"},
			{"If you use death's ??? while there is a portrait of markov in your inventory, party girl is alive", "如果你在背包里有马尔科夫的肖像，派对女孩还活着，"},
			{"and there is blood moon you will get yuri's eye", "并且还是血月，使用???的死亡圣器将会获得尤里之眼"},
			{"If you kill dungeon guardian while you have reimu pet and living void buff (void in a pouch or any accessory crafted from it gives that)", "如果你在拥有博丽灵梦宠物的情况下击败地牢守卫，"},
			{"you have a chance to get pink umbrella", "将有几率获得粉红色的伞"},
			{"Forgotten gun has a chance to drop from queen bee while you have cabbit pet and moon lord is being defeated", "月亮领主被击败后，如果你拥有Ryo-Ohki宠物（可疑的宝石），蜂后有几率掉落元素净化者"},
			{"Bringer of ancient wisdom has a chance to drop from plantera while you have Junko pet and moon lord is being defeated", "月亮领主被击败后，如果你拥有Junko宠物，世纪之花有几率掉落远古智慧之源"},
			{"Broken hero armor can be obtain by throwing Mountain Dew into water near to stardustpillar when there is blood moon.", "在血月，将激浪汽水倒入星尘柱附近的水中，你可以获得Broken hero armor"},
			{"If you use death's ??? while there is clothier voodoo in your inventory and clothier is alive you will get broken washing machine", "如果你在背包里有服装商巫毒娃娃且服装商还活着的情况下使用???的死亡圣器，你将获得破碎的洗衣机"},
			{"If you use death's ??? while you have flames of fury buff (it can be obtain from Fury) and travelling merchant is alive you will get animal feed", "如果你在拥有狂怒之火增益（可从狂怒至镐获得）且旅商还活着的情况下使用???的死亡圣器，你将获得动物饲料"},
			//墙洞
			{"You should check the hole in next morning", "你应该在第二天再次检查这个洞"},
			//雕塑家的雕像
			{"Temporary spawn point has been removed", "临时传送点已移除"},
			{"Cannot set temporary spawn before active removal/death cooldown", "冷却结束前无法设置临时传送点"},
			{"Temporary spawn point has been set", "临时传送点已设置"},
			//宇宙飞船传送器
			{"It could not be used while there is any boss active", "有Boss存活时无法使用"},
			//物块扫描仪
			{"There is no scanned tile type within the 50x50 tile range", "指定范围内未扫描到物块"},
			#endregion

			#region UI相关
			//安全机器人击败后的炸弹面板
			{"SYSTEM RESET...INITIALIZING PASSIVE STATE", "系统初始化...正在重置为出厂状态"},
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
			{"Retry", "重置"},
			{"Start Playing", "开始游戏"},
			{"Level ", "第 "},
			{" is solved", " 已完成"},
			{"Congrats you beat all of the levels", "恭喜你通关！"},
			{"There is an error so please tell Sir AFK", "程序发生错误，请通知作者或汉化组"},
			//扫雷
			{"Congrats you find all of the mines", "恭喜你找到了所有地雷"},
			{"Press retry to start again", "点击重新开始"},
			{"Sorry, you press to the mine", "不好意思你按到地雷了"},
			#endregion

			#region 杂项
			//BadSlimeBall3
			{"Your nightmare become reality", "你的噩梦成真了"},
			//炼金术之书
			{" have opened their eyes to see...", "睁开眼看到了新的世界..."},
			//被祝福近古守卫
			{"Broken Washing Machine sacrifice itself to protect" + Main.LocalPlayer.name + "'s soul", "献祭了自己来保护" + Main.LocalPlayer.name + "的灵魂"},
			//物块扫描仪
			{"m distance left to scanned tile", " 米距离所扫描物块"},
			//空间校准器系列
			{"Player hasn't died yet", ""},
			{"Rain has been ended", "雨天开始了"},
			{"Rain has been started", "雨天结束了"},
			{"Wind has been ended", "刮风天开始了"},
			{"Wind has been started", "刮风天结束了"},
			{"Sandstorm has been ended", "沙尘暴开始了"},
			{"Sandstorm has been started", "沙尘暴结束了"},
			//坐标定位器
			{"Location registered", "坐标已添加"},
			{"Location cleared", "坐标已移除"},
			#endregion
		};
	}
}