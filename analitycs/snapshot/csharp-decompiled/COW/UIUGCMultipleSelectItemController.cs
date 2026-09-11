using GCommon;

namespace COW;

internal class UIUGCMultipleSelectItemController : UIBaseController
{
	private UIUGCMultipleSelectItemView m_View;

	private UGCFeedBackConfigData m_Data;

	private bool m_IsSelected;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(UGCFeedBackConfigData data)
	{
	}

	private void OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
