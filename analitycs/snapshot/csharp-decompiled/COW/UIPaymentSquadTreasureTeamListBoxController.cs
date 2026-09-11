using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIPaymentSquadTreasureTeamListBoxController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<TopUpTeamInvitation> _003C_003E9__57_0;

		public static Action _003C_003E9__60_0;

		internal int _003CRefreshFriendList_003Eb__57_0(TopUpTeamInvitation a, TopUpTeamInvitation b)
		{
			return 0;
		}

		internal void _003CTryShowQuickJoinGuide_003Eb__60_0()
		{
		}
	}

	private UIPaymentSquadTreasureTeamListBoxView m_View;

	private ESquadTreasureTeamListType m_TeamListType;

	private UIModelSquadTreasure m_ModelSquadTreasure;

	private UIModelQRCode m_ModelQRCode;

	private UIPaymentSuqadTreasureCodeInputWindowController m_CodeInputWindow;

	private List<UIPaymentSquadTreasureInviteItemController> m_InviteItemList;

	private ulong m_LastRefreshTime;

	private const int QUICK_JOIN_GUIDE_DEPTH = 30;

	private const ulong QUICK_JOIN_CD = 10uL;

	private uint m_CurrentHistoryPageIndex;

	private const float HISTORY_BOTTOM_HEIGHT = 50f;

	private bool m_IsHistoryScrollViewAdjusted;

	private Vector3 m_OriginalHistoryLocalPosition;

	private bool m_IsShowingThreeTabs;

	private const float THREE_TABS_GRID_CELL_WIDTH = 190f;

	private const float THREE_TABS_GRID_CELL_HEIGHT = 50f;

	private const int THREE_TABS_WIDGET_WIDTH = 185;

	private const int THREE_TABS_WIDGET_HEIGHT = 42;

	private const int THREE_TABS_BG_WIDTH = 188;

	private const int THREE_TABS_BG_HEIGHT = 42;

	private const float THREE_TABS_GRID_POS_X = -165f;

	private const float THREE_TABS_GRID_POS_Y = -26f;

	private const float TWO_TABS_GRID_CELL_WIDTH = 288f;

	private const float TWO_TABS_GRID_CELL_HEIGHT = 50f;

	private const int TWO_TABS_WIDGET_WIDTH = 280;

	private const int TWO_TABS_WIDGET_HEIGHT = 42;

	private const int TWO_TABS_BG_WIDTH = 282;

	private const int TWO_TABS_BG_HEIGHT = 42;

	private const float TWO_TABS_GRID_POS_X = -117f;

	private const float TWO_TABS_GRID_POS_Y = -26f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public override void Show()
	{
	}

	public void SetViewData(ESquadTreasureTeamListType teamListType)
	{
	}

	private void InitEvent()
	{
	}

	private void InitTemplate()
	{
	}

	private void OnBtnMaskClick()
	{
	}

	private void OnBtnTeamTabClick()
	{
	}

	private void OnBtnInviteTabClick()
	{
	}

	private void OnBtnHistoryTabClick()
	{
	}

	private void OnBtnShowMoreClick()
	{
	}

	private void OnHistoryScrollViewMomentumMove()
	{
	}

	private void OnBtnRefreshClick()
	{
	}

	private void OnBntQRCodeClick()
	{
	}

	private void OnBtnTeamCodeClick()
	{
	}

	private void OnGroupCodeEnter(object data)
	{
	}

	private void OnBtnQuickJoinClick()
	{
	}

	private void UpdateQuickJoinState()
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshList()
	{
	}

	private void RefreshTeamList()
	{
	}

	private List<RecommendTopUpTeam> MergeAndDeduplicateTeamListsWithPriority(List<RecommendTopUpTeam> friendList, List<RecommendTopUpTeam> clanList)
	{
		return null;
	}

	private void SortTeamListByProgressAndId(List<RecommendTopUpTeam> list)
	{
	}

	private void RefreshFriendList()
	{
	}

	private void UpdateRefreshState(bool inCD = false)
	{
	}

	private void RefreshCountDownState()
	{
	}

	private void TryShowQuickJoinGuide()
	{
	}

	private void SetWidgetSize(UIWidget widget, int width, int height)
	{
	}

	private void RefreshTabLayout()
	{
	}

	private void TryShowHistoryListFromCache()
	{
	}

	private void RefreshHistoryList(bool newPage)
	{
	}

	private void RequestHistoryTeamsByIndex(uint pageIndex)
	{
	}

	private void UpdateShowMoreButton()
	{
	}

	private void RefreshHistoryScrollViewForBottom()
	{
	}

	private bool IsHistoryScrollViewAtBottom()
	{
		return false;
	}

	private UITable2.IUITable2Item _003CInitTemplate_003Eb__39_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTemplate_003Eb__39_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTemplate_003Eb__39_2()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitTemplate_003Eb__39_3()
	{
		return null;
	}

	private void _003COnBtnRefreshClick_003Eb__46_0()
	{
	}

	private void _003CUpdateQuickJoinState_003Eb__51_0()
	{
	}

	private int _003CSortTeamListByProgressAndId_003Eb__56_0(RecommendTopUpTeam a, RecommendTopUpTeam b)
	{
		return 0;
	}

	private void _003CRefreshCountDownState_003Eb__59_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}
}
