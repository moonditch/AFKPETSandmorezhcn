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
            text = Regex.Replace(text, "Since contact is obvious I mostly want to talk about two specific magic attacks", "由于接触是显而易见的，我主要想谈谈两个具体的魔法攻击"); 
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
            text = Regex.Replace(text, "Antony's spirit find a way to escape", "安东尼的灵魂找到了逃跑的路线");  
            //001
            text = Regex.Replace(text, "Hello there. Thank you for your kindness to invite me.", "你好。谢谢你盛情邀请我");  
            text = Regex.Replace(text, "Before I give you your reward shall we play a nice game", "在我给你奖励之前，我们玩个游戏可以吗");  
            text = Regex.Replace(text, "For the game please cancel the answer buff for the answer you think is correct before time out.", "关于游戏，请在暂停前取消你认为正确的答案。"); 
  
            text = Regex.Replace(text, "Let's start with easy one", "让我们从简单的开始"); 
            text = Regex.Replace(text, "What is 91 divided by 7", "91除以7等于多少"); 
             /*（无法读写）text = Regex.Replace(text, "What is 2", "2加4等于多少");  
            text = Regex.Replace(text, "What is the billionth digit of pi", "π的10亿位数是多少");  
            text = Regex.Replace(text, "How many equal sides do lcosahedrons have", "十面体有多少条等边"); */

            text = Regex.Replace(text, "What is the percentage of metals in periodic table", "元素周期表中金属占用多少");

            text = Regex.Replace(text, " Which of the component doesn't have a specific region condition", " 哪个组件没有特定的区域条件"); 
            text = Regex.Replace(text, " Resistor", " 电阻器");  
            text = Regex.Replace(text, " MOSFET", " 金属氧化物半导体场效应晶体管");  
            text = Regex.Replace(text, " BJT", " 双极结晶体管");  

            /*（无法读写） text = Regex.Replace(text, "What is the average lifespan of a red blood cell in human body", "红细胞在人体内的平均寿命是多少");*/ 
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
            return orig.Invoke(text, baseColor);
        }       
    }
}
