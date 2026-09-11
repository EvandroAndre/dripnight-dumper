using System.Collections.Generic;
using GCommon;

namespace COW;

public class UILoginHistoryPopupWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UILoginHistoryPopupWndView m_View;

	private UIModelSetting m_ModeSetting;

	private List<UILoginHistoryItemController> m_UILoginHistoryItemControllerList;

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

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void SetViewData()
	{
	}

	private void OnLogoutAllBtnClick()
	{
	}

	public void SetOTPBindTips()
	{
	}

	private void OnGotoBtnClick()
	{
	}

	private void _003COnLogoutAllBtnClick_003Eb__9_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
