namespace proto;

public class EAttendance
{
	public enum VeteranRewardStatus
	{
		VeteranRewardStatus_NOT_SIGNED,
		VeteranRewardStatus_SIGNED,
		VeteranRewardStatus_CLAIMED
	}

	public enum VeteranClass
	{
		VeteranClass_NONE,
		VeteranClass_NOMAL,
		VeteranClass_SENIOR,
		VeteranClass_RICH
	}

	public enum VeteranTaskBigPrize
	{
		VeteranTaskBigPrize_NOT_AVALIBLE,
		VeteranTaskBigPrize_CAN_GET,
		VeteranTaskBigPrize_CLAIMED
	}

	public enum AttendanceType
	{
		AttendanceType_NORMAL,
		AttendanceType_TURNTABLE
	}

	public enum FestivalAttendanceState
	{
		FestivalAttendanceState_NOT_SIGNED = 0,
		FestivalAttendanceState_SIGNED = 1,
		FestivalAttendanceState_CLAIMED = 3
	}

	public enum VeteranAwardType
	{
		VeteranAwardType_NONE,
		VeteranAwardType_RETURN,
		VeteranAwardType_BUNDLE,
		VeteranAwardType_STAGE
	}

	public enum VeteranReturnAwardType
	{
		VeteranReturnAwardType_NONE,
		VeteranReturnAwardType_RETURN_LOGIN,
		VeteranReturnAwardType_FIRST_GAME,
		VeteranReturnAwardType_SIGN_IN
	}

	public enum VeteranTaskClass
	{
		VeteranTaskClass_NONE,
		VeteranTaskClass_SIMPLE,
		VeteranTaskClass_NORMAL,
		VeteranTaskClass_HARD
	}

	public enum VeteranTaskType
	{
		VeteranTaskType_NONE,
		VeteranTaskType_NORMAL,
		VeteranTaskType_COOPERATION,
		VeteranTaskType_DAILY,
		VeteranTaskType_PREVETERAN
	}

	public enum VeteranTag
	{
		VeteranTag_NONE,
		VeteranTag_LEAVEDAYS,
		VeteranTag_ACCOUNTLEVEL,
		VeteranTag_LIFETIME,
		VeteranTag_BRMAXRANKSORT,
		VeteranTag_CSMAXRANKSORT,
		VeteranTag_PREFERMODE
	}

	public enum VeteranLeaveDays
	{
		VeteranLeaveDays_NONE,
		VeteranLeaveDays_SHORT,
		VeteranLeaveDays_NORMAL,
		VeteranLeaveDays_LONG,
		VeteranLeaveDays_VERYLONG
	}

	public enum VeteranPaidLevel
	{
		VeteranPaidLevel_NONE,
		VeteranPaidLevel_NOTR,
		VeteranPaidLevel_SMALLR,
		VeteranPaidLevel_MEDIUMR,
		VeteranPaidLevel_BIGR,
		VeteranPaidLevel_LONGTERMUNPAID
	}

	public enum VeteranReturnLevel
	{
		VeteranReturnLevel_NONE,
		VeteranReturnLevel_JUNIOR,
		VeteranReturnLevel_INTERMEDIATE,
		VeteranReturnLevel_SENIOR
	}

	public enum PreVeteranActionType
	{
		PreVeteranActionType_NONE,
		PreVeteranActionType_ACTIVITY,
		PreVeteranActionType_BUFF
	}

	public enum VeteranTermType
	{
		VeteranTermType_NONE,
		VeteranTermType_SHORT,
		VeteranTermType_LONG
	}

	public enum VeteranAwardOutputType
	{
		VeteranAwardOutputType_NONE,
		VeteranAwardOutputType_WEIGHT,
		VeteranAwardOutputType_WEIGHT_FILTER,
		VeteranAwardOutputType_WEAPON,
		VeteranAwardOutputType_WEAPON_FILTER
	}

	public enum VeteranFeatureType
	{
		VeteranFeatureType_NONE,
		VeteranFeatureType_NO_THRESHOLD_REWARD,
		VeteranFeatureType_NORMAL_LONG_FIRST_GAME_REWARD,
		VeteranFeatureType_SHORT_TASK_REWARD,
		VeteranFeatureType_NORMAL_LONG_SIGN_IN,
		VeteranFeatureType_NORMAL_LONG_BP_FREE,
		VeteranFeatureType_NORMAL_LONG_BP_CHARGE,
		VeteranFeatureType_NORMAL_LONG_BP_PRICE,
		VeteranFeatureType_NORMAL_LONG_TASK_REWARD,
		VeteranFeatureType_PREVET_TASK_REWARD,
		VeteranFeatureType_DISCOUNT_STORE,
		VeteranFeatureType_DISCOUNT_STORE_DISCOUNT,
		VeteranFeatureType_RECOMMEND_PUSH,
		VeteranFeatureType_PREVET_TRIGGER
	}

	public enum VeteranBarrageType
	{
		VeteranBarrageType_NONE,
		VeteranBarrageType_ONLINE_FRIEND,
		VeteranBarrageType_LB_RANK,
		VeteranBarrageType_LB_WP,
		VeteranBarrageType_WINING_STREAKS,
		VeteranBarrageType_RANK_CHANGE
	}
}
