using GCommon;

namespace COW;

public class UICreateRoomTagController : UIBaseController
{
	private UICreateRoomTagView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetIsNew(bool isActive = true)
	{
	}

	public void SetIsHot(bool isActive = true)
	{
	}

	public void SetViewData(UIModelCustomRoom.ECustomRoomGameSetting setting)
	{
	}

	public bool SetViewDataByDropList(uint dropID)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
