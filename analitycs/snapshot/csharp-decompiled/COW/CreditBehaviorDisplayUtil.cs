using GCommon;
using proto;

namespace COW;

public static class CreditBehaviorDisplayUtil
{
	public const string ExcellentBehaviorIconName = "FF_UI_CreditScore_Icon_Excellent";

	public const string ExcellentBehaviorBadgeLocKey = "T_54_L_BEHAVIOR_EXCELLENT_BADGE";

	public static bool IsExcellent(ECreditScore.SummaryLevel summaryLevel)
	{
		return false;
	}

	public static bool IsExcellent(uint summaryLevel)
	{
		return false;
	}

	public static ResourceID GetExcellentBehaviorIconResourceID()
	{
		return default(ResourceID);
	}
}
