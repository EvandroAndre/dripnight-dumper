using GCommon;

namespace COW;

public class UIConnectionReportController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIConnectionReportView m_View;

	private UIModelConnectionReport m_Model;

	private bool m_NeedShowState;

	private UIModelConnectionReport ConnectionModel => null;

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

	public void ShowInfo(string loc_key)
	{
	}

	private void OnSendBtnClick()
	{
	}

	private void RefreshButtonState()
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
