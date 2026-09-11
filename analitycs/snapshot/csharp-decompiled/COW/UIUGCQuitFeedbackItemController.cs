using GCommon;

namespace COW;

public class UIUGCQuitFeedbackItemController : UIBaseController
{
	public delegate void Del(uint index, bool selected);

	public Del ClickItemDel;

	private UIUGCQuitFeedbackItemView m_View;

	private uint m_Id;

	private bool m_Selected;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnClickItem()
	{
	}

	public void SetViewData(int index)
	{
	}

	public void SetViewData(int index, string content)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
