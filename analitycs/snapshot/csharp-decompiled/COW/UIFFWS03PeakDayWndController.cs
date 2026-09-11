using GCommon;
using proto;

namespace COW;

public class UIFFWS03PeakDayWndController : UIBigEventPeakDayWndBaseController
{
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override EActivity.SubType GetActivitySubType()
	{
		return EActivity.SubType.SubType_NONE;
	}

	public override ELimitedEvent.EventID GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public override string GetPeakDayExpiredKey()
	{
		return null;
	}

	public override string GetPeakDayLoginKey()
	{
		return null;
	}

	public override UICommonRewardWndController.WndStyleEnum GetRewandWndStyle()
	{
		return UICommonRewardWndController.WndStyleEnum.COMMON;
	}

	public EActivity.SubType _003C_003EiFixBaseProxy_GetActivitySubType()
	{
		return EActivity.SubType.SubType_NONE;
	}

	public ELimitedEvent.EventID _003C_003EiFixBaseProxy_GetBigEventId()
	{
		return ELimitedEvent.EventID.EventID_NONE;
	}

	public string _003C_003EiFixBaseProxy_GetPeakDayExpiredKey()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetPeakDayLoginKey()
	{
		return null;
	}

	public UICommonRewardWndController.WndStyleEnum _003C_003EiFixBaseProxy_GetRewandWndStyle()
	{
		return UICommonRewardWndController.WndStyleEnum.COMMON;
	}
}
