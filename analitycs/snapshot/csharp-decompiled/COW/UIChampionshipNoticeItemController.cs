using GCommon;

namespace COW;

public class UIChampionshipNoticeItemController : UIBaseController
{
	private UIChampionshipNoticeItemView m_View;

	private uint m_GoPos;

	private uint m_SubGoPos;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void RefreshView(string url, uint goPos, uint subGoPos)
	{
	}

	private void OnBtnNoticeItemClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
