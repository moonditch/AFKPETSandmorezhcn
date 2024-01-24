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
                tooltipLine.Text = tooltipLine.Text.Replace("-Dedicated Content-", "-Dedicated Content1-");
                tooltipLine.Text = tooltipLine.Text.Replace("-Crossover Content-", "-Crossover Content1-");
                tooltipLine.Text = tooltipLine.Text.Replace("Trinket", "杂货");
                tooltipLine.Text = tooltipLine.Text.Replace("No Random Crit Chance", "没有概率暴击");
                tooltipLine.Text = tooltipLine.Text.Replace("combo power cost", "combo power cost1");
            }
        }
    }
}
