using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIUGCRecommendationV2Controller : UIBaseController, IUIModelDataChangeObserver
{
	public enum TemplateType
	{
		EditorRecommendation,
		RecommendedItem,
		WaterfallFliter,
		WaterfallItem,
		WaterfallPlaceholder,
		NewPlayerRecommendation
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<WorkshopRecommendSeriesDesc> _003C_003E9__37_0;

		public static Converter<WorkshopCodeWithRankInfo, string> _003C_003E9__44_0;

		public static Comparison<WorkshopRecommendSeriesInfo> _003C_003E9__45_3;

		public static Converter<WorkshopRecommendSeriesInfo, SceneEditSlotInfo> _003C_003E9__45_0;

		public static Comparison<WorkshopLatestInfo> _003C_003E9__45_4;

		public static Converter<WorkshopLatestInfo, SceneEditSlotInfo> _003C_003E9__45_5;

		public static Predicate<SceneEditSlotInfo> _003C_003E9__45_6;

		public static Predicate<WorkshopEditorChoiceDesc> _003C_003E9__49_0;

		public static Predicate<WorkshopEditorChoiceDesc> _003C_003E9__49_1;

		public static Predicate<WorkshopRecommendSeriesDesc> _003C_003E9__49_2;

		public static Comparison<WorkshopMapPoolSortOptionDesc> _003C_003E9__58_0;

		public static Predicate<WorkshopMapPoolSortOptionDesc> _003C_003E9__58_1;

		public static Predicate<WorkshopMapPoolSortOptionDesc> _003C_003E9__58_2;

		public static Predicate<WorkshopRecommendSeriesDesc> _003C_003E9__59_0;

		public static Predicate<WorkshopRecommendSeriesDesc> _003C_003E9__60_0;

		public static Converter<WorkshopCodeWithRankInfo, string> _003C_003E9__64_1;

		internal int _003CInitRecommendSeries_003Eb__37_0(WorkshopRecommendSeriesDesc x, WorkshopRecommendSeriesDesc y)
		{
			return 0;
		}

		internal string _003CCheckExposure_003Eb__44_0(WorkshopCodeWithRankInfo temp)
		{
			return null;
		}

		internal int _003COnDataChanged_003Eb__45_3(WorkshopRecommendSeriesInfo a, WorkshopRecommendSeriesInfo b)
		{
			return 0;
		}

		internal SceneEditSlotInfo _003COnDataChanged_003Eb__45_0(WorkshopRecommendSeriesInfo temp)
		{
			return null;
		}

		internal int _003COnDataChanged_003Eb__45_4(WorkshopLatestInfo a, WorkshopLatestInfo b)
		{
			return 0;
		}

		internal SceneEditSlotInfo _003COnDataChanged_003Eb__45_5(WorkshopLatestInfo temp)
		{
			return null;
		}

		internal bool _003COnDataChanged_003Eb__45_6(SceneEditSlotInfo e)
		{
			return false;
		}

		internal bool _003CRefreshTable2Data_003Eb__49_0(WorkshopEditorChoiceDesc e)
		{
			return false;
		}

		internal bool _003CRefreshTable2Data_003Eb__49_1(WorkshopEditorChoiceDesc e)
		{
			return false;
		}

		internal bool _003CRefreshTable2Data_003Eb__49_2(WorkshopRecommendSeriesDesc e)
		{
			return false;
		}

		internal int _003CInitWaterfallFliterData_003Eb__58_0(WorkshopMapPoolSortOptionDesc a, WorkshopMapPoolSortOptionDesc b)
		{
			return 0;
		}

		internal bool _003CInitWaterfallFliterData_003Eb__58_1(WorkshopMapPoolSortOptionDesc e)
		{
			return false;
		}

		internal bool _003CInitWaterfallFliterData_003Eb__58_2(WorkshopMapPoolSortOptionDesc e)
		{
			return false;
		}

		internal bool _003CFliterWaterfallByPoolType_003Eb__59_0(WorkshopRecommendSeriesDesc e)
		{
			return false;
		}

		internal bool _003CFliterWaterfallByGenreID_003Eb__60_0(WorkshopRecommendSeriesDesc e)
		{
			return false;
		}

		internal string _003CRefreshWaterfallData_003Eb__64_1(WorkshopCodeWithRankInfo temp)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass45_0
	{
		public uint seriesID;

		internal bool _003COnDataChanged_003Eb__1(WorkshopRecommendSeriesDesc e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass45_1
	{
		public WorkshopRecommendSeriesDesc item;

		internal bool _003COnDataChanged_003Eb__2(WorkshopCategoryPageDesc e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass57_0
	{
		public int seriesID;

		internal bool _003COnSelectItemBySeriesID_003Eb__0(UIUGCRecommendationTabController e)
		{
			return false;
		}
	}

	private sealed class _003CReposition_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCRecommendationV2Controller _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CReposition_003Ed__43(int _003C_003E1__state)
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

	private UIUGCRecommendationV2View m_View;

	private UIModelSceneEdit m_Model;

	private UIModelNewPlayerRecommendation m_ModelNewPlayer;

	private List<WorkshopRecommendSeriesDesc> m_Serieslist;

	private Dictionary<uint, int> m_ModularDict;

	private int m_HistoryIndex;

	private int m_HistoryTable2Index;

	private int m_SubscriptionIndex;

	private int m_SubscriptionTable2Index;

	private bool m_NeedReposition;

	private int m_NeedMoveToSeriesID;

	private bool m_WorkShopFeedBack;

	private bool m_ResourceShopFeedBack;

	private Vector2 m_MapSlotSize;

	private Dictionary<int, UIUGCRecommendationItemV2Data> m_ViewDataDict;

	private Dictionary<uint, HashSet<string>> m_ViewDataExposureDict;

	private List<UIUGCRecommendationTabController> m_TabCtrlList;

	private UITable2VirtualBoundsHelper m_Table2VirtualBoundsHelper;

	private List<int> m_ViewDataIndices;

	private bool m_Table2Init;

	private UGCRecommendationFliterData m_WaterfallFliterData;

	private WaterfallPoolData m_WaterfallPoolData;

	private UIUGCRecommendationFliterController m_WaterfallFliterCtrl;

	private bool m_HasWaterfall;

	private int m_WaterfallSeriesID;

	private uint m_WaterfallPoolType;

	private uint m_WaterfallGenreID;

	private int m_WaterfallFliterIndex;

	private bool m_WaterfallDynamicClipping;

	private int m_NewPlayerIndex;

	private bool m_IsPreferencePopupOpen;

	private bool m_PreferenceShownThisSession;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnWorkShopFeedBack()
	{
	}

	private void OnResourceShopFeedBack()
	{
	}

	private void OnRefreshNewPlayerRecommendationState()
	{
	}

	private void CheckOpenCreatorFeedbackWnd()
	{
	}

	private void OnBtnTurnToSearchMap()
	{
	}

	private void InitRecommendSeries()
	{
	}

	private void RequestData()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void UpdateLeftTabYPosition(float yPosition)
	{
	}

	public void StoreBeforeClose()
	{
	}

	public void RestoreWhenOpen()
	{
	}

	private IEnumerator Reposition()
	{
		return null;
	}

	private void CheckExposure()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void InitTable2Templates()
	{
	}

	private void RefreshTable2Data(bool keepScrollPosition = false)
	{
	}

	private void RefreshTable2ItemData(int index)
	{
	}

	private void RefreshTable2WaterfallData(List<WaterfallValidData> data)
	{
	}

	private int AddWaterfallPlaceholder(int index)
	{
		return 0;
	}

	private string GetWaterfallLogInfo(int index, string type, string strategy)
	{
		return null;
	}

	private void InitVirtualBoundsHelper()
	{
	}

	private void UpdateTabsHighlightState()
	{
	}

	private void SelectAndFocusTabWithIndex(int index)
	{
	}

	public bool OnSelectItemBySeriesID(int seriesID, bool remember = false)
	{
		return false;
	}

	private void InitWaterfallFliterData()
	{
	}

	public void FliterWaterfallByPoolType(uint poolType, bool forceSelect = false)
	{
	}

	public void FliterWaterfallByGenreID(uint genreID)
	{
	}

	private void UnpinCurrentWaterfallSlots()
	{
	}

	private void CheckWaterfallFliterPosition()
	{
	}

	private bool IfWaterfallFliterHigherThanContainer()
	{
		return false;
	}

	private void RefreshWaterfallData()
	{
	}

	private void ShowPlayPreference()
	{
	}

	private bool _003CCheckExposure_003Eb__44_1(WorkshopCodeWithRankInfo temp)
	{
		return false;
	}

	private UITable2.IUITable2Item _003CInitTable2Templates_003Eb__48_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Templates_003Eb__48_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Templates_003Eb__48_2()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Templates_003Eb__48_3()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Templates_003Eb__48_4()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Templates_003Eb__48_5()
	{
		return null;
	}

	private bool _003CRefreshWaterfallData_003Eb__64_0(WorkshopCodeWithRankInfo temp)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
