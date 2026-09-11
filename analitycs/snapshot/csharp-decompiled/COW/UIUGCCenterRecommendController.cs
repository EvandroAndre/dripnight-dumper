using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIUGCCenterRecommendController : UIBaseController, IUIModelDataChangeObserver
{
	public enum TemplateType
	{
		EditorRecommendation,
		RecommendedItem,
		NewPlayerRecommendation
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<WorkshopRecommendSeriesDesc> _003C_003E9__27_0;

		public static Predicate<WorkshopEditorChoiceDesc> _003C_003E9__32_0;

		public static Predicate<WorkshopEditorChoiceDesc> _003C_003E9__32_1;

		public static Comparison<WorkshopRecommendSeriesInfo> _003C_003E9__39_3;

		public static Converter<WorkshopRecommendSeriesInfo, SceneEditSlotInfo> _003C_003E9__39_0;

		public static Comparison<WorkshopLatestInfo> _003C_003E9__39_4;

		public static Converter<WorkshopLatestInfo, SceneEditSlotInfo> _003C_003E9__39_5;

		public static Predicate<SceneEditSlotInfo> _003C_003E9__39_6;

		internal int _003CInitRecommendSeries_003Eb__27_0(WorkshopRecommendSeriesDesc x, WorkshopRecommendSeriesDesc y)
		{
			return 0;
		}

		internal bool _003CRefreshTable2Data_003Eb__32_0(WorkshopEditorChoiceDesc e)
		{
			return false;
		}

		internal bool _003CRefreshTable2Data_003Eb__32_1(WorkshopEditorChoiceDesc e)
		{
			return false;
		}

		internal int _003COnDataChanged_003Eb__39_3(WorkshopRecommendSeriesInfo a, WorkshopRecommendSeriesInfo b)
		{
			return 0;
		}

		internal SceneEditSlotInfo _003COnDataChanged_003Eb__39_0(WorkshopRecommendSeriesInfo temp)
		{
			return null;
		}

		internal int _003COnDataChanged_003Eb__39_4(WorkshopLatestInfo a, WorkshopLatestInfo b)
		{
			return 0;
		}

		internal SceneEditSlotInfo _003COnDataChanged_003Eb__39_5(WorkshopLatestInfo temp)
		{
			return null;
		}

		internal bool _003COnDataChanged_003Eb__39_6(SceneEditSlotInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public uint seriesID;

		internal bool _003COnDataChanged_003Eb__1(WorkshopRecommendSeriesDesc e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_1
	{
		public WorkshopRecommendSeriesDesc item;

		internal bool _003COnDataChanged_003Eb__2(WorkshopCategoryPageDesc e)
		{
			return false;
		}
	}

	private sealed class _003CCoCheckExposureAtEndOfFrame_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCCenterRecommendController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoCheckExposureAtEndOfFrame_003Ed__36(int _003C_003E1__state)
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

	private sealed class _003CReposition_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCCenterRecommendController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CReposition_003Ed__34(int _003C_003E1__state)
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

	public Action OnSwipeToNext;

	private UIUGCCenterRecommendView m_View;

	private UIModelSceneEdit m_Model;

	private UIModelNewPlayerRecommendation m_ModelNewPlayer;

	private List<WorkshopRecommendSeriesDesc> m_Serieslist;

	private Dictionary<uint, int> m_ModularDict;

	private int m_HistoryIndex;

	private int m_HistoryTable2Index;

	private int m_SubscriptionIndex;

	private int m_SubscriptionTable2Index;

	private int m_NewPlayerIndex;

	private bool m_NeedReposition;

	private bool m_WorkShopFeedBack;

	private bool m_ResourceShopFeedBack;

	private bool m_IsPreferencePopupOpen;

	private bool m_PreferenceShownThisSession;

	private Vector2 m_MapSlotSize;

	private Dictionary<int, UIUGCRecommendationItemV2Data> m_ViewDataDict;

	private Dictionary<uint, HashSet<string>> m_ViewDataExposureDict;

	private List<int> m_ViewDataIndices;

	private UITable2VirtualBoundsHelper m_Table2VirtualBoundsHelper;

	private bool m_SwipeTriggered;

	private Coroutine m_CheckExposureCoroutine;

	private int m_NeedMoveToSeriesID;

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

	private void InitRecommendSeries()
	{
	}

	private void RequestData()
	{
	}

	private void InitTable2Templates()
	{
	}

	private void InitVirtualBoundsHelper()
	{
	}

	private void RefreshTable2Data(bool keepScrollPosition = false)
	{
	}

	private void RefreshTable2ItemData(int index)
	{
	}

	private IEnumerator Reposition()
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

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void BindScrollView()
	{
	}

	private float GetScrollViewBottomDelta(UIScrollView scrollView)
	{
		return 0f;
	}

	private void ResetScrollViewMotion()
	{
	}

	private void ShowPlayPreference()
	{
	}

	private void CheckOpenCreatorFeedbackWnd()
	{
	}

	public void TryOpenCreatorFeedbackWnd()
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

	public void ScrollToSeriesID(int seriesID)
	{
	}

	private void DoScrollToSeriesID()
	{
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

	private UITable2.IUITable2Item _003CInitTable2Templates_003Eb__30_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Templates_003Eb__30_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Templates_003Eb__30_2()
	{
		return null;
	}

	private void _003CBindScrollView_003Eb__41_0()
	{
	}

	private void _003CBindScrollView_003Eb__41_1()
	{
	}

	private void _003CBindScrollView_003Eb__41_2()
	{
	}

	private bool _003CDoScrollToSeriesID_003Eb__52_0(WorkshopRecommendSeriesDesc e)
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
