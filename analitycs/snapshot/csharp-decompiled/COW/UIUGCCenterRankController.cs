using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIUGCCenterRankController : UIBaseController, IUIModelDataChangeObserver
{
	public enum TemplateType
	{
		RankItem,
		RankPlaceholder
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<WorkshopLeaderboardConfigDesc> _003C_003E9__16_0;

		internal int _003CInitRankData_003Eb__16_0(WorkshopLeaderboardConfigDesc a, WorkshopLeaderboardConfigDesc b)
		{
			return 0;
		}
	}

	public Action OnSwipeToNext;

	private UIUGCCenterRankView m_View;

	private UIModelSceneEdit m_Model;

	private List<WaterfallPoolData> m_PoolDataList;

	private bool[] m_PoolLoaded;

	private bool m_SwipeTriggered;

	private Dictionary<int, int> m_ConfigIdToItemIndex;

	private const int RequestCountPerRank = 8;

	private const int CheckCountPerRank = 4;

	private const int RankItemWidth = 1190;

	private const int RankItemHeight = 252;

	private const int RankPlaceholderFullHeight = 610;

	private int m_NeedScrollToConfigId;

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

	private void InitRankData()
	{
	}

	private bool IsAllPoolsLoaded()
	{
		return false;
	}

	private void ShowEmptyPlaceholder()
	{
	}

	private void InitTable2Templates()
	{
	}

	private void RefreshRankTable2()
	{
	}

	private void AddRankPlaceholder(int rankItemCount)
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

	public void ScrollToItemById(int configId)
	{
	}

	private void DoScrollToItemById()
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

	private UITable2.IUITable2Item _003CInitTable2Templates_003Eb__19_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTable2Templates_003Eb__19_1()
	{
		return null;
	}

	private void _003CBindScrollView_003Eb__24_0()
	{
	}

	private void _003CBindScrollView_003Eb__24_1()
	{
	}

	private void _003CBindScrollView_003Eb__24_2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
