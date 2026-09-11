using GCommon;

namespace COW;

public class UIUGCSingleSelectItemController : UIBaseController
{
	private UIUGCSingleSelectItemView m_View;

	private UGCFeedBackConfigData m_Data;

	private bool m_IsSelected;

	public UGCFeedBackConfigData Data => null;

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

	public void OnItemBtnClick()
	{
	}

	public void OnItemBtnSelect()
	{
	}

	public void OnItemBtnUnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
