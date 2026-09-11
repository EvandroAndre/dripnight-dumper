using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIUGCCenterExploreController : UIBaseController, IUIModelDataChangeObserver
{
	public enum TemplateType
	{
		WaterfallItem,
		WaterfallPlaceholder
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<WorkshopMapPoolSortOptionDesc> _003C_003E9__21_0;

		public static Comparison<WorkshopMapPoolSortOptionDesc> _003C_003E9__23_0;

		public static Predicate<ExploreFilterTabData> _003C_003E9__25_0;

		public static Predicate<SceneEditSlotInfo> _003C_003E9__31_0;

		public static Predicate<WorkshopAuthorSlotInfo> _003C_003E9__48_2;

		public static Predicate<ExploreFilterTabData> _003C_003E9__48_4;

		internal int _003CBuildExploreTabDataList_003Eb__21_0(WorkshopMapPoolSortOptionDesc a, WorkshopMapPoolSortOptionDesc b)
		{
			return 0;
		}

		internal int _003CBuildGenreDataList_003Eb__23_0(WorkshopMapPoolSortOptionDesc a, WorkshopMapPoolSortOptionDesc b)
		{
			return 0;
		}

		internal bool _003CInitDefaultTab_003Eb__25_0(ExploreFilterTabData t)
		{
			return false;
		}

		internal bool _003CBuildSubscriptionMapInfos_003Eb__31_0(SceneEditSlotInfo e)
		{
			return false;
		}

		internal bool _003COnDataChanged_003Eb__48_2(WorkshopAuthorSlotInfo e)
		{
			return false;
		}

		internal bool _003COnDataChanged_003Eb__48_4(ExploreFilterTabData t)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public uint pageId;

		internal UISceneEditTemplateMapInfo _003CBuildSubscriptionMapInfos_003Eb__1(SceneEditSlotInfo temp)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass48_0
	{
		public uint pageId;

		internal UISceneEditTemplateMapInfo _003COnDataChanged_003Eb__0(WorkshopHotInfo data)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass48_1
	{
		public uint pageId;

		internal UISceneEditTemplateMapInfo _003COnDataChanged_003Eb__1(WorkshopHotInfo data)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass48_2
	{
		public uint pageId;

		internal UISceneEditTemplateMapInfo _003COnDataChanged_003Eb__3(WorkshopAuthorSlotInfo item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_0
	{
		public string prefsKey;

		internal void _003CCheckPremiumTutorial_003Eb__0()
		{
		}
	}

	private sealed class _003CCoCheckExposureAtEndOfFrame_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCCenterExploreController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoCheckExposureAtEndOfFrame_003Ed__42(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UIUGCCenterExploreView m_View;

	private UIModelSceneEdit m_Model;

	private WaterfallPoolData m_WaterfallPoolData;

	private uint m_WaterfallPoolType;

	private uint m_WaterfallGenreID;

	private bool m_Table2Init;

	private UIUGCCenterExploreFilterController m_FilterCtrl;

	private List<ExploreFilterTabData> m_TabDataList;

	private List<WorkshopMapPoolSortOptionDesc> m_GenreDataList;

	private ExploreFilterTabData m_CurrentTab;

	private Coroutine m_CheckExposureCoroutine;

	private Dictionary<uint, HashSet<string>> m_CategoryExposureDict;

	private Dictionary<int, List<UISceneEditTemplateMapInfo>> m_CategoryMapInfos;

	private const uint UGC_PREMIUN_BENEFIT_MAP_PAGE = 99u;

	private int m_NeedSelectSeriesId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void ResetScrollViewMotion()
	{
	}

	private void BuildFilterData()
	{
	}

	private void BuildExploreTabDataList()
	{
	}

	private static bool IsLeaderboardPool(uint poolType)
	{
		return false;
	}

	private void BuildGenreDataList()
	{
	}

	private void OpenFilterController()
	{
	}

	private void InitDefaultTab()
	{
	}

	private void InitWaterfall()
	{
	}

	private void OnTabSelected(ExploreFilterTabData tabData)
	{
	}

	private void OnGenreSelected(uint genreId)
	{
	}

	public void FilterWaterfallByGenreID(uint genreID)
	{
	}

	private void RequestCategoryData(ExploreFilterTabData tabData)
	{
	}

	private void BuildSubscriptionMapInfos(int tabIndex)
	{
	}

	private void InitTable2Templates()
	{
	}

	private bool IsCurrentWaterfallTab()
	{
		return false;
	}

	private void RefreshTable2Data()
	{
	}

	private void RefreshTable2WaterfallMode()
	{
	}

	private void RefreshTable2CategoryMode()
	{
	}

	private uint GetCategoryPageId(int tabIndex)
	{
		return 0u;
	}

	private void RefreshTable2WaterfallData(List<WaterfallValidData> data)
	{
	}

	private int AddWaterfallPlaceholder(int index)
	{
		return 0;
	}

	private string GetWaterfallLogInfo(int index, string type)
	{
		return null;
	}

	private void CheckExposureAtEndOfFrame()
	{
	}

	private IEnumerator CoCheckExposureAtEndOfFrame()
	{
		return null;
	}

	private void CancelCheckExposureCoroutine()
	{
	}

	private void CheckExposure()
	{
	}

	private void CheckWaterfallExposure()
	{
	}

	private void CheckCategoryExposure()
	{
	}

	private bool TryMarkCategoryItemExposed(uint seriesID, string code)
	{
		return false;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void CheckPremiumTutorial()
	{
	}

	public void SelectTabBySeriesId(int seriesId)
	{
	}

	private bool DoSelectTabBySeriesId()
	{
		return false;
	}

	private void OnUserDragStarted()
	{
	}

	public void StoreBeforeClose()
	{
	}

	public void RestoreWhenOpen()
	{
	}

	private UITable2.IUITable2Item _003CInitTable2Templates_003Eb__32_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Templates_003Eb__32_1()
	{
		return null;
	}

	private bool _003CDoSelectTabBySeriesId_003Eb__53_0(ExploreFilterTabData t)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
