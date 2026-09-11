namespace proto;

public class EAccount
{
	public enum PlatformType
	{
		PlatformType_VISITOR = 0,
		PlatformType_GAS = 1,
		PlatformType_BEETALK = 2,
		PlatformType_GAFACEBOOK = 3,
		PlatformType_GAGUEST = 4,
		PlatformType_VK = 5,
		PlatformType_FACEBOOK = 6,
		PlatformType_HUAWEI = 7,
		PlatformType_GOOGLE = 8,
		PlatformType_XXX = 9,
		PlatformType_APPLE = 10,
		PlatformType_TWITTER = 11,
		PlatformType_DELETE = 100,
		PlatformType_CHANGE_ACCOUNT = 101
	}

	public enum BlacklistOpType
	{
		BlacklistOpType_NONE,
		BlacklistOpType_BAN_ACCOUNT,
		BlacklistOpType_UNBAN_ACCOUNT
	}

	public enum Role
	{
		Role_NONE = 0,
		Role_GM = 1,
		Role_CONTESTANT = 2,
		Role_STREAMER = 4,
		Role_REPLAY = 8,
		Role_ROOMMASTER = 0x10,
		Role_ROOMPARTNER = 0x20,
		Role_PERSONAGE = 0x40,
		Role_COMPANY = 0x80,
		Role_PREPARATION = 0x100,
		Role_UGC = 0x200,
		Role_PHONEROOMMASTER = 0x400,
		Role_GM_CORE = 0x800,
		Role_GM_COMMUNITY = 0x1000,
		Role_KOL_TIER_1 = 0x2000,
		Role_KOL_TIER_2 = 0x4000,
		Role_KOL_TIER_3 = 0x8000,
		Role_ESPORTS_TIER_1 = 0x10000,
		Role_ESPORTS_TIER_2 = 0x20000,
		Role_ESPORTS_TIER_3 = 0x40000,
		Role_ESPORTS_MASTER = 0x80000,
		Role_UGC_CREATOR_1 = 0x100000
	}

	public enum BanReason
	{
		BanReason_UNKNOWN = 0,
		BanReason_IN_GAME_AUTO = 1,
		BanReason_REFUND = 2,
		BanReason_OTHERS = 3,
		BanReason_SKINMOD = 4,
		BanReason_IN_GAME_AUTO_NEW = 1014
	}

	public enum NewsType
	{
		NewsType_NONE,
		NewsType_RANK,
		NewsType_LOTTERY,
		NewsType_PURCHASE,
		NewsType_TREASUREBOX,
		NewsType_ELITEPASS,
		NewsType_EXCHANGESTORE,
		NewsType_BUNDLE,
		NewsType_LOTTERYSPECIALEXCHANGE,
		NewsType_OTHERS
	}

	public enum WarmGameType
	{
		WarmGameType_NONE,
		WarmGameType_FIRSTRECHARGE,
		WarmGameType_BOTPOINT
	}

	public enum DownloadType
	{
		DownloadType_NONE,
		DownloadType_INSTANTGAME,
		DownloadType_IOS,
		DownloadType_HUAWEI,
		DownloadType_XIAOMI,
		DownloadType_SAMSUNG
	}

	public enum LoginType
	{
		LoginType_NORMAL,
		LoginType_DEBUG_ACCOUNT_ID,
		LoginType_DEBUG_NICKNAME
	}

	public enum CBSwitchStatus
	{
		CBSwitchStatus_NONE,
		CBSwitchStatus_CHECK_KEY,
		CBSwitchStatus_DONT_CHECK_KEY,
		CBSwitchStatus_DISABLE_MAX_LOGIN
	}

	public enum TrialSwitchStatus
	{
		TrialSwitchStatus_NONE,
		TrialSwitchStatus_CHECK_KEY,
		TrialSwitchStatus_DONT_CHECK_KEY
	}

