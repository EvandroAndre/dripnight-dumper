using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UILadderLeaderBoardItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	public enum EBriefBoxDetail_LeaderBoard
	{
		None,
		BR,
		CS,
		Periodic,
		CsPeak
	}

	private UIModelWeaponPower m_ModelWeaponPower;

	private UIModelAreaLeaderBoard m_ModelAreaLeaderBoard;

	private UIModelLeaderBoardTitle m_ModelLeaderBoardTitle;

	private UIModelLeaderBoard m_ModelLeaderBoard;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournamentLadderMatch;

	private UILadderLeaderBoardItemView m_View;

	private LadderType m_LadderType;

	private string m_RankLeaderBoardFilter;

	private uint m_SelectedWeaponID;

	private uint m_LimitedTimeRankGameMode;

	private LeaderBoardInfo m_Info;

	private bool m_IsSelf;

	private bool m_SelfShowInLeaderboard;

	private bool m_IsTitleShow;

	private bool m_LeaderBoardCheckPass;

	private UIBaseProfileInfoController m_BaseProfileUIRank;

	private UIBaseProfileInfoController m_BaseProfileUIWeapon;

	private UILeaderBoardTitleCommonController m_LeaderBoardTitleCommonCtrlRank;

	private UILeaderBoardTitleCommonController m_LeaderBoardTitleCommonCtrlWeapon;

	private UIWidget m_ProfileWidget;

	private uint m_MaxSize;

	private ulong m_AccountID;

	private uint m_Rank;

	private ulong m_LeaderBoardID;

	private int m_LeaderBoardType;

	private bool m_IsShowClosedUI;

	private const float MATCH_BASEPROFILE_REGION_POSX = -84f;

	private const float MATCH_BASEPROFILE_FRIEND_POSX = -135f;

	private ELeaderBoardTitleRegionType m_RegionType;

	private Dictionary<uint, GameObject> m_RankCupIcon;

	private Dictionary<uint, string> m_RankBG;

	private Dictionary<uint, string> m_RankBG_CSPeak;

	private bool m_IsCsPeakRecord;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnClick2()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	private void SetupDefaultStateOnInit()
	{
	}

	private void SetItemData(LeaderBoardInfo info)
	{
	}

	private void SetRankUI()
	{
	}

	private int GetEasylistMaxCount()
	{
		return 0;
	}

	private void SetLimitedTimeRankFilterUI()
	{
	}

	private void SetCsPeakRecordUI()
	{
	}

	private void SetFriendRankFilterUI(bool isCsPeakRecord = false)
	{
	}

	private void SetNormalFriendRankUI()
	{
	}

	private void SetWeaponRankUI()
	{
	}

	private void SetNextTargetButtonView()
	{
	}

	private void SetWeaponPowerValue()
	{
	}

	private void SetMatchUI(DLBMPCCFKKM matchMode)
	{
	}

	private void SetLimitedTimeRankUI()
	{
	}

	private void SetWeaponUI()
	{
	}

	private void SetPersonBaseProfile(Transform attachPoint, bool isHide = false)
	{
	}

	private void ChangeBaseProfileTransform(float posX)
	{
	}

	private void SetLadderRankValue(DLBMPCCFKKM ladderMatchType)
	{
	}

	private bool isCurItemWeaponPower()
	{
		return false;
	}

	private void OpenNextTartgetPopup(ulong leaderboardID)
	{
	}

	private EventLogger.BriefBoxClickData GetBriefBoxClickData(ulong accountId)
	{
		return null;
	}

	private uint GetLimitedRankScore()
	{
		return 0u;
	}

	private bool CheckLeaderBoardCdt(UILabel label)
	{
		return false;
	}

	public void SetShowClosed(bool show)
	{
	}

	public void SetLadderType(LadderType ladderType)
	{
	}

	public void SetRankLeaderBoardFilter(string filterType)
	{
	}

	public void SetLimitedTimeRankGameMode(string gameMode)
	{
	}

	public void SetWeaponID(uint selectedWeaponID)
	{
	}

	public void SetRegionType(ELeaderBoardTitleRegionType regionType)
	{
	}

	public void SetLeaderBoardID(ulong leaderBoardID)
	{
	}

	public void SetLeaderBoardType(int leaderBoardType)
	{
	}

	public void SetRankFormat(uint maxSize)
	{
	}

	public void HideBG()
	{
	}

	public void SetIsSelf(bool isSelf)
	{
	}

	private void OnClickNextTarget()
	{
	}

	private void OnClickGotoMode()
	{
	}

	private void OnSeasonRefreshWeaponPowerValueBtnClick()
	{
	}

	private void OnScrollToSelfBtnClick()
	{
	}

	public void SetSelfLocationBtnShow()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick2()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
