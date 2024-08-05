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
			Main.NewText("AFK模组更新 v9.9.9.76 ，修复了一些Bug.", Color.Orange);
		}
	}
}