namespace proto;

public class EAntiAddiction
{
	public enum TotalTimeBanMode
	{
		TotalTimeBanMode_NONE,
		TotalTimeBanMode_RANKING,
		TotalTimeBanMode_ALL,
		TotalTimeBanMode_WARN,
		TotalTimeBanMode_KICK
	}

	public enum HintType
	{
		HintType_NONE,
		HintType_CONTINUOUS_TIME,
		HintType_TOTAL_TIME,
		HintType_ALL
	}

	public enum AgeState
	{
		AgeState_NONE,
		AgeState_CHILD,
		AgeState_TEENAGER,
		AgeState_ADULT,
		AgeState_ALL_PLAYERS,
		AgeState_BR_INDEX_5,
		AgeState_BR_INDEX_6,
		AgeState_BR_INDEX_7,
		AgeState_BR_INDEX_8,
		AgeState_BR_INDEX_9
	}

	public enum AntiAddictionType
	{
		AAT_FFI_GENERAL,
		AAT_BR_PARENTAL_CONTROL
	}

	public enum PlayTimeResetType
	{
		PTRT_DAILY,
		PTRT_WEEKLY,
		PTRT_MONTHLY
	}

	public enum AuthState
	{
		AuthState_NONE,
		AuthState_SKIPPED,
		AuthState_ING,
		AuthState_FINISHED_FAILED,
		AuthState_FINISHED_SUCCESS
	}

	public enum AgeCtrlStatus
	{
		AgeCtrlStatus_NONE,
		AgeCtrlStatus_ADULT,
		AgeCtrlStatus_MINOR,
		AgeCtrlStatus_UNLEGISLATED,
		AgeCtrlStatus_UNVERIFIED
	}

	public enum AgeCtrlResult
	{
		AgeCtrlResult_UNLEGISLATED,
		AgeCtrlResult_UNVERIFIED,
		AgeCtrlResult_ADULT,
		AgeCtrlResult_MINOR_APPROVED,
		AgeCtrlResult_MINOR_PENDING,
		AgeCtrlResult_MINOR_DENIED
	}
}
