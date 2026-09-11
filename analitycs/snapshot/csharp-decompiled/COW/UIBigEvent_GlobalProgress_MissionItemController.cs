using GCommon;

namespace COW;

public class UIBigEvent_GlobalProgress_MissionItemController : UIBigEvent_Template_MissionItemBaseController
{
	private UIBigEvent_GlobalProgress_MissionItemView m_View;

	private UIBigEvent_GlobalProgress_Mission2Data m_PVE_MissionData;

	protected override UICommonRewardWndController.WndStyleEnum WndStyle => UICommonRewardWndController.WndStyleEnum.COMMON;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	protected override bool RefreshView()
	{
		return false;
	}

	protected override void RefreshAward()
	{
	}

	public UICommonRewardWndController.WndStyleEnum _003C_003EiFixBaseProxy_get_WndStyle()
	{
		return UICommonRewardWndController.WndStyleEnum.COMMON;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	public bool _003C_003EiFixBaseProxy_RefreshView()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_RefreshAward()
	{
	}
}
