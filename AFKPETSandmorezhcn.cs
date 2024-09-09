using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;

namespace AFKPETSandmorezhcn
{
	public class AFKPETSandmorezhcn : Mod
	{
	}
	public class AFKPETSandmorezhcnPlayer : ModPlayer
	{
		public override void OnEnterWorld()
		{
			Main.NewText("AFK模组更新 v9.9.9.77 ，死灵傀儡法师和胎儿博士战斗改进.", Color.Orange);
		}
	}
}