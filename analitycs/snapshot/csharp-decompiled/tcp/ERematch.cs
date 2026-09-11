namespace tcp;

public class ERematch
{
	public enum Proto
	{
		Proto_NONE,
		Proto_ACCEPT,
		Proto_QUIT,
		Proto_SET_TEAM_NTF,
		Proto_ACCEPT_NTF,
		Proto_QUIT_NTF,
		Proto_QUIT_BY_SYSTEM,
		Proto_REMATCH_FAIL_NTF
	}

	public enum ErrCode
	{
		ErrCode_SUSS,
		ErrCode_SETTEAMFAILED,
		ErrCode_NOTEAM,
		ErrCode_NOTINTEAM,
		ErrCode_TEAMEXPIRED,
		ErrCode_PLAYERINVALIDSTATUS,
		ErrCode_MERGEFAILED
	}

	public enum Status
	{
		Status_NONE,
		Status_PENDING,
		Status_ACCEPTED,
		Status_QUIT
	}

	public enum QuitReason
	{
		QuitReason_NONE,
		QuitReason_QUICKSTART,
		QuitReason_VOLUNTARY,
		QuitReason_KICKOUT,
		QuitReason_JOIN,
		QuitReason_LEAVE,
		QuitReason_START,
		QuitReason_CANCELREADY,
		QuitReason_CHANGE,
		QuitReason_CREATEROOM,
		QuitReason_JOINROOM,
		QuitReason_SPECTATEROOM,
		QuitReason_TRANSFERLEADER,
		QuitReason_RECRUIT,
		QuitReason_RESERVATION,
		QuitReason_OFFLINE,
		QuitReason_MINORPROTECTION,
		QuitReason_ACCOUNTBAN,
		QuitReason_LOWCREDITSCORE,
		QuitReason_RANKNOTMATCH,
		QuitReason_REACHHEROICORMASTER,
		QuitReason_NEGATIVEGAME
	}
}
