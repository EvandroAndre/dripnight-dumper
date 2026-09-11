using GCommon;

namespace COW;

public class UIRoomModeSelectPopupItemController : UIEasyListItemController
{
	private UIRoomModeSelectPopupItemView m_View;

	private FRoomModeSelectData m_Data;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public bool IsSelect()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	private void OnClickSelectBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
