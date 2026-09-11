using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIUGCCenterExploreFilterController : UIBaseController
{
	private UIUGCCenterExploreFilterView m_View;

	private List<ExploreFilterTabData> m_TabDataList;

	private List<WorkshopMapPoolSortOptionDesc> m_GenreDataList;

	private List<UIUGCCenterExploreFilterTabItemController> m_CachedTabItems;

	private List<UIUGCCenterExploreFilterGenreItemController> m_CachedGenreItems;

	private int m_SelectedTabIndex;

	private uint m_SelectedGenreId;

	private UIClickMask m_GenreClickMask;

	private bool m_IsGenrePopOpen;

	private Action<ExploreFilterTabData> m_OnTabSelected;

	private Action<uint> m_OnGenreSelected;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetTabData(List<ExploreFilterTabData> tabDataList, List<WorkshopMapPoolSortOptionDesc> genreDataList, Action<ExploreFilterTabData> onTabSelected, Action<uint> onGenreSelected)
	{
	}

	public int GetSelectedTabIndex()
	{
		return 0;
	}

	public uint GetSelectedGenreId()
	{
		return 0u;
	}

	private void InitPoolView()
	{
	}

	public void OnTabItemSelected(int tabIndex)
	{
	}

	private void SelectTab(int tabIndex, bool notify)
	{
	}

	public void SelectTabByIndex(int tabIndex)
	{
	}

	public UIWidget GetTabTutorialWidget(uint seriesId)
	{
		return null;
	}

	public void ScrollToTabBySeriesId(uint seriesId)
	{
	}

	private void InitGenreView()
	{
	}

	public void OnGenreItemSelected(uint genreId)
	{
	}

	public void SetGenreId(uint genreId)
	{
	}

	private void RefreshGenreSelectedState()
	{
	}

	private void OnGenreBtnClick()
	{
	}

	private void OpenGenrePop()
	{
	}

	private void ScrollGenreToSelected()
	{
	}

	private void CloseGenrePop()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
