using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UILadderMatchLeaderboardController : UIBaseController, IUIModelDataChangeObserver, IEasyList
{
	private LadderMatchLeaderboardView m_View;

	private UIModelLeaderBoard m_ModelBoard;

	private UIModelCSLadderMatch m_ModelLadderCS;

	private UIModelPeriodicLadderMatch m_ModelLadderPeriodic;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournament;

	private uint m_BRFriendBoardType;

	private uint m_BRRegionBoardType;

	private int m_SeasonID;

	private bool NeedResetListPos;

	private bool m_IsShrink;

	private DLBMPCCFKKM m_LadderMatchType;

	private bool m_IsRegion;

	private ERankIconDisplayTypes m_CurRankIconDisplayType;

	private UILadderMatchLeaderboardItemController m_selfLeaderItem;

	private Vector4 m_BaseClipRegion;

	private Vector3 m_MainWidgetOriginalPosition;

	private Vector3 m_MainWidgetShrinkPosition;

	private bool m_FriendLeaderboardDataChange;

	private bool m_RegionLeaderboardDataChange;

	private LeaderBoardIDV2 m_HCRegionBoardIDV2;

	private LeaderBoardIDV2 m_HCFriendBoardIDV2;

	public DLBMPCCFKKM LadderMatchType => DLBMPCCFKKM.EMATCHMODE_NONE;

	public bool IsShrink
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(DLBMPCCFKKM ladderMatchType)
	{
	}

	private void OnFriendTabClick()
	{
	}

	private void RefreshToggleBtnStateFriendsAndAll(bool isFriend)
	{
	}

	private void OnGlobalTabClick()
	{
	}

	private void RefreshFriendLeaderboardList()
	{
	}

	private void RefreshRegionLeaderboardList()
	{
	}

	public void InitTweenBoard()
	{
	}

	public void OnBtnHideClick()
	{
	}

	public void OnBtnCloseClick()
	{
	}

	private void RefreshCurrentLeaderboardTabList()
	{
	}

	private void RefreshSelfRank(List<LeaderBoardInfo> _list, bool showClosedUI = false, bool isFriend = false)
	{
	}

	private void RefreshSelfCSRank(bool isFriend = false, bool showClosedUI = false)
	{
	}

	private void RefreshSelfCSPeakRank(bool isFriend = false, bool showClosedUI = false)
	{
	}

	private void RefreshSelfPeriodicRank(bool isFriend = false)
	{
	}

	private void RefreshSelfHCRank(List<LeaderBoardInfo> _list, bool showClosedUI = false, bool isFriend = false)
	{
	}

	private void RefreshItemList(List<LeaderBoardInfo> _list, bool isFriend = false)
	{
	}

	public bool GetIsRegionClick()
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

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void _003CInitTweenBoard_003Eb__34_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
