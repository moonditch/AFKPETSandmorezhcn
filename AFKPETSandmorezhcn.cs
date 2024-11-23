using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using TigerForceLocalizationLib;
using TigerForceLocalizationLib.Filters;

namespace AFKPETSandmorezhcn
{
	public class AFKPETSandmorezhcn : Mod
	{
		// ↓↓↓将此值设置为 true 并且清空 .hjson 文件中的内容 (不要删除 .hjson 文件) 以进行初次构建
		// 初次构建后记得改为 false
		private readonly static bool firstRegister = false;
		public override void PostSetupContent()
		{
			string targetModName = "AFKPETS";

			// ↓↓↓用于初次构建时筛选
			string[] PreDraw = {"PreDraw", "PreDrawInInventory", "PreDrawInWorld", "PreDrawExtras", "PreDrawTooltipLine", "PreDrawExtras"};
			string[] PostDraw = {"PostDraw", "PostDrawInInventory", "PostDrawInWorld"};//先整体筛掉PostDraw，有文字的部分单独翻译
			string[] Tooltip = {"ModifyTooltips", "AdditionalTooltip"};
			string[] Accessory = {"UpdateAccessory", "CanEquipAccessory"};
			string[] NPCs = {"SetNPCNameList", "get_HeadTexture", "GetChat", "OnChatButtonClicked"};
			string[] Misc = {"AFKPetsWingDraw"};

			if (!ModLoader.HasMod(targetModName))
			{
				return;
			}
			if (firstRegister)//用于初次构建，注意此处 registerkey 为 true
			{
				TigerForceLocalizationHelper.LocalizeAll(nameof(AFKPETSandmorezhcn), targetModName, registerKey: true, "Mods.AFKPETSandmorezhcn", filters: new()
				{
					MethodFilter = MethodFilter.CommonMethodFilter & MethodFilter.MismatchNames(PreDraw) & MethodFilter.MismatchNames(PostDraw) & MethodFilter.MismatchNames(Tooltip)& MethodFilter.MismatchNames(Accessory) & MethodFilter.MismatchNames(NPCs) & MethodFilter.MismatchNames(Misc),
					CursorFilter = ILCursorFilter.CommonCursorFilter,
					//TypeFilter = TypeFilter.MismatchFullNames("", ""),
				});
				TigerForceLocalizationHelper.ShowLocalizationRegisterProgress();
				return;
			}
			LocalizeMethod_LocalizeAll(targetModName);
			
		}
		public static void LocalizeMethod_LocalizeAll(string targetModName)
		{
			TigerForceLocalizationHelper.LocalizeAll(nameof(AFKPETSandmorezhcn), targetModName, registerKey: false, "Mods.AFKPETSandmorezhcn");
		}
	}
	public class AFKPETSandmorezhcnPlayer : ModPlayer
	{
		public override void OnEnterWorld()
		{
			//Main.NewText("AFK模组更新 v9.9.9.78 ，物品重做和战斗改进，具体参照模组创意工坊的更新日志.", Color.Orange);
			Main.NewText("汉化模组更新，增加更多汉化\n汉化问题进群反馈：895423665", Color.Orange);
		}
	}
}