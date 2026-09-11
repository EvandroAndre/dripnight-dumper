using GCommon;
using proto;

namespace COW;

public class UIUGCRecommendationTabController : UIBaseController
{
	private UIUGCRecommendationTabView m_View;

	private int m_SeriesID;

	public int SeriesID => 0;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(WorkshopRecommendSeriesDesc data)
	{
	}

	public void SetLastState(bool isLast)
	{
	}

	public void OnBtnClick()
	{
	}

	public void ToggleSelect(bool selected)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
