namespace tcp;

public class EMatch
{
	public enum MatchMode
	{
		MatchMode_NONE = 0,
		MatchMode_CASUAL = 1,
		MatchMode_RANKING = 2,
		MatchMode_ROOM = 3,
		MatchMode_CHAMPIONSHIP = 4,
		MatchMode_TRAINING = 5,
		MatchMode_CSRANKING = 6,
		MatchMode_CUP = 7,
		MatchMode_UGC = 8,
		MatchMode_PERIODIC = 9,
		MatchMode_UGC_PLUS = 10,
		MatchMode_PVE = 11,
		MatchMode_ROOM_MATCHMAKING = 12,
		MatchMode_GUILD_WAR = 13,
		MatchMode_HIPPOCRISIS_RANKING = 14,
		MatchMode_GUILD_WAR_TOURNAMENT = 15,
		MatchMode_CS_PEAK = 16,
		MatchMode_ESPORTS = 17,
		MatchMode_COMMON = 999
	}

	public enum GameMode
	{
		GameMode_NONE = 0,
		GameMode_BattleRoyale = 1,
		GameMode_SpeedRoyale = 2,
		GameMode_FateRoyale = 3,
		GameMode_ZombieSpeedRoyale = 4,
		GameMode_FateXmas = 5,
		GameMode_ZombieGround = 7,
		GameMode_Jankenpon = 9,
		GameMode_WinnerTakesAll = 11,
		GameMode_Purge = 12,
		GameMode_HookBrick = 14,
		GameMode_CS = 15,
		GameMode_BigHead = 16,
		GameMode_SprayAndPray = 17,
		GameMode_ExplosiveJump = 18,
		GameMode_NightHunter = 19,
		GameMode_FullyCharged = 20,
		GameMode_PumpkinSnatch = 21,
		GameMode_ThrowingKnife = 22,
		GameMode_Training = 23,
		GameMode_TDM = 24,
		GameMode_Snowman = 25,
		GameMode_ArmsRace = 26,
		GameMode_BombMatch = 27,
		GameMode_Token = 28,
		GameMode_Escort = 29,
		GameMode_Reaper = 30,
		GameMode_AttackOnHead = 31,
		GameMode_Control = 32,
		GameMode_BankNote = 33,
		GameMode_TeamArmsRace = 34,
		GameMode_ADSpace = 35,
		GameMode_StrikeOut = 36,
		GameMode_Werewolves = 37,
		GameMode_Party = 38,
		GameMode_FourSymbols = 39,
		GameMode_TutorialBR = 40,
		GameMode_TutorialCS = 41,
		GameMode_FightClub = 43,
		GameMode_RushingPets = 44,
		GameMode_UGCParty = 45,
		GameMode_UGC = 46,
		GameMode_CombineWeapon = 48,
		GameMode_LoneWolfStrikeOut = 49,
		GameMode_CSHardCore = 52,
		GameMode_UGCCommon = 53,
		GameMode_ZombieGroundPlus = 55,
		GameMode_FlagBattle = 57,
		Gamemode_Infection = 58,
		Gamemode_ForceTutorialBR = 59,
		GameMode_RushHour = 60,
		GameMode_PersonalDeathmatch = 61,
		GameMode_Social = 62,
		GameMode_HuntingGround = 63,
		GameMode_Football = 64,
		GameMode_PDMHeadShot = 65,
		GameMode_PDMSniper = 66,
		GameMode_PDMShotgun = 67,
		GameMode_PDMAKIMBO = 68,
		GameMode_PDMPistol = 69,
		GameMode_PDMColdSteel = 70,
		GameMode_PDMEJ = 71,
		GameMode_HuntingGroundSnow = 72,
		GameMode_LoneWolfMulti = 73,
		GameMode_LoneWolfSpecial = 74,
		GameMode_PetStar = 77,
		GameMode_2ActiveSkill = 78,
		GameMode_Metropolis = 79,
		GameMode_PVE_Everlasting = 80,
		GameMode_PVE_UGC_HuntingGroundLike = 81,
		GameMode_FFP_CS = 82,
		GameMode_SocialHall = 83,
		GameMode_CollectionTrial = 84,
		GameMode_HippoCrisis = 88,
		GameMode_TutorialHippoCrisis = 89,
		GameMode_PVP_MaxMode = 90,
		GameMode_PVP = 99,
		GameMode_PVE_MinMode = 100,
		GameMode_PVE_HYAKKI = 101,
		GameMode_PVE_SVZombie = 102,
		GameMode_PVE_MaxMode = 103
	}

