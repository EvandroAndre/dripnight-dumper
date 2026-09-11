using GCommon;

namespace COW;

public class UIUGCHotIndicatorController : UIBaseController
{
	private UIUGCHotIndicatorView m_View;

	private bool m_UseHeatValue;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(ulong num, bool isInRight = false, bool isShowCrown = false, bool isShowUGCVip = false, bool useHeatValue = true)
	{
	}

	private void SetInRight(bool isShowCrown = false)
	{
	}

	private void OnHotBtnClick()
	{
	}

	private void OnCrownBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
