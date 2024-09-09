using Terraria;
using Terraria.ModLoader;
using AFKPETS.NPCs.BiomeNPCs;
using AFKPETS.NPCs.Antony;
using AFKPETS.NPCs.MiniGameNPCs;
using AFKPETS.NPCs.Misc;
using AFKPETS.NPCs.RoyalHarpyAirForce;
using AFKPETS.NPCs.SecurityBot;
using AFKPETS.NPCs.TownNPCs;
using AFKPETS.NPCs.TravellingNPCs;

namespace AFKPETSandmorezhcn.GlobalTranslation
{
	public class NPCText : GlobalNPC
	{
		public override void GetChat(NPC npc, ref string chat)
		{
			int Nurse = NPC.FindFirstNPC(18);
			int Dryad = NPC.FindFirstNPC(20);
			int Guide = NPC.FindFirstNPC(22);
			int Clothier = NPC.FindFirstNPC(54);
			int Pirate = NPC.FindFirstNPC(229);
			int WanderingSamurai = NPC.FindFirstNPC(ModContent.NPCType<WanderingSamurai>());

			if (npc.type == ModContent.NPCType<NecromancerDummyNpc>())
			{
				if (chat == "Greetings human. My name is Antony. Hey don't look me like that. I'm not a reanimated dummy and I call him Bede. I'm actually a child trapped inside of my friend but I'm not sad. It allow me to visit any place I want without any trouble and I can help any human that need help. Wait, do you have any knowledge about self protection? If you don't have I will help kindly.")
					chat = "你好啊，泰拉人！我叫安东尼。嘿，别那样看着我。我可不是什么妖魔鬼怪，实际上，我是一个被困在我的人偶朋友贝德身体里的孩子。但我并不难过，这让我能够毫无麻烦地去任何我想去的地方，我可以帮助任何需要帮助的泰拉人。等等，你知道应该怎么在这个危险的泰拉世界里保护自己吗？如果不知道，我会很乐意教会你。";
			}

			if (npc.type == ModContent.NPCType<Assassin>())
			{
				switch (chat)
				{
					case "Look what I see here. Is there anything I can help with you?":
					chat = "看看我在这找到了谁。有什么我可以帮助你的吗？";
					break;
					case "I may look more like a bandit but trust me it's because I'm ordered to not hurt you or else the last think you hear after your thoat have slicen open is my breath.":
					chat = "我可能看起来更像一个五大三粗的强盗，但相信我，这是因为我被命令不要伤害你，不然在你丢掉小命之前记得的最后一件事就是我的呼吸。";
					break;
					case "Why the monsters not attack me? They know my inside is more primal than them so they are protecting themselves from that.":
					chat = "为什么那些怪物不攻击我？因为我比它们可怕的多，它们在保护自己免受伤害。";
					break;
					case "I know we are called assassin but that still sounds too exotic for me.":
					chat = "我知道你们泰拉人喜欢叫我刺客，但这个称呼对我这样谦逊随和的人来说太高调了。";
					break;
					case "Don't look me like that? I was not like this before. I used to live in a town along with many other hunters but after the kingdom sent governor to increase taxes and show their domination my people start to die from hunger and then I join the orderChief tell me that she got rusted and so show me how the job be done. I still remember how cool the chief is. She have single handedly kill all of the royal guardians and then let me kill governor slowly and painfully. After that my heart start beating for them.":
					chat = "别那样看着我？我以前不是这样的。我曾经和许多其他猎人一起住在一个小镇上，但在国王派来总督增加税收并开始他们的残暴统治后，我的同胞开始因饥饿而死亡，然后我加入了教团。导师告诉我她已年岁不在，但愿意为我示范该如何去结束这一切。我仍然记得导师的飒爽英姿，她单枪匹马地杀死了所有的皇家守卫，然后让我慢慢地在痛苦中杀死总督。从那以后，我就开始为他们而战了。";
					break;
					case "I never understand why some ladies wear less armor for agility? You can get faster with artifacts as well and for me the armor is for protecting your body when a paladin tries to crush it with its hammer. Trust me I know how it feels to hit with holy weapon.":
					chat = "我永远不会理解为什么有些女士为了敏捷而穿更少的盔甲？你也可以用饰品来加速，对我来说，盔甲是为了在圣骑士试图用锤子碾碎你的身体时保护自己。相信我，你不会想知道被那玩意击中是什么感觉。";
					break;
					case "Our chief is quite pleased with your service. That child filled with chemicals and weird toys be a much trouble to the order of chaos. You know the most dangerous predator is the one you can't see and his ambushes with countless chemical hurts especially when he's flying with his jetpack. Chief is quite amazed by how strong he get after we raid his town and beat down their force with ease. Still I don't think he's wrong and still feel sad that he didn't get his revenge. We need to punish the corrupted ones but I feel we are punishing everyone.":
					chat = "导师对你的表现十分满意。那个一身化学物质和奇怪玩具的孩子给混沌教团带来了很大的麻烦。你知道最危险的捕食者是你看不到的那个，他用无数的化学物质伏击我们，尤其是当他带着喷气背包飞行的时候麻烦更大了。在我们袭击了他的基地并轻松击败了他们的军队后，导师对他变得这么强大感到惊讶。尽管如此，我不认为他错了，仍然为他没有复仇而感到难过。我们需要惩治腐败的人，但我觉得我们正在惩罚所有人。";
					break;
					case "The order of chaos once named as order of justice and we work for the king to be his sword to punish the corrupted nobles which cannnot be done politically but after the kingdom get weaker our ancestors choose to do the punishment by themselves.":
					chat = "混沌教团曾经被称为维序者，那时我们为国王工作，成为他的剑，惩罚那些无法通过政治手段惩治的腐败贵族。但随着王国的衰落，我们的先辈选择自我放逐。";
					break;
				}
			}

			if (npc.type == ModContent.NPCType<Assistant>())
			{
				switch (chat)
				{
					case "Wait, a human in the lands of Lady Moira? I suggest you to keep your distance with everything since for demonic lifeforms human meat is pretty valuable.":
					chat = "等等，莫伊拉夫人的土地上有泰拉人？我建议你和一切事物都保持距离，因为对于恶魔来说，人肉是非常宝贵的材料。";
					break;
					case "How interesting that after seeing so much universal insident our planet is still in one piece. Maybe its because of their protection. You ask who I'm talking about. If you continue your path you will meet them soon, really really soon...":
					chat = "看到如此多的宇宙灾难后，我们的星球仍然完好无损，真是有趣。也许这是因为他们的保护。你问我在说谁？如果你继续前行，你很快就会遇到他们的，真的很快...";
					break;
					case "Once these homes are built for the human slaves that are kidnapped and being carried from surface to do the low jobs in the unholy kingdom of demon lord Zerokk. After he wage war with angels he used the human slaves as meat shield and since houses are empty and demon population have damaged you can predict which side have won the war.":
					chat = "一旦这些为被绑架的人类奴隶而建的房屋完成，他们将从地表被运送到恶魔领主泽罗克的邪恶王国去做低贱的工作。在恶魔领主与天使交战之后，它利用人类奴隶作为肉盾。现在房屋空置，恶魔数量减少，你可以猜到哪一方最后赢得了战争。";
					break;
					case "I know its hot here but safety comes first. So never try to take your armor off or things may not end well. Me? I have his protection along with my own holy protection spells":
					chat = "我知道这里很热，但安全是第一位的。所以永远不要试图脱下你的盔甲，否则可能发生不测。至于我？我有他们的保护和我自己的神圣防御魔咒。";
					break;
					case "Why you see no succubus? Well after the era of demon king Zerokk ends the era of succubus queen Moira started and succubusses start to use demons for low jobs such as guarding areas and carrying desired things while they start to live in mansions once being used by demon generals.":
					chat = "你之所以看不到魅魔，是因为在恶魔王泽罗克的时代结束后，魅魔女王莫伊拉的时代开始了。在这个新的时代里，魅魔们开始奴役恶魔来执行一些低贱的工作，比如守卫区域和搬运它们想要的东西。与此同时，魅魔们开始居住在曾经恶魔将军们的豪宅里。";
					break;
					case "It's much nicer to make trades with any lifeform other than succubusses. That desire driven lifeforms look at your eyes with such lust you start to sweat and look for any way to escape.":
					chat = "与除了魅魔以外的任何生命进行交易都要愉快得多。那些被欲望驱使的魅魔用眼睛直勾勾地盯着你，你会汗流浃背并寻找任何能从它们面前逃跑的方法。";
					break;
					case "I miss making experiments about the higher dimentional fabric of the universe with my professor. I wish he could fix the time and space interval soon and return back to his cute little house but knowing what happened in voidal incident I feel that would be a dream.":
					chat = "我怀念和教授一起进行关于宇宙高维度结构的实验。我希望他能尽快修复时间和空间的间隔，带我回到他可爱的小房子。但在虚空事件发生后，我觉得这愿望只能在梦里想想了。";
					break;
					case "Do you tell me you see a ghost named Tao-Yi? OMG. She is the head assistant of our laboratory and I still remember her smile first time I short circuited a chip and nearly cause a nuclear explosion. I wish holy knights of terra didn't believe she is a witch and burn her alive after the proffessor go for fixing things. I will never forgive them and if there are no innocent people live in their castle I will burn every square of the kingdom with holy flames and return it to a wasteland.":
					chat = "你是说你看到了一个名叫陶伊的鬼魂吗？天啊。她是我们实验室的首席助教，我还记得我第一次短路芯片差点引发核爆炸时她的笑容。我希望泰拉圣骑士不会觉得她是一个女巫，并在教授离开后活活烧死她。如果他们这么做了，我永远也不会原谅。如果城镇里没有无辜的人，我会用神圣的火焰焚烧这里的每一寸土地，将其带回荒芜。";
					break;
					case "Do you ever tried to head pat the baby imps? After a while the lifeforms in these lands accept me as a native just like them and not show any expression of fear being near to me so I have tried and it calms your soul. I suggest you to try if they act nice to you.":
					chat = "一段时间后，这片土地上的生命接纳了我，看到我时不再露出恐惧，就像我是土生土长的本地人一样。你试过摸恶魔宝宝的头吗？这可以平静你的灵魂。我建议你也试试，如果恶魔们待你友善的话。";
					break;
				}
			}

			if (npc.type == ModContent.NPCType<HolyKnight>())
			{
				switch (chat)
				{
					case "When they said I will investigate dungeon I expect to fight against hordes of enemy and stop the era of the cultist but they send me to collect anything valuable. I guess my dream will wait for some more time.":
					chat = "当他们派我前往地牢执行任务时，我希望与成群的敌人作战，阻止邪教的降临。但他们只是派我去收集有价值的宝贝不。我想我的愿望还得等一段时间才能实现了。";
					break;
					case "Wait, are you really a human? After seeing so much skeleton you miss to see and talk with a real human.":
					chat = "等等，你是活人吗？在看过这么多骸骨后，你会怀念与真人面对面交谈的机会。";
					break;
					case "I used to fight against the order of chaos and I have nearly beaten a high tier assassin with my holy hammer but I never expect an assassin to wear armor so she survived.":
					chat = "我曾经与混沌教团作斗争，我几乎用我的圣锤碾碎了一个高级刺客，但我从没想过一个刺客竟然会穿盔甲，所以她侥幸活了下来";
					break;
					case "I sometimes take direct hit from monsters to see how it feels before I crush them.":
					chat = "在击败怪物之前，我有时会故意承受他们的攻击，看看受伤的感觉如何。";
					break;
					case "Do you ever wonder what happens if a demon king takes you as a slave? Since underworld is currently being ruled by a succubus I think I never know.":
					chat = "你有没有想过，如果恶魔领主把你当奴隶该怎么办？因为目前地狱是由魅魔女王莫伊拉统治的，我想我永远也不会知道。";
					break;
					case "I feel sad for these people. Even tough cultist rip their skeleton from their flesh and reanimate with necromancy they still contain shattered memories and they often look they are missing their family and friends.":
					chat = "我为这些人感到难过。即使邪教徒把他们的骨头从肉里撕出来，用巫术复活，他们仍然保留着破碎的记忆。他们常常看起来像是失去了家人和朋友的活人。";
					break;
					case "These beings are once human which are living in both towns and cities but they are being collected and slaughtered by cultists to be used as army for both in the great war against slimes and against anything that will become obstacle to them.":
					chat = "这些生物曾经是生活在城镇和城市的人类，但他们被邪教徒所屠杀，用于在战争中对抗史莱姆王国和任何可能阻碍他们的东西。";
					break;
					case "Remember my words if you see a maniac lady with half blue and half yellow hair don't look your back and run away.":
					chat = "记住我的话，如果你看到一个一半蓝色一半黄色头发的疯狂女人，不要回头，快跑。";
					break;
					case "One of my side quest is saving one of the lost mechanic so if you found her could you free her?":
					chat = "我的一个支线任务是拯救一位失踪的机械师，所以如果你找到她，你能把她解救出来吗？";
					break;
				}
			}

			if (npc.type == ModContent.NPCType<Researcher>())
			{
				switch (chat)
				{
					case "Greeting human. I'm M.A.Y.A. .Is there anything I could do for you?":
					chat = "你好泰拉人。我叫玛雅。我能为你做点什么吗？";
					break;
					case "Well, my name is given by both my mother and professor and it stands for 'Most Advance Yet Acceptable'.":
					chat = "嗯，我的名字是我母亲和教授给我起的，代表“最先进但可接受”。";
					break;
					case "Sorry human but my emotion chip is not as advance as lady of light. I can only feel happiness and sadness while she can simulate all of the complex emotional feelings.":
					chat = "抱歉，泰拉人。我的情感芯片并不像光明女士那样先进。我只能感受到快乐和悲伤，而她却能模拟所有复杂的情感感受。";
					break;
					case "Wait, do you know SATLA? I have heard its name from professor and she tell that a virus is putten inside of her by martans to hack both its mind and perception which cause it to hunt for fun.":
					chat = "等等，你知道 SATLA 吗？我从教授那里听说过它的名字，她说马丁人把一种病毒放在她的大脑里，以破解她的大脑和感知功能，导致她为了取乐而四处猎杀。";
					break;
					case "Actually I'm a self aware robot and robots have no biological production but I prefer to be called as she since I feel myself as an elegant lady with proper genetics and engineering knowledge.":
					chat = "实际上，我是一个有自我意识的机器人。虽然机器人不算是生命体，但我更喜欢被称为“她”，因为我觉得自己是一个有着丰富遗传学和工程学知识的优雅女性。";
					break;
					case "Sometimes I also see dreams but I'm not sure if I actually see them or professor just programmed me so that I see some images while I'm resting":
					chat = "有时我也会做梦，但我不确定我是否真的看到了它们，或者只是教授在我休息时编写程序的一些图像。";
					break;
					case "Do you ask who is the professor? She is called lady of light in these lands and she is the mastermind behind me and sadly mechanical trio but she design their ai to make them protect the Earth when martians attack and then cultists stole them by force and force a human to make them body and fuse these things shattered souls to make them go for blood.":
					chat = "你问谁是教授吗？在这片土地上，她被称为光明女士，她是我和可怜的旧日三重唱的设计者。她调整了旧日三重唱的AI逻辑，让他们保护泰拉世界免受火星人的攻击。但邪教徒偷走了他们，强迫机械师为他们制作了身体，融合了地牢的破碎灵魂，让他们变成了杀戮机器。";
					break;
					case "I'm here to make research about the ancient civilizations one lived in these places. It's sad to see humans attack and cause extinction against the people think different then them.":
					chat = "我来这里是为了研究曾经生活在这些地方的古老文明。看到泰拉人攻击并灭绝与其思想不同的文明，真是令人难过。";
					break;
					case "If you ever visit jungle and see a neko quantum scientist could you tell that I miss designing circuit with him.":
					chat = "如果你在丛林看到一个量子科学家，你能告诉他我很想和他一起设计电路吗？";
					break;
				}
			}

			if (npc.type == ModContent.NPCType<AquaticWiseman>())
			{
				switch (chat)
				{
					case "It's nice to meet you adventurer. After I watch the around some more I will return back to where I come from.":
					chat = "很高兴认识你，冒险家。我再多看几眼后，就会回到我来的地方。";
					break;
					case "I expect no less from an adventurer like you. The strength is the combination of both brain, heart and muscles and by both showing mercy to that fish and your skills at challenge I shall bestow my respect to you with this.":
					chat = "我对你这样的冒险家也抱有同样的期望。力量是智慧、心灵和身体的结合，通过你对那条鱼的仁慈以及在挑战中展示的技巧，我在此向你致敬。";
					break;
					case "You are not bad but also not what I expect from the chosen one. Still as showing my respect to my lord Blossom's decision please accept this as a gift for your further journey.":
					chat = "你变表现的还不错，但不是我所期望的那个人。不过，鉴于对我领主布洛森决定的尊重，请接受这份礼物，作为你未来旅程的礼物。";
					break;
					case "I'm sorry but I'm slightly disappointed by that. I have heard stories of you from the mermaid scouts and I didn't expect you to be defeated this fast. Still I can see the light in your eyes so I believe in time you will get much better.":
					chat = "我很抱歉这么说，但我感到有些失望。我从美人鱼侦察兵那里听说过你的故事，我没想到你会这么快就被打败了。不过，我能看到你眼中的光芒，所以我相信随着时间的推移，你会变得更好。";
					break;
					case "I never expect such an elegant move from any human. Wait, you are... Greetings adventurer. The name is Noelani and I'm being sent by lord Blossom to further analyse the marine lifeforms. I have heard your bravery so I also want to see what you can do with my eyes. If you accept I would like to challenge you in a minigame.":
					chat = "我从没期望过任何人类能做出如此优雅的动作。等等，你是……你好，冒险家。我叫诺埃拉尼，奉领主布洛森之命，前来进一步分析海洋生物。我想看看你是不是真如传说中那么勇敢，如果你接受的话，我想在迷你游戏中挑战你。";
					break;
				}
			}

			if (npc.type == ModContent.NPCType<ErrorFallenAngel2>())
			{
				switch (chat)
				{
					case "Important! Read Carefully!!":
					chat = "这很重要！仔细阅读！！";
					break;
					case "LOVE-LETTER-FOR-YOU":
					chat = "";
					break;
					case "LOVER ALERT":
					chat = "";
					break;
					case "CRITICAL_HEART_DIED":
					chat = "";
					break;
					case "SYSTEM_LOVER_EXCEPTION":
					chat = "";
					break;
				}
			}

			if (npc.type == ModContent.NPCType<GameGenie>())
			{
				switch (chat)
				{
					case "Do you want to fight me? Well I am 4 Parallel Universes ahead of you...":
					chat = "你想挑战我吗？我比你领先四个个平行宇宙……";
					break;
					case "Those shining eyes... I have similar spirit with you but I have seen the end. I have a elegant yet warrior spirited master and we try to bring justice to this world but they... I guess its best for me to rest my soul with these games since I cannot forgive myself to not being able to protect her.":
					chat = "那双闪闪发光的眼睛……我有着和你相似的经历，但我已经迎来了结局。我曾经有一位优雅但充满战士精神的大师，我们试图为这个世界伸张正义，但……我想我最好在这些游戏中休息一下，因为我无法原谅自己无法保护她";
					break;
					case "Your speed and power is only temporary but mine builds for eternity...":
					chat = "你的速度和力量只是暂时的，但我的是永恒的……";
					break;
					case "The Scuttlebug is the key to the Multiverse so if you find one never throw it away.":
					chat = "疾行虫是多元宇宙的关键，所以如果你找到了，永远不要把它扔掉。";
					break;
					case "Do you ever go out of bounds? I have seen a spirit, human and slime and being shattered until they are being saved by him but still they only exist in specific impulsive time and space coordinate. You ask who I talk about? Well, you will meet them soon, pretty pretty soon...":
					chat = "你曾经踏出过边界吗？我看到了一个灵魂，人类和史莱姆被粉碎，直到它们被他拯救，但它们仍然只存在于特定的超动时空坐标中。你问我在说谁？好吧，你很快就会见到他们，很快很快……";
					break;
					case "NOO!!! MY QPUS ARE MISALIGNED!! Wait I can position my qpus to raise another Scuttlebug from the U-137.":
					chat = "不！！！我的量子处理单元错位了！！等等，我可以重新定位它们，从U-137上升起另一只疾行虫。";
					break;
					case "This talk start to bore me. Now show your skils on the arcade machine.":
					chat = "这些对话开始让我厌烦了。现在去街机上展示你的滑雪技巧。";
					break;
				}
			}

			if (npc.type == ModContent.NPCType<GhostLady>())
			{
				switch (chat)
				{
					case "It's honour for me to meet with such a kind soul":
					chat = "我很荣幸能遇到这样一个善良的人。";
					break;
					case "You did good compared with skeletons but looking at you, I belive you can do much better":
					chat = "与骷髅相比你做得很好，但看着你，我相信你可以做得更好。";
					break;
					case "You may only answer correct one time but don't feel sad. By reading this nice book I believe next time we met you could do much better.":
					chat = "你可能只答对一次，但不要感到悲伤。看看这本书，我相信下次我们见面时你会做得更好。";
					break;
					case "You couldn't answer any question correct but don't feel sad you will prepare yourself and next time you will be much better":
					chat = "你没有正确回答任何问题，但不要感到难过。你会做好准备的，下次你会好得多。";
					break;
					case "It makes me feel really happy and honored to see such a wise person after months. I would like to share my happiness with you a little gift so please keep this book. I used to read it a lot but I feel I memorize every story so maybe I feel sharing it will be much better.":
					chat = "经过这么长时间的等待，终于看到这样一位智者，我感到非常高兴和荣幸。我想和你分享我的快乐，请收下这本书作为一个小礼物。我以前经常读它，但我觉得我记住了每一个故事，所以也许我觉得分享它会更好。";
					break;
					case "While I was wandering caverns I have found a wise wizard named Tim and he give me this relic as a gift for our friendship. After I meet with you I feel this will be a gift for our friendship like with that kind skeleton. It's filled with so many nice books so I believe it will put a smile on your face":
					chat = "当我在洞穴里游荡时，我发现了一个名叫蒂姆的聪明巫师，他把这件遗物送给我作为我们友谊的礼物。当我和你见面后，我觉得这将是我们友谊的礼物，就像我和那个善良的骷髅一样。里面装满了这么多好看的书，我相信它会让你满意。";
					break;
					case "Few weeks ago, I have found this cute little phantom wandering around frightened and seeking for home and I bring it with me and calm down but it seeks the adventures it had with its master which is a samurai before. Since I'm a assistant before they believe I'm a witch and kill me I want you to keep it and have fun together.":
					chat = "几周前，我发现这个小可爱在四处游荡，惊慌失措地寻找家。我把它带在身边好让它冷静下来，但它在寻找以前与主人（一名武士）的冒险经历。由于我是教授的首席助教，在他们相信我是女巫并杀了我之前，我想让你带走它，祝你们玩得开心。";
					break;
					case "Do you ever know some wizards use magic to form shelter rather than science. I also didn't know until I met a funny skeleton calls himself rune wizard. He show me how to do and even give me a spare tome. Since I live inside of the laboratory that my professor uses before things happen I believe it will be really helpful to you.":
					chat = "你知道吗？有些巫师用魔法而不是科技来建造庇护所。我也不知道，直到我遇到一个自称符文巫师的有趣骷髅。他教我怎么做，甚至给了我一本多余的书。由于我住在教授之前使用的实验室里，我相信这对你会更有帮助。";
					break;
					case "Sorry but I couldn't give any hint":
					chat = "对不起，我不能给任何提示。";
					break;
					case "Oh, your timing is perfect. I have been searching for the caves to share some knowledge in a quiz style. If you are interested could you tell me? If interested you will answer by '/answer [answer]'. For questions could you only use numbers in aswer like '/answer 5' as example and for others use no capital letters and in singular form like '/answer bat' and not '/answer bats' as example? Thank you for your patience and if you want lets get started.":
					chat = "哦，你出现的刚刚好。我一直在寻找以问答的方式来分享一些知识。如果你感兴趣，可以告诉我吗？\n你可以用“/answer 答案”的形式来回答。\n对于问题，你只能用数字提问，例如“/answer 5”。\n还有，你不能使用大写字母和复数，使用“/answer bat”，而不是“/answer BATs”。\n谢谢你的耐心，如果你准备好了，让我们开始吧。";
					break;
				}
			}

			if (npc.type == ModContent.NPCType<HunterDog>())
			{
				switch (chat)
				{
					case "That hunt was fun partner.":
					chat = "你是个很有趣的狩猎伙伴。";
					break;
					case "Hey. Stop talking and show them who is boss.":
					chat = "嘿，别说话了，让他们看看谁才是老大。";
					break;
					case "Not bad at all but you need to practise on your aim.":
					chat = "还不赖，但你需要练习你的瞄准。";
					break;
					case "The bullets you shoot cost more than the prey we get. Next time shoot the ducks not the sun.":
					chat = "你射出的子弹比我们得到的猎物还贵。下次记得射鸭子而不是太阳。";
					break;
					case "Wait, you don't have a knife to dividing the valuable meat? Borrow this one and after the division you can keep it for yourself. I could always make another one for myself.":
					chat = "等等，你没有刀来分这珍贵的肉吗？给你这把，分完后你可以自己留着。我可以再为自己做一把。";
					break;
					case "Your style remind me of someone I really care of. I was not a lone wolf. We go hunts with my master and I never see he miss any shot. While he never misses the life span also don't miss. Even tough time flows so cruel still I miss him so much and your style remind me of him so I want you to keep his gun.":
					chat = "你的风格让我想起了某个我非常关心的人。我并不是孤犬。我和我的主人一起狩猎，我见证了他的每一次射击。他从不浪费时间，生命也不容错过。即使时间流逝得如此残酷，我还是非常想念他，而你让我想起了他，所以我希望你能带上他的猎枪。";
					break;
					case "Do you every think more eyes increase precision? Well I did but it didn't go well. So I want you to keep this to try if it will work for you or not.":
					chat = "你有没有想过多只眼睛会瞄的更准？我确实想过，但结果并不理想。所以我想让你留着这个试试看是否对你有用。";
					break;
					case "Don't you also smell something juicy. Don't look me like that. We eat therefore we hunt. So let's make a deal. I call those birds and you shoot'em down. Why not me? Well, I enjoy freaking them out by myself. So me as mind and you as muscle we will be nice team and after hunt we will divide the prey.":
					chat = "你不也闻到了些美味的气息吗。别那样看着我。我们为了吃而狩猎。所以让我们做个交易。我把那些鸟赶飞，你把它们射下来。为什么不是我去射？嗯，因为我喜欢吓唬它们。我出工，你出力，我们会是出色的团队，狩猎后我们会平分猎物。";
					break;
				}
			}

			if (npc.type == ModContent.NPCType<RoyalGuard>())
			{
				switch (chat)
				{
					case "Greetings. After the heroic acts you did the kingdom have sent me to both assist and support your journey.":
					chat = "你好，在目睹你的英勇之举后，王国派我来协助你后续的旅途。";
					break;
					case "You should drink different type of potions if you want battles become more easy.":
					chat = "如果你想让战斗变得更容易，你应该尝试使用不同类型的药水。";
					break;
					case "Never trust the hunters of order of chaos. They are once being formed by kingdom to assassinate mafia and other high order corrupted people but after in decades they start to see themselves higher than kingdom and our king so they start to go against our aims. They even support the enemies of kingdom such as slimes.":
					chat = "永远不要相信混沌教团的人。他们曾经是由王国组建的，目的是惩治私党和其他腐败分子，但在几十年后，他们开始认为自己比王国更重要，于是开始反对我们。他们甚至支持我们的敌人，如史莱姆。";
					break;
					case "It's honor to meet a person like you. Thanks to you know our travelling merchants have travel safely.":
					chat = "很荣幸能遇到你这样的人。感谢你保护我们的旅行商人。";
					break;
					case "Greeting adventurer. Is there anything you need?":
					chat = "你好，冒险家。你需要什么吗？";
					break;
				}
			}

			if (npc.type == ModContent.NPCType<TiedYandere>())
			{
				switch (chat)
				{
					case "*Blushes* You just kill him for me. Well I never expect a stranger to do such thing for someone that live in shadows. If you also help me to untie this rope, I would be really grateful.":
					chat = "*脸红* 你是为了我杀了他。我从没想过一个陌生人会为生活在阴影中的人做这样的事。如果你也帮我解开这根绳子，我将不胜感激。";
					break;
					case "Hey! Before that weirdo returns could you untie these me? Normally I wouldn't be beaten by some golden nerd but he sure knows how to ambush...":
					chat = "嘿！在那个怪人回来之前，你能帮我解开这根绳子吗？通常我不会被那个金发讨厌鬼打败，但这次它学会伏击了……";
					break;
				}
			}

			if (npc.type == ModContent.NPCType<BoundGuardian>())
			{
				switch (chat)
				{
					case "You do a terrible mistake":
					chat = "你犯了一个可怕的错误";
					break;
				}
			}

			if (npc.type == ModContent.NPCType<JumpscareFella>())
			{
				switch (chat)
				{
					case "You are an Idiote":
					chat = "你这蠢货";
					break;
				}
			}

			if (npc.type == ModContent.NPCType<BossHunterMerchant>())
			{
				if (Dryad >= 0 && chat == "Why is " + Main.npc[Dryad].GivenName + " not selling any weapon?")
					chat = "为什么树妖不售卖任何武器？";

				switch (chat)
				{
					case "In times like this don't try to fight against stronger enemies without preparing first":
					chat = "在血月，不要贸然与更强大的敌人作战，要事先做好准备。";
					break;
					case "*laughts* Everywhere filled with blood and guts , how nice isn't it?":
					chat = "*大笑* 到处都是鲜血和内脏，多好啊，不是吗？";
					break;
					case "Hehehe... Unlike traditional knowledge blood moon have no connection with the crimson. It's existence is far from the remnants of that squid.":
					chat = "呵呵……不同于传统观念，血月与猩红毫无联系，它的存在与那只乌贼也相去甚远。";
					break;
					case "Legends tell after the death of many and born of one have caused the blood moon to rise with for the sinful ones.":
					chat = "传说，众死一生之际，血月因罪人而升起。";
					break;
					case "Isn't the moon look beautiful? I used to watch her with all of her glory in old days.":
					chat = "血月不是很美吗？我以前总是看着它，欣赏它所有的光辉。";
					break;
					case "*puts an eyeball in jar* Why you look so horified adventurer? You never sure who will visit you tonight":
					chat = "*将眼球放入罐子中* 冒险者，你为什么看起来这么害怕？你永远不知道今晚谁会来拜访你。";
					break;
					case "I suggest don't visit the other people in days like these. The light of moon have bad effect on some of the lifeforms":
					chat = "我建议这几天不要去拜访别人了。血月对某些生命有可怕的影响。";
					break;
					case "Show that martians what humans are capable of.":
					chat = "给那些火星人看看，咱泰拉人有多能干。";
					break;
					case "After you assassinate all of the important slimes of fourth kingdom I don't think Capital will continue to be kind against humans.":
					chat = "在你暗杀了史莱姆王国四分之一的重要人物后，我不认为它们会继续对泰拉人保持友善。";
					break;
					case "I used to search the book which Shinigami's use in legends and I archieve to find it but I afraid of it's potential and sealed it to the devourer of fools. What you ask me how to find it, well I can't tell this to you.":
					chat = "我曾经寻找过传说中死神使用的那本书，并成功地找到了它。但我害怕它的力量，所以将它封印在了‘愚者的吞噬者’之中。你问我怎么找到它？很抱歉，我不能告诉你。";
					break;
					case "You ask me how to form the dream as an effect egg? Well, for that you need to have the diary and bound the dreams with the soul of mechanical bosses and some dark soul to bound it with the terror of nightmares which may be free after their master will be defeated.. Also you need to feel like Madotsuki for that which you need to have cursed debuff and be near to bed.":
					chat = "你问我如何将梦境塑造成一个彩蛋？嗯，要做到这一点，你需要有日记，并用机械Boss魂和一些黑暗之魂来束缚梦境，用噩梦的恐怖来束缚它们，这样当它们的主人被打败后，它们可能会自由。此外，你需要有和Madotsuki一样的感受，这需要你拥有诅咒减益，并靠近床边。";
					break;
					case "I like turtles.":
					chat = "我喜欢龟龟。";
					break;
					case "Wait you tell me he can make spagetti? Man, I miss eating those in the kingdom.":
					chat = "等等，你是说他会做意大利面吗？天哪，我好怀念在王国里吃意大利面的日子。";
					break;
					case "I love the kind of woman that can kick my ass. I feel you also love too.":
					chat = "我喜欢那种能踢我屁股的女人。我觉得你也一样。";
					break;
					case "One of many species being carried to these lands by lord Yrimir. Man, I miss him so much.":
					chat = "这是伊里米尔领主带到这些土地上的众多物种之一。伙计，我太想他了。";
					break;
					case "Isn't that man look a little...Purple? I'm not sure what happened but I feel I shouldn't ask.":
					chat = "那个人看起来是不是有点……紫紫的？我不太确定发生了什么，但我感觉我不应该问。";
					break;
					case "I'm always curious if white mages get PhD for the heal magic?":
					chat = "我一直很好奇白袍法师是否能获得治疗魔法的博士学位？";
					break;
					case "Legends says in the end it will rise the ancient cult once again.":
					chat = "传说总有一天古老的邪教会卷土重来。";
					break;
					case "Do you ever think to wash your pet?":
					chat = "你想过给你的宠物洗澡吗？";
					break;;
					case "You know elder said don't play with your food but interestingly it seems you become friend with it.":
					chat = "你知道长辈说不要玩你的食物，但有趣的是，你们似乎和它成了朋友。";
					break;
					case "Do NOT touch that *strange box falls to floor* .XANXXE 1NT3GR1T13S : % 042.01 DANGER! BRAIN DAMAGE! Ouch! Ouch! OUCH! RETRY!":
					chat = "不要碰那个 *奇怪的盒子掉到地板上* 危险！危险！嗷！嗷！啊！";
					break;
					case "You two looking for a which. Sorry but all I see today is some frozen frogs.":
					chat = "你们在找什么呢？抱歉，但今天我看到的只是一些被冻僵的青蛙。";
					break;
					case "Young lady you definitely exercise more.":
					chat = "小姐，你肯定经常锻炼。";
					break;
					case "I'm really curious about one thing. What's the difference between the nether,netherland and netherworld?":
					chat = "我真的很好奇一件事。河南、荷兰和很难之间有什么区别？";
					break;
					case "OMG SO CUTE.":
					chat = "哦我的天啊，太可爱了！";
					break;
					case "A walking rad bullet. I feel I have drank enough today.":
					chat = "一颗会走路的子弹。我今天一定是喝多了。";
					break;
					case "It's honor to meet a peaceful person like you in this world . It's always nice to see people that are aganist to fight but in this world you can't try to make a tea party with moon lord dear lady.":
					chat = "在这个世界上能遇到像你这样平和的人真是荣幸。看到那些反对争斗的人总是令人愉快的，但在这个世界里，亲爱的女士，你不能试图与月之领主举办茶话会。";
					break;
					case "Do you ask who are mudkip warriors? They are ambassadors of Lord Derpo.":
					chat = "你在问什么是泥鳅战士吗？它们是亘古领主的大使。";
					break;
					case "Aw, look at this cute kitty. Do you want some fish?":
					chat = "啊，看看这只可爱的小猫咪。你想要一些鱼吗？";
					break;
					case "How can a robot be this beautiful and elegant?":
					chat = "一个机器人怎么可能如此美丽和优雅？";
					break;
					case "You remind me one of my old friend ... Wait is that you Alice? I miss you so much. After I heard what have done to you from your father, I slaughter every cultist I see but I can't find you. Adventurer thank you so much. Also you can buy what you want and put money there we will talk about past.":
					chat = "你让我想起了我的一位老朋友……等等，是你吗，爱丽丝？我非常想念你。自从我从你父亲那里听说他们对你做了什么之后，我看到一个邪教信徒就杀一个，但我始终找不到你。冒险者，非常感谢你。另外，你可以买你想要的东西，把钱放在那里，我们之后再聊过去的事。";
					break;
					case "Look at her cuteness. I don't even think that making hybrid species from cat and rabbit can be possible":
					chat = "看看她多可爱。我从未想过猫和兔子的杂交是可能的。";
					break;
					case "How you even find it? Legends tell that it was once built with the power of the ancient lord Blah. Maybe one day he will return to control this lands one more time.":
					chat = "你是怎么找到它的？传说它是由亘古领主Blah的力量建造的。也许有一天他会回来再次控制这片土地。";
					break;
					case "Is that thing a real bomb?":
					chat = "那东西真的是炸弹吗？";
					break;
					case "Shatter the sun or not shatter the sun, I think that's something philosophical rather than rational.":
					chat = "粉碎太阳还是不粉碎太阳，我认为这是一个哲学问题而非理性问题。";
					break;
					case "What an interesting magician but still I'm not sure how can it protects its form.":
					chat = "多么有趣的魔术师啊，但我还是不确定它是如何保护自己的。";
					break;
					case "Disturbing Sun and Moon is prohibited in this world.":
					chat = "在这个世界上，扰乱太阳和月亮是被禁止的。";
					break;
					case "Maybe there is still coin left in it.":
					chat = "也许里面还有钱币。";
					break;
					case "Once upon a time there was a ancient culture of half men and half fox. This culture is shaped with the mysticism of nature and art of the rainbow. In that time they have taken their power and wisdom from their lord Fabsu. Eventhrough the time has flowed so cruel, shine of knowledge obtained from her still brightens the path of tinkerers.":
					chat = "很久很久以前，存在一个由半人半狐组成的古老文明。这个文明以自然的神秘主义和彩虹的艺术为特色。在那个时候，它们从领袖法布斯那里获得了力量和智慧。尽管时光无情地流逝，从她那里获得的知识之光仍然照亮了工匠们的道路。";
					break;
					case "He look like a little cubic but still he looks dangerous.":
					chat = "它看起来像个小立方体，但仍然显得很危险。";
					break;
					case "Sorry but you should ask dryad for more berries since I'm out of power berries.":
					chat = "对不起，但是你应该向树妖要更多的浆果，因为我这里没有光莓了。";
					break;
					case "Thank you for cleaning my room.":
					chat = "感谢你打扫我的房间";
					break;
					case "This cute species once brought by ancient warlord Audrina2k to bless the hearts of these people with the kindness which they carry deep inside their souls.":
					chat = "这些可爱的小家伙被古代的战争领主Audrina2k带来，用它们灵魂深处所携带的善良来祝福这些人们的心灵。";
					break;
					case "Sorry but I'm not spinning the world. Maybe you should visit nurse.":
					chat = "对不起，但不是我在推动这个世界。也许你应该去看看护士。";
					break;
					case "Is the room temperature increased? It's kinda getting hot here.":
					chat = "房间温度升高了吗？这里似乎越来越热了。";
					break;
					case "How a weapon can be both melee, ranged and throwing?":
					chat = "一件武器怎么能同时是近战、远程和投掷？";
					break;
					case "Where did you meet with these ladies?":
					chat = "你在哪里见过这些女士的？";
					break;
					case "Lucky to you I have 50% discount on the bakameters only for today. Maybe they make help you find someone you lost.":
					chat = "幸运的是，今天有半价折扣。也许它们能帮你找到你失去的人。";
					break;
					case "How they can live outside of the water?":
					chat = "没有水，它们是怎么活下来的？";
					break;
					case "I also feel happy to see the spring, I think we should celebrate it.":
					chat = "我也很高兴看到春天，我想我们应该庆祝一下。";
					break;
					case "She may be not the tallest but she's the kindest and strongest guardian angel I have ever seen.":
					chat = "她可能不是最高的，但她是我见过的最善良、最强壮的守护天使。";
					break;
					case "Wait, are these are hidden blades? Oh man they look so cool.":
					chat = "等等，这些是隐藏的刀刃吗？天啊，它们看起来很酷。";
					break;
					case "Sorry, I can't give you credit. Come back when you are a little mmm... Richer.":
					chat = "对不起，我不能相信你。等你更……富有的时候再来.";
					break;
					case "How can one even sit on it?":
					chat = "一个人怎么能坐在上面呢？";
					break;
					case "Sorry but I don't have any medicine. Maybe nurse helps you.":
					chat = "对不起，我这没有药。也许护士会帮你。";
					break;
					case "I hope you know that thing you carry as a pet is bomb.":
					chat = "我希望你知道你在把炸弹当宠物。";
					break;
					case "Wait, what? I feel I should stop drinking buff potions.":
					chat = "等等，什么？我觉得我应该停止喝增益药水了。";
					break;
					case "It may look small but legends tell that it's capable of beating moon lord in an eye blink.":
					chat = "它可能看起来很小，但传说它能在眨眼间击败月亮领主。";
					break;
					case "Crows used to be mind controlled by stronger creatures but when ancient warlord Nand save them from tyranny of Pumpking they start to built their own culture":
					chat = "乌鸦曾经是被更强壮的生物奴役的，但当远古领主Nand将它们从南瓜王的暴政中拯救出来时，它们开始建立自己的文明";
					break;
					case "EWW.":
					chat = "嗯……";
					break;
					case "Your strenght is impressive but it seems someone missed the math class for the pattern strategy.":
					chat = "你的实力令人印象深刻，但似乎有人错过了模式策略的数学课。";
					break;
					case "Wait, what? When this happened. Don't look me like that adventurer.*He smiles* I wish both of you will find the true joy in your life.":
					chat = "等等，什么？这是什么时候发生的事？冒险者，别那样看着我。*他微笑着* 我希望你们两人都能在生活中找到真正的快乐。";
					break;
					case "Wait, What? I'm not sure if what I see is real or hallucination.":
					chat = "等等，什么？我不确定我看到的是现实的还是幻觉。";
					break;
					case "It's always nice to see scientists.":
					chat = "见到科学家总是高兴的。";
					break;
					case "Are you looking for a staring contest? If so my body is ready.":
					chat = "你是不是想找个人比瞪眼？如果是的话，我已经准备好了。";
					break;
					case "Wow, look at those muscles. Man, I really need to visit gym more often.":
					chat = "哇，看看那些肌肉。天哪，我真的需要更经常去健身房。";
					break;
					case "Aw, what a cute fairy. If you allow me ...*Blushes*... May I head pat you?":
					chat = "啊，多么可爱的小精灵啊。如果允许的话…… *脸红* ……我可以摸摸你的头吗？";
					break;
					case "I don't know why but be careful around her. I can feel a strong aura of dark arts from her.":
					chat = "我不知道为什么，但请小心她。我能从她身上感受到强烈的黑魔法气息。";
					break;
					case "My vision is only getting dark and darker...":
					chat = "我的视线变得越来越模糊……";
					break;
					case "What, you guys are looking for eggs? I don't think there is easter but still have fun searching them.":
					chat = "什么，你们在找彩蛋吗？虽然现在并不是复活节，但找彩蛋还是挺好玩的。";
					break;
					case "Wait, a lawyer in the lands of terraria? That's something new.":
					chat = "等等，泰拉瑞亚大陆上有律师？这可真新鲜。";
					break;
					case "What a kind ogre. I never expect to see an ogre act better than royal commanders.":
					chat = "真是个善良的食人魔。我从没想到会看到食人魔表现得比皇家禁卫军还要好。";
					break;
					case "Eyes of yours are filled with hate and madness. What happened to you?":
					chat = "你的眼中充满了仇恨和疯狂。你究竟经历了什么？";
					break;
					case "I guess O know what time is it.":
					chat = "我想你知道现在几点了。";
					break;
					case "A solar mechanism being made by the might of chief Bluescarab and knowledge of ancient warlord Mendeleev.":
					chat = "一种由蓝甲壳虫酋长的力量和亘古领主门捷列夫的知识共同制造而成的太阳能装置。";
					break;
					case "For finding treasures maybe spelunker potion will also help you.":
					chat = "为了寻找宝藏，也许探险药水也能帮到你。";
					break;
					case "Wait, are those real pink diamonds? I feel you should protect it from miners adventurer.":
					chat = "等等，那些是真的粉钻吗？我觉得你应该保护好它们，以防矿工和冒险者的侵扰。";
					break;
					case "I don't suggest you to listen their lies. Centuries ago our king have listened and it cost us to be weakened in this state.":
					chat = "我不建议你听信他们的谎言。几个世纪前，我们的国王曾听信过，结果导致我们国家陷入这种虚弱的状态。";
					break;
					case "It was once forged by the lord of the all Terraria enthusiasts. It was the guardian of his couch and his throne. That's why it still looks for it's master because of it's care and it want to have some nice time with him.":
					chat = "它曾经是由所有泰拉瑞亚爱好者的领主锻造的。它是他宝座和御座的守护者。这就是为什么它仍然在寻找它的主人，因为它关心主人，想要和他共度美好时光。";
					break;
					case "It looks like it will protect all Terraria enthusiasts for it's master. It looks like it's no longer holding it's power.":
					chat = "它似乎是为了它的主人而保护所有泰拉瑞亚爱好者的。但它看起来已经不再拥有它的力量了。";
					break;
					case "I feel you are totally not safe.":
					chat = "我觉得你完全不安全。";
					break;
					case "A knight with shovel. That's something new.":
					chat = "拿着铲子的骑士。这可真新鲜新。";
					break;
					case "OMFG YOU CANNOT KILL THE CLOWN. THE CLOWN KILLS YOU.":
					chat = "天啊，你不能杀死小丑。小丑会杀了你。";
					break;
					case "PADORU PADORU...":
					chat = "砰砰……";
					break;
					case "Oh. More beautiful ladies huh. You really get along with them. Last time I try to talk with a vice general which is extremely rad eyepatched lady, she nearly beat me up.":
					chat = "哦，又有更多漂亮的女士啊。你真的很会跟她们相处。上次我试着跟一个副总将说话，她是个特别凶的独眼女士，差点把我打了一顿。";
					break;
					case "Why every female vampire need to be these cute? Still that joyful eyes freak me out.":
					chat = "为什么每个女吸血鬼都必须是这么可爱的？还有那双愉快的眼睛，真是吓到我了。";
					break;
					case "Every hero has a alchemist behind it. You should find one if you don't have.":
					chat = "每个英雄背后都有一个炼金术士。如果你还没有，你应该找一个。";
					break;
					case "It's much better for me to watch from back. It allows you to see the true picture and balance of this world. But for you I believe you should do what you think is correct.":
					chat = "对我来说，从背后默默观察会更好。这样能让你看到这个世界的真实面貌和平衡。但对你来说，我相信你应该做你认为正确的事。";
					break;
					case "After all those years of seeing adventurers die horribly from the many dangers of this world you look quite promissing.":
					chat = "经过这么多年，目睹无数冒险者因这个世界的诸多危险而惨死，你看起来相当有前途。";
					break;
					case "Do you know before lihzards has change the artifacts and ruin the tradition, there was a culture shaped with the mystic power of blue scarabs. ":
					chat = "你知道吗，在丛林蜥蜴改变神器并破坏传统之前，曾有一个文化是以蓝色圣甲虫的神秘力量为基石的。";
					break;
					case "The current dangers of this world is the result of our mistakes in past. I feel sad for many beasts that are once kind souled lifeforms. Maybe its best to put them to rest.":
					chat = "这个世界当前的危险是我们过去错误的结果。我为那些曾经拥有善良灵魂的众多野兽感到难过。也许让它们安息才是最好的。";
					break;
					case "This universe have had enough and its current state is between the boundary of life and death. If he does not hold all of the pieces together there will be the big crunch and nothing left. It's more like holding the sand in a form of vase with your own hands... How I know this? Well some of the things need to be secret.":
					chat = "这个宇宙已经受够了，它现在的状态处于生死边缘。如果他不能把所有碎片拼凑在一起，就会引发大坍缩，一切都将荡然无存。这就像用双手把一个花瓶里的沙子保持住形状……我怎么知道的？嗯，有些事情需要保密。";
					break;
					case "A fetus in a suit ,crying child and some form of a monster gang? They are all outsiders and they do not belong to this universe. Maybe after all the pain they felt in their universes they have been thrown into this by her. Who is she? Well, its not wise to call her name. It's much better for you to not know... things...":
					chat = "一个穿着西装的胎儿，哭泣的孩子，以及某种形式的怪物团伙？它们都是局外人，不属于这个宇宙。也许它们在自己的宇宙中经历了所有的痛苦之后，被她扔到了这里。她是谁？嗯，直呼她的名字并不明智。对你来说，不知道……这些事情……会更好。";
					break;
					case "The reality is quite fragile, if you damage it a little you start to hallucinate the mirror images of realities in other universes close to the one you live":
					chat = "现实是相当脆弱的，如果你稍微破坏它一点，你就会开始产生幻觉，看到与你所在宇宙相邻的其他宇宙中的现实镜像。";
					break;
					case "After I observe you I start to feel hope for humanity which I haven't felt for centuries.":
					chat = "在观察你之后，我开始对泰拉人感到希望，这种希望我已经很久没有感受到了，几个世纪都没有过了。";
					break;
					case "Greetings.":
					chat = "你好。";
					break;
					case "More trophy you bring, more things you get.":
					chat = "你带来的纪念章越多，得到的东西就越多。";
					break;
				}
			}

			if (npc.type == ModContent.NPCType<FallenAngel>())
			{
				if (Dryad >= 0 && chat == "I feel also " + Main.npc[Dryad].GivenName + "s soul is blessed.")
					chat = "我感到树妖的灵魂是纯洁的。";
				if (Clothier >= 0 && chat == "How do you believe " + Main.npc[Clothier].GivenName + " ? I can still feel his sinned soul.")
					chat = "你怎么能相信服装商？我感到他的灵魂充满了罪恶";

				switch (chat)
				{
					case "Why everyone are looking so cursed?":
					chat = "为什么大家看起来气色都不太好？";
					break;
					case "*looks frightened* In our village there are no such horrific creatures":
					chat = "*瑟瑟发抖* 在我们那里没有这种可怕的生物。";
					break;
					case "I'm not sure why but it looks like humans affect from the shine of the moon":
					chat = "我不知道为什么，但看起来人们受到了月球光芒的影响。";
					break;
					case "In my village we can stop blood moon with holy magic but sadly I haven't learned them.":
					chat = "在我们那里可以用神圣的魔法阻止血月，但遗憾的是我还没有学会。";
					break;
					case "Where does they come from?":
					chat = "它们是从哪里来的？";
					break;
					case "I heard there was once a happy spirit which then lose it's sanity. I want to ask you only one thing. Could you not try to figt with it since I feel a strange but kind reality caused by that thing.":
					chat = "我听说曾经有一个快乐的灵魂，但后来失去了理智。我只向请求你一件事，不要伤害它，因为我感到它造成了一种奇怪但纯真善良的影响。";
					break;
					case "Greetings. What are you looking for friend?":
					chat = "你好。你在找什么，朋友？";
					break;
					case "I'm not sure what caused but something shined my eyes.":
					chat = "我不确定发生了什么，但有东西闪到了我的眼睛。";
					break;
					case "I feel one of my wing is broken. Could you help me?":
					chat = "我感觉我的一只翅膀断了。你能帮我吗？";
					break;
					case "I missed where I come from.":
					chat = "我想念了我的来处。";
					break;
					case "I haven't visited the surface for 600 years. I feel this place have been changed quite a lot.":
					chat = "我已经600年没有降临尘世了。我觉得这里已经发生了很大的变化。";
					break;
					case "Do you also want to go to my village? Sorry human but that place is restricted to humans.":
					chat = "你也想拜访我的来处吗？对不起，但那个地方不允许泰拉人进入。";
					break;
					case "Maybe one day my wings will be healed and I can visit my town again.":
					chat = "也许有一天我的翅膀会愈合，我可以重回天堂。";
					break;
					case "Did you saw any angel other than me?":
					chat = "除了我，你看到其他天使了吗？";
					break;
					case "I feel boss hunter merchant is looking for someone":
					chat = "我感觉Boss狩猎商人在找寻什么人。";
					break;
					case "Strangely I feel something is having fun but I'm not sure what is that thing.":
					chat = "奇怪的是，我感到有些事情很有趣，但我不确定那是什么。";
					break;
					case "I feel the something is awakening the ancient trio. You should be careful since I can feel their wrath.":
					chat = "我感觉有什么东西在唤醒旧日三重唱。你要小心，因为我能感觉到它们的愤怒。";
					break;
					case "I feel an ancient soul disturbed with the sins of the world. Maybe you should be careful while slaying the monster since it's soul burning with judgement and determination. Strangely I feel it's reality have been changed a little.":
					chat = "我感觉到一个古老的灵魂被世界的罪恶所扰乱。也许你在杀死怪物时应该小心，因为它的灵魂燃烧着公正和决断。奇怪的是，我感到它的影响发生了一些变化。";
					break;
					case "After you beat down the guardians maybe I can awake the forgotten angelic artifact with the shattered piece of their souls.":
					chat = "在你打倒守护者之后，也许我可以用他们破碎的灵魂唤醒被遗忘的天使神器。";
					break;
					case "Hello. How are you?":
					chat = "你好。最近怎么样？";
					break;
				}
			}

            if (npc.type == ModContent.NPCType<Yandere>())
			{
				if (Dryad >= 0 && chat == "Could you just tell " + Main.npc[Dryad].GivenName + " to try to stop affecting yo- I mean others by walking nearly complete naked? If you don't I will fix problem with my own solution.")
					chat = "你能不能告诉树妖，让她尽量不要以近乎全裸的方式在你——我是说其他人面前出现？如果你做不到，我会用我的方法来解决这个问题。";
                if (Nurse >= 0 && chat == "Sorry but I don't need to visit " + Main.npc[Nurse].GivenName + ". This world is ruled after kill or be killed in if you cannot heal yourself in the end you will just get hunted in the end.")
					chat = "抱歉，但我并不需要去找护士。这个世界奉行的是丛林法则，如果无法自力更生，你最终只会成为被猎杀的对象。";

				switch (chat)
				{
					case "Senpai if all of the ocean become ink it will be still not enough for me to tell how much I love you":
					chat = "天地合，乃敢与君绝。";
					break;
					case "Still you didn't tell me where we go for honeymoon. I hope that place will contain only me and you.":
					chat = "你还是没告诉我要去哪里度蜜月。我希望那个地方只有我和你。";
					break;
					case "HAHAHAHAHAHAH- wait its still alive. Sorry darling I will be a little busy for next few minutes":
					chat = "哈哈哈哈—等等它还活着。抱歉，亲爱的，接下来几分钟我会有点忙。";
					break;
					case "I can feel your breath.":
					chat = "我能感受到你的呼吸。";
					break;
					case "*sharpens her knife* You know that Dryad really needs to get a nice lesson.":
					chat = "*磨着她的刀* 你知道树妖真的需要好好上一课。";
					break;
					case "*Starts to slowly walk towards you* Isn't the night is lovely?":
					chat = "*慢慢向你走来* 如此良辰美景，不如我们？";
					break;
					case "*Blushes* Do you come here to visit me? How kind.":
					chat = "*脸红* 你是来找我的吗？真好。";
					break;
					case "After you defeat that kid high on neurochemicals and streoids the order have determined to let me move here and help you whenever you need. I hope this will make you happy.":
					chat = "在你打败了那个服用神经化学物质和类固醇的孩子之后，教团决定让我搬到这里，在你需要的时候帮助你。我希望这会让你高兴。";
					break;
					case "Do you come here to buy or you come here for me?":
					chat = "你是来买东西的还是来找我的？";
					break;
					case "I miss you when you are not here.":
					chat = "你不在的时候我好想你。";
					break;
					case "Hunting animals and humans are same. At first their screams and cries affect your heart but with time you start to feel nothing.":
					chat = "狩猎动物和人类是一样的。起初，它们的尖叫和哭泣会影响你的心，但随着时间的推移，你开始什么都感觉不到。";
					break;
					case "What a lovely day. Isn't it? After you finish your job what about we drink something together?":
					chat = "多么美好的一天。不是吗？你完成工作后，我们一起喝点什么？";
					break;
					case "Always be careful about slimes. They may look weak but their actual men that fight hits quite hard. I wish I don't need to fight against that half cat half slime thing.":
					chat = "是要小心史莱姆。它们可能看起来很弱，但实际的战斗力却很强。我希望我不需要对抗那种半猫半史的东西。";
					break;
					case "While I was searching the caves for assassinating a high tier dwarfs that is responsible for the mine slavery I have heard crying sounds of a child. I wish he's safe in there.":
					chat = "当我在洞穴里搜寻负责矿场奴隶制的高阶矮人，准备刺杀他时，我听到了孩子的哭声。我希望他能在那里安然无恙。";
					break;
					case "Wait, you visit underworld and come here that easily. I have never heard that bit- I mean that succubus queen to let people that easily before examining them.":
					chat = "等等，你去过地狱还能来到这儿。我从没听说那个表……我是说，魅魔女王会这么轻易地在不经过检查的情况下就让人通过。";
					break;
					case "I don't know whoever design that zeppelin but bunnies knows how to use it well. Actually too well...":
					chat = "我不知道齐柏林飞艇是谁设计的，但兔子们知道如何使用它。确实，用的有点太好了…";
					break;
					case "While I was watching sky while resting I have seen a harpy racing with a tinkerer on a small plane. Strangely they look like they are both having fun. I wish we also get along with other nations rather than killing.":
					chat = "当我休息时，我看到天上有一架竖琴在一架小飞机上和一个修补匠比赛。奇怪的是，它们看起来都很开心。我希望我们也能与其他国家这样相处，而不是杀戮。";
					break;
					case "Senpai please be safe.":
					chat = "前辈，请注意安全。";
					break;
					case "I wish I could make a dinner for you but these hands only trained for killing for years":
					chat = "我希望自己能为你做一顿晚餐，但这双手多年来只会杀人。";
					break;
					case "It's too late to go outside. Please stay with me. I can protect you from the darkness of the night":
					chat = "现在出门太晚了。请和我呆在一起。我可以保护你免受黑暗的侵袭。";
					break;
					case "What, you want to kill that thing? You are so brave senpai.":
					chat = "什么，你想杀了那个东西？你太勇敢了，前辈。";
					break;
					case "The order loves these kinds of nights. People get sleepy and assassinating them gets much easier.":
					chat = "教团喜欢这种夜晚。人们会昏昏欲睡，暗杀他们会变得容易得多。";
					break;
					case "Should we make a nice walk in this lovely night?":
					chat = "在这个美好的夜晚，我们应该好好散步吗？";
					break;
					case "Listening the winds at night make me hear the screams of my people that are being slaughtered by the kingdom. You are pretty lucky for not hearing that.":
					chat = "晚上听着风，我听到了我的人民被王国屠杀的惨叫声。你很幸运没有听到。";
					break;
					case "What, a scarlet eyed bounty hunter you ask? Never trust that megalovaniac. It ones worked for us but when kingdom pay her more it have changed the team and stab us from behind. It only truely cares chocolate.":
					chat = "什么，你问的是一个红眼睛的赏金猎人？永远不要相信那个自大狂。她曾为我们工作过，但当王国付给她更多的钱时，她背叛了我们。她现在只关心巧克力。";
					break;
					case "We, the order of chaos have gathered to save these lands from the cruelty of the kingdom. While our leader is a little... insane but maybe this keeps the hunters ready to strike. Honestly she have a specific taste for torturing so never go against her.":
					chat = "我们，混团教团已经聚集在一起，将这些土地从王国的残酷中拯救出来。虽然我们的领袖有点……疯狂，但也许这让猎人们做好了打击的准备。老实说，她对折磨有着特殊的品味，所以永远不要反对她。";
					break;
					case "What, Akatsuki clan? That half shinigami half human thingies have strong connections with each other, their clan leader and order of past. Not gonna lie I quite like them but due to they have problems with the order I couldn't visit their town.":
					chat = "什么？晓之一族？那些半死神半人类的家伙们彼此之间的联系确实很紧密，他们这一族引领了远古的时代。我不会撒谎，我很喜欢他们，但由于他们和教团之间有些问题，我不能拜访他们的城镇。";
					break;
					case "Wait, my dear why not we talk for some more. You know you are always welcome here and you don't need to leave so soon.":
					chat = "等等，亲爱的，我们为什么不多聊几句呢？你知道这里总是欢迎你的，你不需要这么快就离开。";
					break;
					case "Please be safe.":
					chat = "请注意安全。";
					break;
				}
			}

			if (npc.type == ModContent.NPCType<BountyHunter>())
			{
				switch (chat)
				{
					case "Oh you're approaching me? Well then partner, what you need?":
					chat = "哦，你在说我？好吧，伙计，你需要什么？";
					break;
					case "I used to live in a beautiful village with my family and lil bro... Wait why I'm telling you this? If you are looking for someone to make fun just find another person.":
					chat = "我曾经和我的家人以及我的小弟弟住在一个美丽的村庄……等等，我为什么要告诉你这些？如果你只是想找乐子，那就去找别人吧。";
					break;
					case "DOES SOMEONE SAID CHOCOLATE?":
					chat = "有人在说巧克力？";
					break;
					case "After all these adventures the only reward I ever get is see my opponents fall and let their eyes fade slowly. Maybe thats what power gives you":
					chat = "经历了这些冒险之后，我唯一得到的奖励就是看着我的对手倒下，让他们的眼神慢慢黯淡。也许这就是力量给你的东西吧。";
					break;
					case "What, how this town can have no chef? How you guys even get chocolate cake from?":
					chat = "什么，这个小镇怎么会没有厨师？你们要怎么才能吃到巧克力蛋糕？";
					break;
					case "Do you ever see that weirdo high on neurochemicals? Last time he ambushed I hardly save my life. I would like to make him a little coversation with my knife.":
					chat = "你有没有见过那个神经化学物质过量的怪人？上次他偷袭我，我差点没保住自己的性命。我想用我的刀跟他好好聊聊。";
					break;
					case "Do you ever think about if you can change what did you do in before what will be happened in future? I used to think but later I see it only damages by determination to kill so I stop thinking such thigs.":
					chat = "你是否有过这样的想法，如果能改变过去所做的事情，未来会发生什么？我以前会这样想，但后来我发现，只有下定决心去做才会带来改变，所以我不再想这样的事了。";
					break;		
				}
			}

			if (npc.type == ModContent.NPCType<Designer>())
			{
				if (Pirate >= 0 && chat == "Please do not believe what " + Main.npc[Pirate].GivenName + " says. He used to tell me he will show me far lands but now you can see the result. I was being tortured and used as a slave.")
					chat = "请不要相信海盗说的话。他以前告诉我他会带我去远方的陆地，但现在你可以看到结果。我被折磨并被当作奴隶。";
                if (Nurse >= 0 && chat == "After " + Main.npc[Nurse].GivenName + " see my skin she tell that maybe acid burn can be healed with some Eastern medicine. I hope they will.")
					chat = "护士看了我的皮肤后说，也许用一些中药可以治愈酸烧伤。我希望如此。";

				switch (chat)
				{
					case "I have missed you so much my love. I hope you are doing well.":
					chat = "亲爱的我好想你，我希望你最近过的还好。";
					break;
					case "They may look human but when pirates kidnap humans and they torture them until they either lose their sanity or their heart cannot stand anymore and they die from heart attack. How I survived? I don't want to tell this.":
					chat = "尽管他们外表看起来和人类无异，但海盗们会绑架人类，并对他们进行残酷的折磨，直到他们精神崩溃或是心脏无法承受而死于心脏病。我是如何生存下来的？我不想再提起这件事了。";
					break;
					case "Thank you again for everything. What you want to buy today?":
					chat = "再次感谢你为我做的一切。你今天想买些什么？";
					break;
					case "You ask those wounds, they are being made by pirate captain while he's testing how sharp his sword on me.":
					chat = "你问那些伤口吗？那是海盗船长用剑在我身上试剑时留下的。";
					break;
					case "Please don't abandon me, I'm still afraid that one day they will come.":
					chat = "请不要抛弃我，我还是很怕他们有一天会找来。";
					break;
					case "...Um what are you doing? Are you patting my head? That's fine, but ...":
					chat = "……嗯，你在做什么？你在拍我的头吗？这样挺好，但……";
					break;
					case "I will do anything I can do to help you.":
					chat = "我会尽我所能帮助你";
					break;
				}
			}

			if (npc.type == ModContent.NPCType<Elitist>())
			{
				if (Pirate >= 0 && chat == "Don't tell me you are keeping " + Main.npc[Pirate].GivenName + " inside of your town. " + Main.npc[Pirate].GivenName + "will attack you in the first opportunity as they did to my kingdom. I never expect our royal guards will be beaten by such low tier raiders.")
					chat = "别告诉我你把海盗留在了你们镇子里。海盗一旦有机会，就会像攻击我的王国一样攻击你们。我从没想到我们的皇家守卫会被这种低级的劫掠者打败。";
                if (Guide >= 0 && chat == "It's really interesting " + Main.npc[Guide].GivenName + " also have such knowledge on surreal arts.")
					chat = "向导对超现实主义艺术也有这样的了解，真是有趣。";

				switch (chat)
				{
					case "Wait, do you tell me that slime is dead? Oh my god thank you so much hero. I never expect a slime have such economy tactics and because of their life spawn have no limit according to royal records slimes have been controlling kingdoms economy for nearly a thousand years. Now with this they have lost their most important economist. I have a bad feeling that this will cause them to send their army after you. Please be safe hero.":
					chat = "等等，你是说史莱姆总统已经死了吗？天哪，太感谢你了，英雄。我从没想到史莱姆会有这样的经济策略，而且根据皇家记载，由于史莱姆的生命繁殖没有限制，它们已经控制了王国近千年的经济。现在，随着它们的这位重要经济学家死去，我有种不好的预感，它们可能会派军队来追杀你。请英雄保重。";
					break;
					case "Greetings human. Is there anything I can help you?":
					chat = "你好，泰拉人。有什么我可以帮助你的吗？";
					break;
					case "Thanks to you now that demonic thing cannot hunt our merchants and maybe kingdoms economy return back once again. Actually if that weird haired slime didn't cause devaluation and own the black market to kill our local markets and economy kingdom have already return to its gold eras.":
					chat = "多亏了你，现在那个恶魔般的东西不能再猎杀我们的商人了，也许王国的经济能够再次恢复。实际上，如果那个头发奇怪的史莱姆没有造成贬值，没有垄断黑市以扼杀我们的本地市场和经济，王国早就已经回到它的黄金时代了。";
					break;
					case "Don't look me with such eyes. Blue period is an art period which is taken its name from one of our famous painter. Why people think such weird things when they hear that?":
					chat = "不要用那样的眼神看着我。蓝色时期是一个艺术时期，它的名字来源于我们的一位著名画家。为什么人们听到这个名字会想到这么奇怪的事情呢？";
					break;
					case "Well... That thing on that painting is just happy accident":
					chat = "嗯……那幅画上的那个东西只是个巧合";
					break;
					case "Wait, it's tea time. Tell me where I can find tea in this town?":
					chat = "等等，现在是喝茶时间了。告诉我这个镇子哪里可以找到茶？";
					break;
					case "Why I'm pale? Well because of the assasinations wealthy families make their kids raise inside of where they found safe and I mostly raise inside of an art gallery. After the king give order to make copy of important paintings and spread the culture I volunteered to see both the outer world and spread the art.":
					chat = "为什么我看起来脸色苍白？嗯，这是因为富裕的家庭为了防止暗杀，会让孩子在他们认为安全的地方长大，而我主要是在一个艺术画廊里长大的。在国王下令复制重要画作并传播文化之后，我自愿出来看看外面的世界并传播艺术。";
					break;
					
				}
			}

			if (npc.type == ModContent.NPCType<WanderingSamurai>())
			{
				if (Nurse >= 0 && chat == "Can you tell " + Main.npc[Nurse].GivenName + " that this is our natural skin colour and I'm not ill. ")
					chat = "你能告诉护士我们的肤色天生就是这样吗，我并没有生病。";
				if (chat == "Watashi wa " + Main.npc[WanderingSamurai].GivenName + " sam- wait you don't know our local language. Sorry for that. My name is " + Main.npc[WanderingSamurai].GivenName + " and its honor to meet a hunter like you.")
					chat = "瓦塔西瓦" + Main.npc[WanderingSamurai].GivenName + "萨米，等等你不会说我们的语言。 抱歉，我的名字是" + Main.npc[WanderingSamurai].GivenName + "，很荣幸见到你。";

				switch (chat)
				{
					case "Wait, you kill gooki? For few things my clans and slimes politics are different but he's brave and kind shinobi. I will pray for him.":
					chat = "等等，你杀了古奇？我的部族和权贵政治几乎没有什么不同，但他是勇敢善良的忍者。我会为他祈祷。";
					break;
					case "Do you kill Neko sama? She have slayed hundred men in less than 5 second in front of my eyes. It seems you are really getting stronger.":
					chat = "你杀了奈子吗？她在我眼前不到5秒钟的时间里杀死了100名男子。看来你真的越来越强壮了。";
					break;
					case "You ask why I look different. Well, eons ago our ancestors live where sakura trees blossom and filled with rei's. Legends tell one day one farmer have cut down a kodama to returning that place farm and cause that yokai to curse my nation with the illness of melting bones. After the painful death of half of our people the clan leader Akatsuki have make a deal with shinigamis to give her immortality and half of our humanity she have broken that curse and after that day we become half human half shinigami.":
					chat = "你问为什么我看起来与众不同。嗯，很久很久以前，我们的祖先生活在樱花盛开、充满神灵的地方。传说有一天，一个农夫砍倒了一棵神木，为了在那个地方开垦农田，结果惹怒了妖怪，导致我的国家被诅咒。在我们的人民痛苦地死去一半之后，氏族首领晓与死神达成了一个协议，她献出了自己的不朽和一半的人性，打破了那个诅咒。从那天起，我们就变成了半人半死神的一族。";
					break;
					case "Thank you so much to put her to rest. I have also beaten Okiku several times before but because of her innocence and youth my pity always stop me to do the deathblow but thanks to you her soul can rest now.":
					chat = "非常感谢你让她安息。我之前也打败过盘子女鬼几次，但因为她的无辜和年轻，我的怜悯之心总是阻止我给她致命一击。但多亏了你，她的灵魂现在可以安息了。";
					break;
					case "Why you look like that? Actually being around thousand year old is a young age when compared with the others in my clan.":
					chat = "你为什么那么惊讶？其实，在我们氏族里，活上千年算是年轻的。";
					break;
					case "Actually we are send other areas to observe what is happening and clear any threat against our clan. Well, why I choose this place? Since I'm aware of your presense you can do the cleaning stuff while I'm resting for some time. Well, if you find another person to do the work it won't accept as sleeping at job.":
					chat = "实际上，我们被派往其他地区观察情况，清除任何威胁我们氏族的威胁。嗯，为什么我选择这个地方？既然我知道你在这儿，你可以在我休息的时候负责清理工作。嗯，如果你找到其他人来做这份工作，那可就不算是偷懒了。";
					break;
					case "*Yawns* Since you are here I believe you can do the job to clean yokai's and other monsters. Fighting with royal guards at high noon tire me a little bit so I will rest in your town for some time.":
					chat = "*打哈欠* 既然你在这儿，我相信你能胜任清理妖怪和其他怪物的任务。与皇家守卫在正午时分交战让我有点累，所以我会在你的镇子里休息一段时间。";
					break;
				}
			}
        }

    }
}