	public enum GroupMode
	{
		GroupMode_SOLO,
		GroupMode_DUAL,
		GroupMode_TRIPLE,
		GroupMode_QUAD,
		GroupMode_PENTA,
		GroupMode_HEXA,
		GroupMode_SEVEN,
		GroupMode_OCTA,
		GroupMode_NINE,
		GroupMode_TEN,
		GroupMode_ELEVEN,
		GroupMode_DOZEN,
		GroupMode_THIRTEEN,
		GroupMode_FOURTEEN,
		GroupMode_FIFTEEN,
		GroupMode_SIXTEEN
	}

	public enum UGCDifficulty
	{
		UGCDifficulty_NONE,
		UGCDifficulty_TEAM_CONTEST,
		UGCDifficulty_BATTLE_GROUNDS
	}

	public enum RoomMatchmakingType
	{
		RoomMatchmakingType_NONE,
		RoomMatchmakingType_SPECIFIC,
		RoomMatchmakingType_WORKSHOP_TAG,
		RoomMatchmakingType_RANDOM,
		RoomMatchmakingType_PUGC,
		RoomMatchmakingType_UGC_TOPIC,
		RoomMatchmakingType_WEIGHT
	}

	public enum RoomMatchMakingDifficulty
	{
		RoomMatchMakingDifficulty_NONE,
		RoomMatchMakingDifficulty_WORKSHOP_TAG,
		RoomMatchMakingDifficulty_PUGC
	}

	public enum BotGameType
	{
		BotGameType_NONE,
		BotGameType_RESIDENT,
		BotGameType_WARMGAME,
		BotGameType_MMR,
		BotGameType_BOTPOINT,
		BotGameType_VETERAN,
		BotGameType_AI_TEST,
		BotGameType_TIMEOUT,
		BotGameType_CASUALWARMGAME,
		BotGameType_RANKING_DAILY,
		BotGameType_RANKING_STREAK_LOSE,
		BotGameType_RANKING_NEW_SEASON,
		BotGameType_RANKING_TAGS,
		BotGameType_VETERAN_TOTAL,
		BotGameType_LOW_ACTIVE,
		BotGameType_AIWarmGameAPI,
		BotGameType_HIPPO_CRISIS_LOST_PROPERTY,
		BotGameType_NEW_PLAYER_WARMGAME,
		BotGameType_SEMI_WARM,
		BotGameType_AI_EXTRA_TRIGGER,
		BotGameType_LAND_FIGHT_WARM
	}

	public enum AIWarmType
	{
		AIWarmType_NONE = 0,
		AIWarmType_DisableByWarmNotOpen = 1,
		AIWarmType_DisableByAINotOpen = 2,
		AIWarmType_DisableByABTestNotOpen = 3,
		AIWarmType_DisableBySpecialModelNotOpen = 4,
		AIWarmType_DisableByInvalidBotCSVID = 5,
		AIWarmType_DisableByInvalidBotUID = 6,
		AIWarmType_DisableByStreakWin = 7,
		AIWarmType_DisableByDailyMaxLimit = 8,
		AIWarmType_DisableByNoneBotMMRSeparate = 9,
		AIWarmType_DisableByMLAPI = 10,
		AIWarmType_DisableByNoneVal = 11,
		AIWarmType_DisableByGMToolDisableAI = 12,
		AIWarmType_DisableByAIExceed = 13,
		AIWarmType_DisableByPlayerLevel = 14,
		AIWarmType_EnableByLowActive = 21,
		AIWarmType_EnableByVeteran = 22,
		AIWarmType_EnableAIByMLAPI = 23,
		AIWarmType_EnableBotByMLAPI = 24,
		AIWarmType_EnableAIByExtraTrigger = 25
	}

	public enum MatchFlags
	{
		MatchFlags_NONE,
		MatchFlags_AIWarmGame
	}

	public enum ScoreTagType
	{
		ScoreTagType_NONE,
		ScoreTagType_BattleWillingness,
		ScoreTagType_LeavePrefer
	}
}
