using GCommon;
using tcp;

namespace COW;

internal class UIRoomListSettingPreviewMinController : UIPopupWindowController
{
	private UIRoomListSettingPreviewMinView m_View;

	protected RoomBasicInfo m_RoomInfo;

	protected UIModelCustomRoom m_ModelRoom;

	protected bool m_CanJoin;

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

	public void UpdatePanelDepth(int depth)
	{
	}

	public void SetViewData(RoomBasicInfo roomInfo)
	{
	}

	private bool IsSocialPreviewMode(uint gameMode)
	{
		return false;
	}

	protected void RefreshJoinStatus()
	{
	}

	public void OnCloseBtnClick()
	{
	}

	public void OnPlayJoinRoomClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
