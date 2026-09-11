using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIBigEventFriendReunionController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIBigEventFriendReunionView m_View;

	private UIModelActivity m_ModelActivity;

	private List<UIBaseController> m_FriendReunionControllers;

	private ActivityGroupDesc m_GroupDesc;

	private int m_ADWidth;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void CreateEventDescList()
	{
	}

	private void UpdateIntroData(ActivityGroupDesc data)
	{
	}

	private void UpdateActivityInfo()
	{
	}

	public void SetAD(string url)
	{
	}

	private void OnDownloadFinish()
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

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
