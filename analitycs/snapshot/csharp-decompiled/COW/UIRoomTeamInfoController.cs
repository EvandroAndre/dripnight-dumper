using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIRoomTeamInfoController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIRoomTeamInfoView m_View;

	private List<UIRoomTeamInfoItemController> m_MemberList;

	private UIModelCustomRoom m_ModelRoom;

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

	public void RefreshViewData()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnMaskClick()
	{
	}

	public override void Hide()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}
}
