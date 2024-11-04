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
			Main.NewText("AFK模组更新 v9.9.9.78 ，物品重做和战斗改进，具体参照模组创意工坊的更新日志.", Color.Orange);
		}
	}
}