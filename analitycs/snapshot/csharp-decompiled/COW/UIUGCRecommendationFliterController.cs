using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIUGCRecommendationFliterController : UIBaseController, UITable2.IUITable2Item
{
	public enum EFliterType
	{
		EFliterType_Genre = 1,
		EFliterType_Pool
	}

	private UIUGCRecommendationFliterView m_View;

	private List<UIUGCRecommendationFliterItemController> m_CachedItemList;

	private UIPopMenuSmallControler m_PopMenuCtrl;

	private UGCRecommendationFliterData m_Data;

	private List<WorkshopMapPoolSortOptionDesc> m_PoolDataList;

	private List<WorkshopMapPoolSortOptionDesc> m_GenreDataList;

	private List<PopMenuData> m_GenreFliterDataList;

	private bool m_IsInitialized;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(UGCRecommendationFliterData data)
	{
	}

	private void RefreshPoolView()
	{
	}

	private void RefreshGenreView()
	{
	}

	public void UpdatePopupStyle(PopUpStyle style)
	{
	}

	private void GenerateGenreFliterMenuData()
	{
	}

	private void OnGenreFliterSelected(object value)
	{
	}

	public void OnSelectItem(uint poolType)
	{
	}

	public void SetDepth(int depth)
	{
	}

	public void ShowTopBg()
	{
	}

	private void RefreshViewData()
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	private bool _003CRefreshGenreView_003Eb__13_0(PopMenuData e)
	{
		return false;
	}

	private bool _003CRefreshViewData_003Eb__20_0(PopMenuData e)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
