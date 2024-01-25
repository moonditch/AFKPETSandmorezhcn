using System.Collections.Generic;
using System.Text.RegularExpressions;
using Terraria;
using Terraria.ModLoader;
using AFKPETS.Items;

namespace ThoriumModzhcn.Items
{
    public class ItemTooltips : GlobalItem
    {
        public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
        {
            foreach (TooltipLine tooltipLine in tooltips)
            {
               tooltipLine.Text = tooltipLine.Text.Replace("-Dedicated Content-", "-专属内容-");
                tooltipLine.Text = tooltipLine.Text.Replace("-Crossover Content-", "-联动内容-");
                tooltipLine.Text = tooltipLine.Text.Replace("Trinket", "杂货");
                tooltipLine.Text = tooltipLine.Text.Replace("Artifact", "遗物");
                tooltipLine.Text = tooltipLine.Text.Replace("No Random Crit Chance", "无暴击率");
                tooltipLine.Text = tooltipLine.Text.Replace("combo power cost", "点连击消费能量");
                tooltipLine.Text = tooltipLine.Text.Replace("A divine relic which made from great harpy bars", "这是由鹰身女妖制成的圣物");
                tooltipLine.Text = tooltipLine.Text.Replace("Hold Shift while hovering on item to see lil wiki obtain entry", "鼠标指针放在物品上并按住Shift键，能看到lil wiki上面的获取方式");
            }
        }
    }
}
