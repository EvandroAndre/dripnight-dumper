using GCommon;
using tcp;

namespace COW;

public class UIUGCRoomListItemController : UIEasyListItemController
{
	private UIUGCRoomListItemView m_View;

	private RoomBasicInfo m_Data;

	private UIModelCustomRoom m_Model;

	private uint m_DelayCallID;

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

	public RoomBasicInfo GetRoomInfo()
	{
		return null;
	}

	public void SelectItem()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void RefreshCDNMap()
	{
	}

	private void UpdateGroupModeStatus()
	{
	}

	private void UpdateRoomStatus(ERoom.State status)
	{
	}

	private void HighlightRoomItem(RoomBasicInfo info)
	{
	}

	public void SetWidgetWidth(int width)
	{
	}

	public void PlayTweenAnim()
	{
	}

	private void _003CRefreshCDNMap_003Eb__12_0()
	{
	}

	private void _003CPlayTweenAnim_003Eb__17_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
