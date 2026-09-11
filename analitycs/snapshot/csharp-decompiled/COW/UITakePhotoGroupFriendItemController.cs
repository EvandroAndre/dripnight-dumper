using GCommon;

namespace COW;

public class UITakePhotoGroupFriendItemController : UIEasyListItemController
{
	private TakePhotoGroupFriendInfo m_Data;

	private UIBaseProfileInfoController m_ProfileCtrl;

	private UITakePhotoGroupFriendItemView m_View;

	private UITakePhotoGroupBaseController Parent => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void OnSelectedBtn()
	{
	}

	public void RefreshSelectView()
	{
	}

	public void RefreshIsSelect(ulong aid)
	{
	}

	public void SetVertical()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
