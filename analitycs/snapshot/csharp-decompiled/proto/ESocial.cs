namespace proto;

public class ESocial
{
	public enum PlayerBattleTagID
	{
		PlayerBattleTagID_NONE = 0,
		PlayerBattleTagID_DOMINATION = 1101,
		PlayerBattleTagID_UNCROWN = 1102,
		PlayerBattleTagID_BESTPARTNER = 1103,
		PlayerBattleTagID_SNIPER = 1104,
		PlayerBattleTagID_MELEE = 1105,
		PlayerBattleTagID_PEACEMAKER = 1106,
		PlayerBattleTagID_AMBUSH = 1107,
		PlayerBattleTagID_SHORTSTOP = 1108,
		PlayerBattleTagID_RAMPAGE = 1109,
		PlayerBattleTagID_LEADER = 1110
	}

	public enum PlayerBattleTagCdtType
	{
		PlayerBattleTagCdtType_NONE = 0,
		PlayerBattleTagCdtType_BR_RANK_LARGER = 100101,
		PlayerBattleTagCdtType_BR_RANK_SMALLER = 100102,
		PlayerBattleTagCdtType_BR_LAST_ELIMINATED = 100201,
		PlayerBattleTagCdtType_BR_KILL_LARGER = 100501,
		PlayerBattleTagCdtType_BR_KILL_SMALLER = 100502,
		PlayerBattleTagCdtType_BR_DAMAGE_LARGER = 100601,
		PlayerBattleTagCdtType_BR_DAMAGE_SMALLER = 100602,
		PlayerBattleTagCdtType_BR_ASSIST_LARGER = 100701,
		PlayerBattleTagCdtType_BR_ASSIST_SMALLER = 100702,
		PlayerBattleTagCdtType_BR_REVIVE_LARGER = 100801,
		PlayerBattleTagCdtType_BR_REVIVE_SMALLER = 100802,
		PlayerBattleTagCdtType_BR_DISTANCE_LARGER_PER_MINIUE = 100901,
		PlayerBattleTagCdtType_BR_DISTANCE_SMALLER_PER_MINIUE = 100902,
		PlayerBattleTagCdtType_BR_DISTANCE_LARGER = 101001,
		PlayerBattleTagCdtType_BR_DISTANCE_SMALLER = 101002,
		PlayerBattleTagCdtType_BR_TripleKill_LARGER = 101101,
		PlayerBattleTagCdtType_BR_QuadraKill_LARGER = 101102,
		PlayerBattleTagCdtType_CS_WIN = 200101,
		PlayerBattleTagCdtType_CS_KILL_MAX = 200201,
		PlayerBattleTagCdtType_CS_DAMAGE_MAX = 200301,
		PlayerBattleTagCdtType_CS_DEATH_PER_ROUND_LARGER = 200401,
		PlayerBattleTagCdtType_CS_DEATH_PER_ROUND_SMALLER = 200402,
		PlayerBattleTagCdtType_CS_KILL_PER_ROUND_LARGER = 200501,
		PlayerBattleTagCdtType_CS_KILL_PER_ROUND_SMALLER = 200502,
		PlayerBattleTagCdtType_CS_DAMAGE_PER_ROUND_LARGER = 200601,
		PlayerBattleTagCdtType_CS_DAMAGE_PER_ROUND_SMALLER = 200602,
		PlayerBattleTagCdtType_CS_ASSIST_PER_ROUND_LARGER = 200701,
		PlayerBattleTagCdtType_CS_ASSIST_PER_ROUND_SMALLER = 200702,
		PlayerBattleTagCdtType_CS_REVIVE_PER_ROUND_LARGER = 200801,
		PlayerBattleTagCdtType_CS_REVIVE_PER_ROUND_SMALLER = 200802,
		PlayerBattleTagCdtType_CS_DISTANCE_LARGER = 201001,
		PlayerBattleTagCdtType_CS_DISTANCE_SMALLER = 201002,
		PlayerBattleTagCdtType_CS_WinAverageKill_LARGER = 201301,
		PlayerBattleTagCdtType_CS_WinAverageKill_SMALLER = 201302,
		PlayerBattleTagCdtType_CS_FirstBlood_LARGER = 201401,
		PlayerBattleTagCdtType_CS_MVP_LARGER = 201501
	}

	public enum SocialTag
	{
		SocialTag_NONE = 0,
		SocialTag_FASHION = 2101,
		SocialTag_SOCIAL = 2102,
		SocialTag_VETERAN = 2103,
		SocialTag_NEWBIE = 2104,
		SocialTag_PLAYFORWIN = 2105,
		SocialTag_PLAYFORFUN = 2106,
		SocialTag_VOICEON = 2107,
		SocialTag_VOICEOFF = 2108
	}

	public enum Gender
	{
		Gender_NONE = 0,
		Gender_MALE = 1,
		Gender_FEMALE = 2,
		Gender_UNLIMITED = 999
	}

	public enum Language
	{
		Language_NONE = 0,
		Language_EN = 1,
		Language_CN_SIMPLIFIED = 2,
		Language_CN_TRADITIONAL = 3,
		Language_Thai = 4,
		Language_VIETNAMESE = 5,
		Language_INDONESIAN = 6,
		Language_PORTUGUESE = 7,
		Language_SPANISH = 8,
		Language_RUSSIAN = 9,
		Language_KOREAN = 10,
		Language_FRENCH = 11,
		Language_GERMAN = 12,
		Language_TURKISH = 13,
		Language_HINDI = 14,
		Language_JAPANESE = 15,
		Language_ROMANIAN = 16,
		Language_ARABIC = 17,
		Language_BURMESE = 18,
		Language_URDU = 19,
		Language_BENGALI = 20,
		Language_MALAY = 21,
		Language_UNLIMITED = 999
	}

	public enum RankShow
	{
		RankShow_NONE = 0,
		RankShow_BR = 1,
		RankShow_CS = 2,
		RankShow_UNLIMITED = 999
	}

	public enum TimeOnline
	{
		TimeOnline_NONE = 0,
		TimeOnline_WORKDAY = 1,
		TimeOnline_WEEKEND = 2,
		TimeOnline_UNLIMITED = 999
	}

	public enum TimeActive
	{
		TimeActive_NONE = 0,
		TimeActive_MORNING = 1,
		TimeActive_AFTERNOON = 2,
		TimeActive_NIGHT = 3,
		TimeActive_UNLIMITED = 999
	}

	public enum ModePrefer
	{
		ModePrefer_NONE = 0,
		ModePrefer_BR = 1,
		ModePrefer_CS = 2,
		ModePrefer_ENTERTAINMENT = 3,
		ModePrefer_UNLIMITED = 999
	}

	public enum HighLight
	{
		HighLight_NONE = 0,
		HighLight_BR_WIN = 1,
		HighLight_CS_MVP = 2,
		HighLight_BR_STREAK_WIN = 3,
		HighLight_CS_STREAK_WIN = 4,
		HighLight_CS_RANK_GROUP_UPGRADE = 5,
		HighLight_TEAM_ACE = 6,
		HighLight_WEAPON_POWER_TITLE = 7,
		HighLight_BR_RANK_GROUP_UPGRADE = 9,
		HighLight_BR_STREAK_WIN_EXECELLENT = 10,
		HighLight_CS_STREAK_WIN_EXECELLENT = 11,
		HighLight_VETERAN = 12,
		HighLight_RANKING_TITLE = 13,
		HighLight_CS_PEAK_TITLE = 14
	}
}