	public enum NewbieChoice
	{
		NewbieChoice_NONE = 0,
		NewbieChoice_NEW_PLAYER = 1,
		NewbieChoice_FPS_PLAYER = 2,
		NewbieChoice_VETERAN = 3,
		NewbieChoice_NEEDMOREINFO = 99
	}

	public enum Prefers
	{
		Prefers_NONE = 0,
		Prefers_DISPLAY_PREGAME_INFO = 1,
		Prefers_SHOW_KD = 2,
		Prefers_HIDE_MY_LOBBY = 4,
		Prefers_HIDE_PERSONAL_INFO = 8,
		Prefers_DISABLE_FRIEND_SPECTATE = 0x10,
		Prefers_HIDE_OCCUPATION_INFO = 0x20
	}

	public enum ChoicesType
	{
		ChoicesType_NONE,
		ChoicesType_PREGAMESHOW_SHOW_CS_STATS,
		ChoicesType_PREGAMESHOW_SHOW_BR_STATS,
		ChoicesType_PREGAMESHOW_SHOW_CS_PEAK_STATS
	}

	public enum Choices
	{
		Choices_NONE = 0,
		Choices_CS_SHOW_STATS_WINS = 1,
		Choices_CS_SHOW_STATS_MVP_COUNT = 2,
		Choices_CS_SHOW_STATS_KILLS = 3,
		Choices_CS_SHOW_STATS_AVG_DAMAGE = 4,
		Choices_CS_SHOW_STATS_KDA = 5,
		Choices_CS_SHOW_STATS_TRI_KILLS = 6,
		Choices_CS_SHOW_STATS_FOUR_KILLS = 7,
		Choices_CS_SHOW_STATS_HEAD_SHOT = 8,
		Choices_CS_SHOW_STATS_RATING_POINTS = 9,
		Choices_CS_SHOW_STATS_MAX = 100,
		Choices_BR_SHOW_STATS_KD = 101,
		Choices_BR_SHOW_STATS_KILLS = 102,
		Choices_BR_SHOW_STATS_ONE_GAME_MOST_KILLS = 103,
		Choices_BR_SHOW_STATS_ONE_GAME_MOST_DAMAGE = 104,
		Choices_BR_SHOW_STATS_WINS = 105,
		Choices_BR_SHOW_STATS_TOP_10_PERCENT_RATE = 106,
		Choices_BR_SHOW_STATS_AVG_DAMAGE = 107,
		Choices_BR_SHOW_STATS_TOP_10_PERCENT_TIMES = 108,
		Choices_BR_SHOW_STATS_HEAD_SHOT_KILL_RATE = 109,
		Choices_BR_SHOW_STATS_RATING_POINTS = 110,
		Choices_BR_SHOW_STATS_MAX_STREAK_GOLD_MEDAL = 111,
		Choices_BR_SHOW_STATS_MAX_STREAK_SILVER_MEDAL = 112,
		Choices_BR_SHOW_STATS_MAX = 200,
		Choices_CS_PEAK_SHOW_STATS_ICONIC_WEAPON = 201,
		Choices_CS_PEAK_SHOW_STATS_ICONIC_WEAPON_AVG_KILLS = 202,
		Choices_CS_PEAK_SHOW_STATS_ICONIC_WEAPON_HEADSHOT_KILL_RATE = 203,
		Choices_CS_PEAK_SHOW_STATS_ICONIC_WEAPON_AVG_DAMAGE = 204,
		Choices_CS_PEAK_SHOW_STATS_MAX = 300
	}

	public enum MatchMakingSwitchType
	{
		MatchMakingSwitchType_NONE,
		MatchMakingSwitchType_CS_LOADING,
		MatchMakingSwitchType_MAX_LOBBY,
		MatchMakingSwitchType_BR_LOADING,
		MatchMakingSwitchType_METROPOLIS
	}

	public enum BanType
	{
		BanType_NONE,
		BanType_RANKING,
		BanType_GROUP
	}

