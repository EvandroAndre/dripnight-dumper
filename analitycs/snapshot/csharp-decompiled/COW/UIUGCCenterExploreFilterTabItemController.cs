using GCommon;

namespace COW;

public class UIUGCCenterExploreFilterTabItemController : UIBaseController
{
	private UIUGCCenterExploreFilterTabItemView m_View;

	private ExploreFilterTabData m_TabData;

	private int m_Index;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(ExploreFilterTabData data, int index)
	{
	}

	public void RefreshSelectedState(int selectedIndex)
	{
	}

	public void RefreshLineState(bool show)
	{
	}

	public UIWidget GetTutorialAnchorWidget()
	{
		return null;
	}

	private void OnBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
