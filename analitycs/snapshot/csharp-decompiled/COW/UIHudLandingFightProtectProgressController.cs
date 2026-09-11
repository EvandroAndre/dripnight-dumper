using GCommon;

namespace COW;

public class UIHudLandingFightProtectProgressController : UIBaseController
{
	private UIHudLandingFightProtectProgressView m_View;

	private UIColor[] m_TeammateColors;

	private UILabel[] m_TeammateLabels;

	private BitArrayBoolean m_Visible;

	private const uint ISVISIBLE_OTHER_NOT_IN_REVIVE_POINT = 1u;

	private const uint ISVISIBLE_EXTERNAL_CONTROL = 2u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnOtherEnterLeaveRevivePoint(bool enter)
	{
	}

	private void SetUIVisibility(uint flag, bool visible)
	{
	}

	public void SetExternalVisible(bool visible)
	{
	}

	public void RefreshUI(GEvent evt)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
