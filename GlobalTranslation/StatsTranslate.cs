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
            text = Regex.Replace(text, "Retry", "重置");  
            text = Regex.Replace(text, " Mines Placed", "个地雷");  
            text = Regex.Replace(text, "Start Playing", "开始游戏");  
            text = Regex.Replace(text, "Level", "关卡");    
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
            return orig.Invoke(text, baseColor);
        }       
    }
}
