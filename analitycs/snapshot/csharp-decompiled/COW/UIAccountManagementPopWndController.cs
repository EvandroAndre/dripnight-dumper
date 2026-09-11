using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIAccountManagementPopWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIAccountManagementPopWndView m_View;

	private UIModelSetting m_Modelsetting;

	private UIModelLogin m_ModelLogin;

	private List<UIAccountManagementItemController> m_Ctrls;

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

	public void SetViewData(List<UISettingAccountBtnController> list)
	{
	}

	private void SetMyPlatformInfo()
	{
	}

	private void SetOtherPlatformInfo(List<UISettingAccountBtnController> list)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
