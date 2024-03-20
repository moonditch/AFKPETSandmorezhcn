using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Terraria.ModLoader;
using Terraria.UI.Chat;
using AFKPETS.UI;

namespace AFKPETSandmorezhcn.GlobalTranslation
{
    public class StatsTranslate : ModSystem
    {
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
            //UI
            text = Regex.Replace(text, "Trinket", "密藏");
            //街机游戏UI
            text = Regex.Replace(text, "MINIGAMES", "迷 你 小 游 戏");
            text = Regex.Replace(text, "Sokoban", "推箱子");   
            text = Regex.Replace(text, "SOKOBAN", "推 箱 子");   
            text = Regex.Replace(text, "Minesweepers", "扫雷");   
            text = Regex.Replace(text, "MINESWEEPERS", "扫 雷");   
            text = Regex.Replace(text, "Thin Ice", "薄冰");  
            text = Regex.Replace(text, "THIN ICE", "薄 冰");  
            text = Regex.Replace(text, "Skill Issue", "重置");  
            text = Regex.Replace(text, " Mines Placed", "个地雷"); 
            text = Regex.Replace(text, "Sorry, you press to the mine", "不好意思你按到地雷了");  
            text = Regex.Replace(text, "Congrats you find all of the mines", "恭喜你找到了所有的地雷"); 
            text = Regex.Replace(text, "Press retry to start again", "按重新开始重新开始");
            text = Regex.Replace(text, "Retry", "重置");     
            text = Regex.Replace(text, "Start Playing", "开始游戏");  
            text = Regex.Replace(text, "Level", "关卡");  
            text = Regex.Replace(text, " is solved", " 已完成");    
            //NPCUI 
            //游戏精灵
            text = Regex.Replace(text, "Prize Shop", "奖励商店"); 
            //流浪武士
            text = Regex.Replace(text, "Eastern Shop", "车万商店");
            //艺术家
            text = Regex.Replace(text, "Art Shop", "艺术商店"); 
            //坠落天使
            text = Regex.Replace(text, "Angelic Shop", "天使商店"); 
            //设计师
            text = Regex.Replace(text, "Vanity Shop", "虚荣商店");  
            text = Regex.Replace(text, "Help Her", "帮助她"); 
            //研究员
            text = Regex.Replace(text, "Research Shop", "研究商店"); 
            text = Regex.Replace(text, "Fix Weapon", "修理武器"); 
            //Boss狩猎商人
            text = Regex.Replace(text, "Base Shop", "基础商店");  
            text = Regex.Replace(text, "Reward Shop", "奖励商店");
            text = Regex.Replace(text, "Next Boss", "下个BOSS"); 
            text = Regex.Replace(text, "Give Trophy", "给予纪念章"); 
            text = Regex.Replace(text, "Change Option Type", "更改选项类型");  
            //死灵傀儡法师
            text = Regex.Replace(text, "Start Training", "开始训练");   
            //水族智者
            text = Regex.Replace(text, "Start the Challenge", "开始挑战");  
            //幽灵陶伊
            text = Regex.Replace(text, "Start Trivia", "冷知识开始");  
            //神圣骑士，艺术家
            text = Regex.Replace(text, "Exchange", "交换"); 
            //刺客
            text = Regex.Replace(text, "Weapon Imbue Fear Toxin", "武器灌注恐惧毒素");  
            //神圣骑士，黑暗女猎手，皇家卫士，刺客
            text = Regex.Replace(text, "Shop", "商店"); 
            

