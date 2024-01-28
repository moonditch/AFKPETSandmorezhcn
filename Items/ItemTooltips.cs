using System.Collections.Generic;
using System.Text;
using Terraria;
using Terraria.ModLoader;

namespace AFKPETSandmorezhcn.Items
{
	public class ItemTooltips : GlobalItem
	{
		public override void ModifyTooltips(Item item, List<TooltipLine> tooltips)
		{
			foreach (TooltipLine tooltipLine in tooltips)
			{
				StringBuilder sb = new StringBuilder(tooltipLine.Text);
				sb.Replace("-Dedicated Content-", "-专属内容-");
				sb.Replace("-Crossover Content-", "-联动内容-");
				sb.Replace("Trinket", "杂货");
				sb.Replace("Artifact", "遗物");
				
				sb.Replace("True Melee ", "真");
				sb.Replace("active summon ", "主动");
				sb.Replace("transformation summon ", "变身");
				sb.Replace("No Random Crit Chance", "无暴击率");
				sb.Replace(" combo power cost", "点连击能量消耗");

				sb.Replace("A divine relic which made from great harpy bars", "这是由鹰身女妖制成的圣物");
				sb.Replace("Taking heart while having full hp spawn dolls that attack close enemies\nIf player have ability to flight they also gain that ability",
							"满血状态获得心时，生成攻击敌人的玩偶\n玩偶会复制玩家的攻击手段");

				sb.Replace("Hold Shift while hovering on item to see lil wiki obtain entry", "光标放在物品上并按住Shift键，查看 Wiki 上的获取方式");
				sb.Replace("Hold Shift while hovering on item to see lil wiki secret + obtain entry", "光标放在物品上并按住Shift键，查看 Wiki 上的获取方式");
				sb.Replace("Hold Shift while hovering on item to learn more about potted pals", "光标放在物品上并按住Shift键，查看 Wiki 上的详细说明");
				sb.Replace("Hold Shift while hovering on item to see lil wiki blessing ability entry", "光标放在物品上并按住Shift键，查看 Wiki 上的详细说明");
				sb.Replace("Hold Shift while hovering on item to see lil wiki different poop types entry", "光标放在物品上并按住Shift键，查看 Wiki 上的详细说明");
				sb.Replace("Hold Shift while hovering on item to see lil wiki all tiny crew ability entry", "光标放在物品上并按住Shift键，查看 Wiki 上的详细说明");
				sb.Replace("Hold Shift while hovering on item to see lil wiki different poop types entry", "光标放在物品上并按住Shift键，查看 Wiki 上的详细说明");
				sb.Replace("Hold Shift while hovering on item to see lil wiki all buddies biome + biome specific special ability entry", "光标放在物品上并按住Shift键，查看 Wiki 上的详细说明");	
				tooltipLine.Text = sb.ToString();
			}

			//测试性能改进
            /*foreach (TooltipLine tooltipLine in tooltips)
			{
				tooltipLine.Text = tooltipLine.Text.Replace("-Dedicated Content-", "-专属内容-");
				tooltipLine.Text = tooltipLine.Text.Replace("-Crossover Content-", "-联动内容-");
				tooltipLine.Text = tooltipLine.Text.Replace("Trinket", "杂货");
				tooltipLine.Text = tooltipLine.Text.Replace("Artifact", "遗物");
				tooltipLine.Text = tooltipLine.Text.Replace("No Random Crit Chance", "无暴击率");
				tooltipLine.Text = tooltipLine.Text.Replace(" combo power cost", "点连击能量消耗");
				tooltipLine.Text = tooltipLine.Text.Replace("A divine relic which made from great harpy bars", "这是由鹰身女妖制成的圣物");
				tooltipLine.Text = tooltipLine.Text.Replace("Hold Shift while hovering on item to see lil wiki obtain entry", "鼠标指针放在物品上并按住Shift键，能看到lil wiki上面的获取方式");
				tooltipLine.Text = tooltipLine.Text.Replace("True Melee ", "真");
				tooltipLine.Text = tooltipLine.Text.Replace("active summon ", "主动");
				tooltipLine.Text = tooltipLine.Text.Replace("transformation summon ", "变身");
			}*/
		}
	}
}