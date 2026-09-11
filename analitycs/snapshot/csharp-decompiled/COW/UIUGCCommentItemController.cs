using GCommon;

namespace COW;

internal class UIUGCCommentItemController : UIBaseController
{
	private UIUGCCommentItemView m_View;

	private WorkshopCommentConfigData m_Data;

	private bool m_HasSelected;

	private bool m_CanBeSelected;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetToBeSelectedViewData(WorkshopCommentConfigData data, bool hasSelected, bool canSelected)
	{
	}

	private void OnUIUGCCommentItemClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
