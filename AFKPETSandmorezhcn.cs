using Terraria.ModLoader;
using Terraria;
using Microsoft.Xna.Framework;
using TigerForceLocalizationLib;
using TigerForceLocalizationLib.Filters;
using AFKPETS;
using AFKPETS.NPCs.TheAncientGuardian;
using AFKPETS.Items.Vanity;
using AFKPETS.Items.NPCSummon;
using Terraria.Localization;
using System.Collections.Generic;
using AFKPETS.NPCs.UndeadChef;
using AFKPETS.NPCs.SecurityBot;
using AFKPETS.NPCs.PoliticianSlime;

namespace AFKPETSandmorezhcn
{
	public class AFKPETSandmorezhcnPlayer : ModPlayer
	{
		public override void OnEnterWorld()
		{
			Main.NewText("AFK模组更新 v9.9.9.91 ，添加新的物品。目前大部分物品重制已经完成，后续将优先进行NPC重制而非Boss重制。", Color.Orange);
			//Main.NewText("汉化模组更新，汉化问题进群反馈：895423665", Color.Orange);
		}
	}
	public class AFKPETSandmorezhcn : Mod
	{
		public override void Load()
		{
			AFKPETSTranslator.AFKPETSTranslator.LoadTranslator();
			base.Load();
		}
		// ↓↓↓将此值设置为 true 并且清空 .hjson 文件中的内容 (不要删除 .hjson 文件) 以进行初次构建
		// 初次构建后记得改为 false
		private readonly static bool firstRegister = false;
		public override void PostSetupContent()
		{
			string targetModName = "AFKPETS";

			// ↓↓↓用于初次构建时筛选
			string[] PreDraw = {"PreDraw", "PreDrawInInventory", "PreDrawInWorld", "PreDrawExtras", "PreDrawTooltipLine", "PreDrawExtras"};
			string[] PostDraw = {"PostDraw", "PostDrawInInventory", "PostDrawInWorld", "PostUpdate"};//先整体筛掉PostDraw，有文字的部分单独翻译
			string[] Tooltip = {"ModifyTooltips", "AdditionalTooltip", "ChangeLine"};
			string[] Accessory = {"UpdateAccessory", "CanEquipAccessory"};
			string[] NPCs = {"SetNPCNameList", "get_HeadTexture", "GetChat", "OnChatButtonClicked"};
			string[] Misc = {"AFKPetsWingDraw", "get_FunctionalBackgroundTexture", "get_FunctionalTexture", "ReforgePrice", "ModifyInterfaceLayers", "BossChecklistSupport", "CensusSupport", "HandlePacket", "PreKill", "OnInitialize", "OnLoad"};

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

			//补全原模组缺少的BossChecklist条目
			Mod bossChecklist;
			if (!ModContent.GetInstance<AFKPetsConfiguration>().LiteMode && !ModContent.GetInstance<AFKPetsConfiguration>().BossLiteMode)
			{
				if (ModLoader.TryGetMod("BossChecklist", out bossChecklist))
				{
					bossChecklist.Call(
						"LogMiniBoss",
						this,
						"TheAncientGuardian",
						3.04f,
						() => AFKPetsWorld.downedTheAncientGuardian,
						ModContent.NPCType<AncientGuardian>(),
						new Dictionary<string, object>()
						{
							["collectibles"] = ModContent.ItemType<AncientGuardianMask>(),
							["spawnItems"] = ModContent.ItemType<SeveredClothierHead>(),
							["spawnInfo"] = Language.GetTextValue("Mods.AFKPETS.NPCs.AncientGuardian.BossChecklistIntegration.SpawnInfo"),
							["despawnMessage"] = Language.GetTextValue("Mods.AFKPETS.NPCs.AncientGuardian.BossChecklistIntegration.DespawnMessage")
						}
					);

					bossChecklist.Call(
						"LogMiniBoss",
						this,
						"Tier1DungeonMinibossSecurityBot",
						5.02f,
						() => AFKPetsWorld.downedSecurityBot,
						new List<int>
						{
							ModContent.NPCType<SecurityBot>(),
							ModContent.NPCType<UndeadChef>()
						},
						new Dictionary<string, object>
						{
							["spawnItems"] = new List<int>
							{
								ModContent.ItemType<CorruptedServer>(),
								ModContent.ItemType<RoastChickenPlate>()
							},
							["spawnInfo"] = Language.GetTextValue("Mods.AFKPETS.NPCs.SecurityBot.BossChecklistIntegration.SpawnInfo"),
							["despawnMessage"] = Language.GetTextValue("Mods.AFKPETS.NPCs.SecurityBot.BossChecklistIntegration.DespawnMessage")
						}
					);

					bossChecklist.Call(
						"LogBoss",
						this,
						"PoliticianSlime",
						11.02f,
						() => AFKPetsWorld.downedPoliticianSlime,
						ModContent.NPCType<PoliticianSlime>(),
						new Dictionary<string, object>
						{
							["spawnItems"] = ModContent.ItemType<GoldenKingSlimeIdol>(),
							["spawnInfo"] = Language.GetTextValue("Mods.AFKPETS.PoliticianSlime.BossChecklistIntegration.SpawnInfo"),
							["despawnMessage"] = Language.GetTextValue("Mods.AFKPETS.PoliticianSlime.BossChecklistIntegration.DespawnMessage")
						}
					);
				}
			}			
		}
		public static void LocalizeMethod_LocalizeAll(string targetModName)
		{
			TigerForceLocalizationHelper.LocalizeAll(nameof(AFKPETSandmorezhcn), targetModName, registerKey: false, "Mods.AFKPETSandmorezhcn");
		}
	}
}