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
                tooltipLine.Text = tooltipLine.Text.Replace("-Dedicated Content-", "-专用内容-");
                tooltipLine.Text = tooltipLine.Text.Replace("Trinket", "杂货");
            }
        }
    }
}
