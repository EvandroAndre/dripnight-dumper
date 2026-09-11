namespace tcp;

public class EAntiAddiction
{
	public enum Proto
	{
		Proto_NONE,
		Proto_HINT_NTF,
		Proto_ANTI_ADDICTION_INIT,
		Proto_ANTI_CHILD_UNBIND,
		Proto_ANTI_GUARDIAN_UNBIND,
		Proto_ANTI_GUARDIAN_ACCEPT_APPLY,
		Proto_ANTI_GUARDIAN_REFUSE_APPLY,
		Proto_ANTI_ADDICTION_PARENTAL_CONTROL,
		Proto_ANTI_CHILD_APPLY_BIND,
		Proto_ANTI_CHILD_CANCEL_APPLY_BIND,
		Proto_ANTI_ADDICTION_UPDATE_PLAYTIME,
		Proto_ANTI_ADDICTION_UPDATE_PARENTAL_CONTROL,
		Proto_ANTI_ADDICTION_UNBIND_RESET_NTF
	}

	public enum ErrCode
	{
		ErrCode_SUSS
	}

	public enum TotalTimeBanMode
	{
		TotalTimeBanMode_NONE,
		TotalTimeBanMode_RANKING,
		TotalTimeBanMode_ALL,
		TotalTimeBanMode_WARN,
		TotalTimeBanMode_KICK
	}

	public enum AgeState
	{
		AgeState_NONE,
		AgeState_UNDER_AGE,
		AgeState_ADULT
	}

	public enum PlayTimeResetType
	{
		PTRT_DAILY,
		PTRT_WEEKLY,
		PTRT_MONTHLY
	}
}
