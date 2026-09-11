using GCommon;
using proto;

namespace COW;

public class UIFlashStoreActivityGroupTitleController : UIBaseController
{
	private uint m_FlashStoreActivityID;

	private uint m_ActivityGroupID;

	private EActivity.ActivityType m_ActivityType;

	private UIFlashStoreActivityGroupTitleView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SetupDefaultState()
	{
	}

	private static bool IsCountdownNeeded(EActivity.ActivityType activityType)
	{
		return false;
	}

	private ulong GetCountdownTargetTime()
	{
		return 0uL;
	}

	private static string GetActivityTypeTitleKey(EActivity.ActivityType activityType)
	{
		return null;
	}

	private void RefreshCountdown()
	{
	}

	public UIFlashStoreActivityGroupTitleController SetViewData(uint activityType, uint flashStoreActivityID, uint activityGroupID)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
