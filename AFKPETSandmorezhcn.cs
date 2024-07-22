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
			Main.NewText("AFK模组更新 v9.9.9.75 之后，模组的一些Boss得到了调整，快去试试吧！", Color.Orange);
		}
	}
}