using GCommon;

namespace COW;

public class UIBigEvent_CustomTC_MissionItemController : UIBigEvent_Template_MissionItemBaseController
{
	private UIBigEvent_CustomTC_MissionItemView m_View;

	protected override UICommonRewardWndController.WndStyleEnum WndStyle => UICommonRewardWndController.WndStyleEnum.COMMON;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitCND()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public UICommonRewardWndController.WndStyleEnum _003C_003EiFixBaseProxy_get_WndStyle()
	{
		return UICommonRewardWndController.WndStyleEnum.COMMON;
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