	public enum PlayerProficiencyType
	{
		PlayerProficiencyType_NONE,
		PlayerProficiencyType_NEWPLAYER,
		PlayerProficiencyType_VETERAN,
		PlayerProficiencyType_PREVETERAN
	}

	public enum CallSignSrc
	{
		CallSignSrc_NONE,
		CallSignSrc_WITHOUT,
		CallSignSrc_SEARCH_CHAMPIONSHIP,
		CallSignSrc_SEARCH_CUP,
		CallSignSrc_SEARCH_FRIEND,
		CallSignSrc_SEARCH_CHUMMY,
		CallSignSrc_GAME_OVER,
		CallSignSrc_PERSONAL_SHOW_VIEW,
		CallSignSrc_PERSONAL_SHOW_EP,
		CallSignSrc_PERSONAL_SHOW_OWNER,
		CallSignSrc_BREIF_INFO,
		CallSignSrc_FRIEND_RECALL,
		CallSignSrc_FRIEND_PLATFORM,
		CallSignSrc_FRIEND_REQUEST,
		CallSignSrc_FRIEND_LIST,
		CallSignSrc_FRIEND_NTF,
		CallSignSrc_FRIEND_RECOMMEND,
		CallSignSrc_FRIEND_CDT,
		CallSignSrc_CLAN_REQUEST,
		CallSignSrc_CLAN_MEMBERS,
		CallSignSrc_CUP_REQUEST,
		CallSignSrc_CUP_MEMBERS,
		CallSignSrc_CHAMPIONSHIP_REQUEST,
		CallSignSrc_CHAMPIONSHIP_MEMBERS,
		CallSignSrc_CHAMPIONSHIP_SEASON,
		CallSignSrc_CHUMMY_REQUEST,
		CallSignSrc_CHUMMY_LIST,
		CallSignSrc_CHUMMY_RECOMMEND_STUDENT,
		CallSignSrc_CHUMMY_RECOMMEND_MENTOR,
		CallSignSrc_LEADERBOARD_PROFILE,
		CallSignSrc_POOLLEADERBOARD_PROFILE,
		CallSignSrc_RECENT_VISITORS,
		CallSignSrc_LOBBY_POPUP_WINDOW,
		CallSignSrc_MATCHMAKING_BLACKLIST,
		CallSignSrc_MATCHMAKING_SOCIAL,
		CallSignSrc_MATCH_SPECTATION,
		CallSignSrc_SOCIAL_TEAM_UP_RECOMMEND,
		CallSignSrc_CLAN_INVITE_STRANGERS,
		CallSignSrc_SEND_GIFT_NOTIFY,
		CallSignSrc_PLAYER_NEARBY,
		CallSignSrc_FRESH_PLAYER_RECOMMEND,
		CallSignSrc_WORKSHOP_FOLLOWS
	}

	public enum PunishType
	{
		PunishType_NONE = 0,
		PunishType_GROUP = 1,
		PunishType_RANKING = 2,
		PunishType_RESET_RANK = 3,
		PunishType_LEADERBOARD = 4,
		PunishType_RESET_BR_RANK = 301,
		PunishType_RESET_CS_RANK = 302,
		PunishType_RESET_PERIODIC_RANK = 303,
		PunishType_RESET_HIPPO_CRISIS_RANK = 304,
		PunishType_RESET_CS_PEAK = 305,
		PunishType_MUTE_MIC = 5,
		PunishType_MATCH_BEHAVIOR = 101,
		PunishType_CHAT_MSG_REPORT = 102,
		PunishType_VOICE_DETECTING = 103,
		PunishType_BAN_FRIEND_ADDING = 104
	}

	public enum ExternalIconStatus
	{
		ExternalIconStatus_NONE,
		ExternalIconStatus_NOT_IN_USE,
		ExternalIconStatus_IN_USE
	}

	public enum ExternalIconShowType
	{
		ExternalIconShowType_NONE,
		ExternalIconShowType_FRIEND,
		ExternalIconShowType_ALL
	}
}
