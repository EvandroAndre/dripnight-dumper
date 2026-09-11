using GCommon;
using proto;

namespace COW;

public class UIActivityHistoryPatchNoteItemController : UIEasyListItemController
{
	private UIActivityHistoryPatchNoteItemView m_View;

	private UIModelActivity m_ActivityModel;

	private ClientActivityDesc m_ActivityDesc;

	private AdvertDesc m_CDNSetting;

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

	private void RefreshPatchNoteItem()
	{
	}

	private void OnGoToClick()
	{
	}

	public void Reload()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
