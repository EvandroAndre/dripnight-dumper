namespace proto;

public class ECreditScore
{
	public enum CreditCdtType
	{
		CreditCdtType_NONE,
		CreditCdtType_RANK_NO_SCORE,
		CreditCdtType_BAN_GAME,
		CreditCdtType_BAN_ROOM,
		CreditCdtType_BAN_CUP_CHAMPIONSHIP
	}

	public enum ReportType
	{
		ReportType_NONE,
		ReportType_HANG_UP,
		ReportType_LEAVING,
		ReportType_POISON_SUICIDE,
		ReportType_UNCOOPERATIVE,
		ReportType_TEAMING,
		ReportType_IMPROPER_NAME,
		ReportType_IMPROPER_SPEECH,
		ReportType_HACKER,
		ReportType_ILLEGAL_EXTERNAL_ICON,
		ReportType_ILLEGAL_SIGNATURE,
		ReportType_BRUSH_LEADERBOARD,
		ReportType_DISTURBED_INVITE,
		ReportType_IMPROPER_ICE_WALL,
		ReportType_PHOTO_WALL
	}

	public enum MainReason
	{
		MainReason_NONE,
		MainReason_CHEAT,
		MainReason_BAD_BEAHVIOR,
		MainReason_TEAMING,
		MainReason_DIRTY_NAME,
		MainReason_IMPROPER_SPEECH,
		MainReason_ILLEGAL_EXTERNAL_ICON,
		MainReason_ILLEGAL_SIGNATURE,
		MainReason_RANKING_MANIPULATION,
		MainReason_SPAM_INVITING,
		MainReason_IMPROPER_CLANNAME,
		MainReason_IMPROPER_CLANSLOGAN,
		MainReason_PHOTO_WALL
	}

	public enum SubReason
	{
		SubReason_NONE = 0,
		SubReason_HANGUP = 1,
		SubReason_LEAVING = 2,
		SubReason_POISON_SUICIDE = 3,
		SubReason_UNCOOPERATIVE = 4,
		SubReason_TEAMING = 5,
		SubReason_IMPROPER_NAME = 6,
		SubReason_IMPROPER_SPEECH = 7,
		SubReason_AIMBOT = 101,
		SubReason_MEDKITRUN = 102,
		SubReason_WALL_HACK = 103,
		SubReason_OTHER = 104,
		SubReason_WORKSHOP_TAMPERING = 105
	}

	public enum AwardType
	{
		AwardType_NONE,
		AwardType_WEEKLY,
		AwardType_DAILY
	}

	public enum RewardState
	{
		RewardState_INVALID,
		RewardState_UNCLAIMED,
		RewardState_CLAIMED
	}

	public enum SummaryLevel
	{
		SummaryLevel_NOT_INIT,
		SummaryLevel_A,
		SummaryLevel_B,
		SummaryLevel_C,
		SummaryLevel_D
	}

	public enum PunishOtherType
	{
		PunishOtherType_NONE,
		PunishOtherType_MATCH_BEHAVIOR,
		PunishOtherType_CHAT_MSG_REPORT,
		PunishOtherType_VOICE_DETECTING
	}
}
