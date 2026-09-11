using GCommon;
using tcp;

namespace COW;

public class UIChatRoomRecruitItemController : UIEasyListItemController
{
	private UIChatRoomRecruitItemView m_View;

	private bool m_CanClick;

	private RecruitRoomInfo m_RoomInfo;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(uint mapId, uint gameMode, uint groupMode, uint maxGroupNum, uint currentGroupNum, bool canClick = false)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void OnRoomJoinBtnClick()
	{
	}

	private void OnRoomJoinSecondConfirmSuccess()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