            //npc语句UI
            //死灵傀儡法师
            /* text = Regex.Replace(text, "Since contact is obvious I mostly want to talk about two specific magic attacks", "由于接触是显而易见的，我主要想谈谈两个具体的魔法攻击"); 
            text = Regex.Replace(text, "While magic can be used to bring happiness and welfare, it also have a dark side", "虽然魔法可以带来快乐和幸福，但它也有黑暗的一面"); 
            text = Regex.Replace(text, "So it would be nice if we test your dodging skills", "所以最好测试一下你的闪避技巧");
            text = Regex.Replace(text, "Could you dodge the upcoming attack", "你能闪避即将到来的攻击吗我们能不能先友好地决斗一下"); 
            text = Regex.Replace(text, "For next attack could you not move", "下次进攻可以不移动吗");
            text = Regex.Replace(text, "For next attack could you continuously move", "下次进攻可以连续移动吗");  
            text = Regex.Replace(text, "I guess this much knowledge is enough for today", "我想今天讲这么多就可以了");  
            text = Regex.Replace(text, "What, I have never fight with anyone but if you think it will be helpful", "什么，我从来没有和其他人打架过，但你认为这对你有帮助的话"); 
            text = Regex.Replace(text, "What is happening", "发生了什么"); 
            text = Regex.Replace(text, "Human please help me, it hurts", "人类，请帮帮我，很疼"); 
            text = Regex.Replace(text, "I feel like something ripping apart", "我好像有什么东西要裂开了"); 
            text = Regex.Replace(text, "That look on your face", "你脸上的表情"); 
            text = Regex.Replace(text, "Do you really wish this", "你真的希望这样吗"); 
            text = Regex.Replace(text, "I only want to help you", "我只是想帮你"); 
            text = Regex.Replace(text, "Could we make a friendly duel before we stop", "我们能不能先友好地决斗一下");

            //恶魔杀手
            text = Regex.Replace(text, "-Secret Art- Wind of Justice", "-秘密艺术-正义之风"); 
            text = Regex.Replace(text, "You feel now you can help the tied dark huntress without any problem", "现在你可以直接地帮助束缚黑暗女猎手"); 
            text = Regex.Replace(text, "Why did you kill that Dryad", "你为什么要杀那个树妖"); 
            text = Regex.Replace(text, "They are so kind to every creature around them", "她对周围的每一个人都很好");
            text = Regex.Replace(text, "Maybe it's time for cleaning this world from one more bandit", "也许是时候让我让这个世界再少一个邪恶了"); 

            //盘子女鬼
            text = Regex.Replace(text, "Even rats are more useful than you, Akiko", "老鼠都比你有用，明子");
            text = Regex.Replace(text, "AKIKO BREAK THE PLATE, SHE IS THE CUILT", "明子 打 碎 了 盘 子，她 是 祭 品");  
            text = Regex.Replace(text, "Akiko, how you menage to be good at nothing", "明子，你就是废物"); 
            text = Regex.Replace(text, "You greedy pig, isn't half bowl is enough for you Akiko", "你这贪吃的猪，明子，半碗还不够你吃吗");
            text = Regex.Replace(text, "You will sleep outside Akiko, you have on worth here", "你睡外面，明子，你在这里没有价值"); 

            //皇家风暴鸟号
            text = Regex.Replace(text, "Collect clear air bubbles to survive", "请收集干净的气泡存活"); 
            text = Regex.Replace(text, "Brother, we have a problem here", "兄弟，我们有麻烦了");  
            text = Regex.Replace(text, "Storm Diver roger, target locked", "风暴潜水员收到，目标锁定");  
            text = Regex.Replace(text, "Sister you look hurt", "妹妹，你看起来受伤了");
            text = Regex.Replace(text, "Retreat to the distance and recover", "先退到远处然后恢复"); 
            text = Regex.Replace(text, "Now this is personal", "这是我个人问题"); 
            text = Regex.Replace(text, "I no longer care for ethics", "我不再需要道德底线了");
            text = Regex.Replace(text, "Look at my face and keep that hook away. I have a surprise for you", "看着我的脸，把武器拿开，我有惊喜要给你");  
            （无法读写）text = Regex.Replace(text, "Other Harpies find me childish and idiotic but you've shown me ture care", "其他鹰身女妖觉得我幼稚愚蠢但你给了我真正的关心");  
            text = Regex.Replace(text, "Use Movement Keys to Pop Bubbles", "使用移动键击碎气泡");            
            text = Regex.Replace(text, "Thank you for shining as a summer sun in my foolish life, brother", "感谢你在我愚蠢的生命中像夏日的太阳照耀着我，兄弟"); ////

            //不死厨师
            text = Regex.Replace(text, "Go away, I'm busy with choosing the dessert", "走开，我正忙着选甜点呢");
            text = Regex.Replace(text, "How you even manage to burn down such a beauty", "你是怎么烧出这么好的东西的");  
            text = Regex.Replace(text, "let me show our hospitality", "让我来表示我们的热情"); 

            //史莱姆王国最后的希望
            text = Regex.Replace(text, "Let's beat", "朋友们");
            text = Regex.Replace(text, "this murderer", "让我们一起");  
            text = Regex.Replace(text, "together friends", "杀死这个杀人犯"); 
            text = Regex.Replace(text, "I will hide our aura", "我会隐藏我们的气味");
            text = Regex.Replace(text, "Shadow Clone Jutsu", "影分身の術"); 
            text = Regex.Replace(text, "How you kill him you heartless monster", "你怎么把他杀了，你这个无情的怪物");
            text = Regex.Replace(text, "Time for the shinobi execution", "是时候处决你了");  
            text = Regex.Replace(text, "Oh no, Shogun slime please don't left us", "不，幕府将军，请不要离开我们");
            text = Regex.Replace(text, "You...Let's finish this in Danmaku style", "你……让我们用这种状态谢幕"); 
            text = Regex.Replace(text, "FRIENDS CANNOT FOUND. SADNESS MODULE ACTIVATED.", "朋 友 不 见 了，悲 伤 模 式 激 活."); 
            text = Regex.Replace(text, "ENRAGEMEND PROTOCOL ACTIVATED", "暴 怒 模 式 激 活.");
            text = Regex.Replace(text, "She couldn't manage to protect her bodys density", "她无法保护自己的身体");  

            //冰之守护者
            text = Regex.Replace(text, "I'm sorry human but I cannot let ice elementals extinct one more time", "很抱歉，人类，但我不能让冰元素灭绝了"); 
            text = Regex.Replace(text, "You may kill me but please don't hurt my little sister", "你可以杀了我，但请不要伤害我的妹妹"); 
            text = Regex.Replace(text, "She may be a little wild but she have a heart of gold", "她也许有点野，但她有一颗善良的心");
            text = Regex.Replace(text, "I feel my primal instincts start to take control over my mind", "我的原始本能开始控制我的思想");
            text = Regex.Replace(text, "I'm sorry for things that happen next", "接下来发生的事我很抱歉"); 
            text = Regex.Replace(text, "Primal instincts start to take control of his mind", "原始本能开始控制他的思想"); 

            //史莱姆二阶段
            text = Regex.Replace(text, "I have been given flesh by all lifeforms horrors, To be your tormentor", "我被所有生命形式的恐怖思想赋予肉体，把你作为折磨者"); 
            text = Regex.Replace(text, "Your end is nigh", "你的末日即将来临"); 
              
            //001
            text = Regex.Replace(text, "Hello there. Thank you for your kindness to invite me.", "你好。谢谢你盛情邀请我");  
            text = Regex.Replace(text, "Before I give you your reward shall we play a nice game", "在我给你奖励之前，我们玩个游戏可以吗");  
            text = Regex.Replace(text, "For the game please cancel the answer buff for the answer you think is correct before time out.", "关于游戏，请在暂停前取消你认为正确的答案。"); 

            text = Regex.Replace(text, "Let's start with easy one", "让我们从简单的开始"); 
            text = Regex.Replace(text, "What is 91 divided by 7", "91除以7等于多少"); 

            text = Regex.Replace(text, "What is 2", "2加4等于多少");  
            text = Regex.Replace(text, "What is the billionth digit of pi", "π的10亿位数是多少");  
            text = Regex.Replace(text, "How many equal sides do lcosahedrons have", "十面体有多少条等边"); ////////

            text = Regex.Replace(text, "What is the percentage of metals in periodic table", "元素周期表中金属占用多少");

            text = Regex.Replace(text, " Which of the component doesn't have a specific region condition", " 哪个组件没有特定的区域条件"); 
            text = Regex.Replace(text, " Resistor", " 电阻器");  
            text = Regex.Replace(text, " MOSFET", " 金属氧化物半导体场效应晶体管");  
            text = Regex.Replace(text, " BJT", " 双极结晶体管");  

           （无法读写） text = Regex.Replace(text, "What is the average lifespan of a red blood cell in human body", "红细胞在人体内的平均寿命是多少"); /////
            text = Regex.Replace(text, " Around 1 day", " 大约 1 天");  
            text = Regex.Replace(text, " Around 1 week", " 大约 1 星期");  
            text = Regex.Replace(text, " Around 120 days", " 大约 120 天"); 

            text = Regex.Replace(text, "Which organ can regenerate naturally from half of itself", "哪个器官可以自己再生"); 
            text = Regex.Replace(text, " Heart", " 心脏");  
            text = Regex.Replace(text, " Brain", " 脑子");  
            text = Regex.Replace(text, " Liver", " 肝脏"); 

            text = Regex.Replace(text, "Which metal is ferromagnetic", "哪种金属是有磁性的"); 
            text = Regex.Replace(text, " Gold", " 金"); 
            text = Regex.Replace(text, " Iron", " 铁");  
            text = Regex.Replace(text, " Copper", " 铜"); 

            text = Regex.Replace(text, "Which metal have the highest tensile strength", "哪种金属的拉力强度最高"); 
            text = Regex.Replace(text, " Titanium", " 钛");  
            text = Regex.Replace(text, " Tungsten", " 钨");
            text = Regex.Replace(text, " 金", " 金");  

            text = Regex.Replace(text, "What is a dual-element fuse is used for", "双元件保险丝的用途是什么"); 
            text = Regex.Replace(text, "Operate in higher current", "在高电流下工作");   
            text = Regex.Replace(text, "Operate in lower current", "在低电流下工作");   
            text = Regex.Replace(text, "Protect the transistor", "保护晶体管"); 
 
            text = Regex.Replace(text, "Which metal is liquid in room temperature", "哪种金属在常温下是液态的"); 
            text = Regex.Replace(text, " Lead", " 铅");  
            text = Regex.Replace(text, " Mercury", " 汞");  
            text = Regex.Replace(text, " Silver", " 银"); 
 
            text = Regex.Replace(text, "Which instrument below detects electric current", "下面哪个仪器可以检测电流"); 
            text = Regex.Replace(text, " Galvanometer", " 电流计");  
            text = Regex.Replace(text, " Voltmeter", " 电压表");  
            text = Regex.Replace(text, " Wattmeter", " 瓦特计"); 

            text = Regex.Replace(text, "Which is the largest organ in human body", "人体最大的器官是什么"); 
            text = Regex.Replace(text, " Eye", " 眼睛");  
            text = Regex.Replace(text, " Lung", " 肺");  
            text = Regex.Replace(text, " Skin", " 皮"); 

            text = Regex.Replace(text, "What happens when AC voltage is applied to pure resistive circuit", "当交流电压遇到电阻会发生什么"); 
            text = Regex.Replace(text, " Current is in phase with voltage", " 电流与电压相一致");  
            text = Regex.Replace(text, " Current leads voltage", " 电流引线电压");  
            text = Regex.Replace(text, " Current lags voltage", " 电流滞后电压"); 

            text = Regex.Replace(text, "In which part of the human body do the smallest bones occur", "人体的哪个部位骨骼最小"); 
            text = Regex.Replace(text, " Leg", " 腿部");  
            text = Regex.Replace(text, " Finger", " 手指");  
            text = Regex.Replace(text, " Ear", " 耳朵"); 

            text = Regex.Replace(text, "Wrong Answer", "回答错误"); 
            text = Regex.Replace(text, "Correct", "回答正确"); 
            text = Regex.Replace(text, "Time for the great reward and final question", "是时候问最后一个问题了"); 
            text = Regex.Replace(text, "W H Y  Y O U  A R E  S T I L L  A L I V E", "你 为 什 么 还 活 着");
  
            //npc击败并离开这个世界
            //死灵傀儡法师
            text = Regex.Replace(text, "Antony's spirit find a way to escape", "安东尼的灵魂找到了逃跑的路线"); 

            //恶魔杀手
            text = Regex.Replace(text, "It seems chemicals leaked from his jetpack burn him alive", "喷气背包泄露的化学物质似乎把他活活烧死了");

            //盘子女鬼
            text = Regex.Replace(text, "Scarlet nights are fueled with her blood", "猩红之夜沾染上了她的血液"); 

            //以撒
            text = Regex.Replace(text, "Isaac start to see the bigger picture and remeber the souls warn", "以撒开始看到更大的世界并记住灵魂的警告"); 
            text = Regex.Replace(text, "He reject the heavens to take his friend back, NOW", "现在他正在拒绝上天接纳他的朋友");
            text = Regex.Replace(text, "As he rejected above for seeing his friend again", "因为他拒绝上天接纳他的朋友"); 
            text = Regex.Replace(text, "Below awaits until he is being forgiven", "在火湖等待着被他宽恕"); 

            //皇家鸟妖风暴号
            text = Regex.Replace(text, "Brother...NO", "哥哥...不");
            text = Regex.Replace(text, "Please don't leave me alone", "请不要丢下我一个人");  
            text = Regex.Replace(text, "It hurts...but that's ok...I will see brother again instead of being alone", "这让我很伤心……不过没关系……我将再次见到哥哥，而不是自己一个"); 
            text = Regex.Replace(text, "Thank you human...For ending my life...Rather than ending my honor", "谢谢你，人类……为了结束我的生命…而不是结束荣誉"); 
            text = Regex.Replace(text, "This is the end...Sister...I'll be there soon", "这就结束了……妹妹……我马上就到"); 
            text = Regex.Replace(text, "A man that cannot protect his family...Has no right to live...", "一个不能保护家人的我…没有生存的权利...");  

            //胎儿博士
            text = Regex.Replace(text, "Dr Fetus start to get serious", "胎儿博士开始变得严肃起来"); 
            text = Regex.Replace(text, "It's now defenseless", "它现在毫无防备"); */
            return orig.Invoke(text, baseColor);
        }       
    }
}
