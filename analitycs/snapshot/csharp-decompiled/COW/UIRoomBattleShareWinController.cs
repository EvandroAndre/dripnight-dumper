using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIRoomBattleShareWinController : UIBaseController, IUIModelDataChangeObserver
{
	private const int SmallTeamThreshold = 4;

	private const int ScoreDiffThreshold = 2;

	private const string FriendBigDiffTitleKey = "T_54_D_SHAREWIN_TEXT1";

	private const string NoFriendBigDiffTitleKey = "T_54_D_SHAREWIN_TEXT2";

	private const string FriendSmallDiffTitleKey = "T_54_D_SHAREWIN_TEXT3";

	private const string NoFriendSmallDiffTitleKey = "T_54_D_SHAREWIN_TEXT4";

	private const string FriendRecordLabelKey = "T_54_D_SHAREWIN_TEXT5";

	private const int ChangeFriendContainerExtraHeight = 30;

	private const int ChangeLabelTableGap = 0;

	private const float ResultIconDesignWidth = 3000f;

	private const float ResultIconDesignHeight = 1500f;

	private UIRoomBattleShareWinView m_View;

	private readonly List<GameObject> m_LeftTeamItems;

	private readonly List<GameObject> m_RightTeamItems;

	private readonly List<UIRoomBattleShareWinFriendItemView> m_FriendItemViews;

	private UIModelCustomRoom m_ModelCustomRoom;

	private MatchStats m_MatchStats;

	private MatchStats m_RenderedTeamMatchStats;

	private List<TeammateStats> m_SortedOpponentFriends;

	private TeammateStats m_SelectedFriendStats;

	private Action m_OnFriendItemSelected;

	private bool m_HasInitTeamItems;

	private bool m_HasInitFriendItems;

	private int m_SharePreviewWidth;

	private int m_SharePreviewHeight;

	private const string FriendNamePlaceholder = "\ue000\ue001\ue002";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetMatchStats(MatchStats matchStats)
	{
	}

	public void SetFriendItemSelectedCallback(Action callback)
	{
	}

	public void SetSharePreviewSize(int width, int height)
	{
	}

	private void InitStaticNodes()
	{
	}

	public void UpdateMaskDepth(int depth)
	{
	}

	private void RefreshTeamView()
	{
	}

	private void RefreshSingleTeam(List<UIRoomBattleShareWinPlayerData> validMembers, bool isLeftTeam, int backgroundPlayerCount)
	{
	}

	private List<UIRoomBattleShareWinPlayerData> BuildValidTeamPlayerDataList(List<TeammateStats> players, bool isLeftTeam)
	{
		return null;
	}

	private GameObject CreatePlayerItem(Transform parent, bool useSmallItem, bool isLeftTeam, UIRoomBattleShareWinPlayerData playerInfo)
	{
		return null;
	}

	private void RefreshFriendBattleRecordView()
	{
	}

	private bool ShouldShowFriendBattleRecord(List<TeammateStats> sortedOpponentFriends)
	{
		return false;
	}

	private bool IsNormalMatchResultShare()
	{
		return false;
	}

	private bool IsScoreDiffGreaterOrEqualTwo()
	{
		return false;
	}

	private void RefreshResultIcon()
	{
	}

	private void RefreshResultIconLayout()
	{
	}

	private void RefreshResultIconMask(int maskWidth, int maskHeight)
	{
	}

	public List<TeammateStats> GetSortedOpponentFriendStatsList()
	{
		return null;
	}

	private bool IsOpponentFriend(TeammateStats opponent)
	{
		return false;
	}

	private void RefreshTitleLabel(bool needShowFriendRecord, TeammateStats friendStats)
	{
	}

	private static string ToUpperText(string text)
	{
		return null;
	}

	private string GetLocalPlayerName()
	{
		return null;
	}

	private string GetGameModeName()
	{
		return null;
	}

	private string GetTitleLocKey(bool needShowFriendRecord)
	{
		return null;
	}

	private void RequestPlayerRoomStatsOnce()
	{
	}

	private ulong GetCurrentMatchId()
	{
		return 0uL;
	}

	private void RefreshFriendBattleRecordAfterStatsLoaded()
	{
	}

	public void BeforeShareScreenshot()
	{
	}

	public void AfterShareScreenshot()
	{
	}

	private bool ShouldShowChangeFriendBtnAfterStatsLoaded()
	{
		return false;
	}

	private void RefreshFriendLabel()
	{
	}

	private uint GetFriendWinCount(ulong friendId)
	{
		return 0u;
	}

	private void HideFriendBattleRecordNodes()
	{
	}

	private void EnsureSelectedFriendStats()
	{
	}

	private void OnClickChangeFriendBtn()
	{
	}

	private void InitFriendItems()
	{
	}

	private void RefreshChangeFriendContainerLayout()
	{
	}

	private float GetWidgetLocalHeight(UIWidget widget)
	{
		return 0f;
	}

	private float GetWidgetLocalMinY(UIWidget widget)
	{
		return 0f;
	}

	private void OnFriendItemSelected(TeammateStats friendStats)
	{
	}

	private void OnSelectedFriendDisChoose()
	{
	}

	private void RefreshFriendItemSelectState()
	{
	}

	private bool IsSelectedFriend(TeammateStats friendStats)
	{
		return false;
	}

	private List<UIRoomBattleShareWinPlayerData> BuildPlayerDataList(List<TeammateStats> players)
	{
		return null;
	}

	private List<UIRoomBattleShareWinPlayerData> BuildCurrentMatchPlayerDataList(bool isLeftTeam)
	{
		return null;
	}

	private void AddCurrentMatchPlayerData(List<UIRoomBattleShareWinPlayerData> members, UIModelMatch modelMatch, List<BHGGAEEHJCO> playerIds)
	{
	}

	private void AddCurrentMatchPlayerData(List<UIRoomBattleShareWinPlayerData> members, UIModelMatch modelMatch, BHGGAEEHJCO playerId)
	{
	}

	private byte GetLocalTeamId(UIModelMatch modelMatch)
	{
		return 0;
	}

	private Transform GetTeamItemParent(bool isLeftTeam, bool useSmallItem)
	{
		return null;
	}

	private UIGrid GetSmallTeamGrid(bool isLeftTeam)
	{
		return null;
	}

	private UITable GetBigTeamTable(bool isLeftTeam)
	{
		return null;
	}

	private UIRoomBattleShareWinBigItemView GetBigPlayerTemplate(bool isLeftTeam)
	{
		return null;
	}

	private void SetTeamContainerActive(bool isLeftTeam, bool useSmallItem, bool active)
	{
	}

	private void HideTeamContainers()
	{
	}

	private void RepositionTeamContainer(bool isLeftTeam, bool useSmallItem)
	{
	}

	private void RefreshTeamBackground(bool isLeftTeam, int playerCount)
	{
	}

	private int GetTeamBackgroundType(int playerCount)
	{
		return 0;
	}

	private GameObject GetTeamBackground(bool isLeftTeam, int backgroundType)
	{
		return null;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void SetNodeActive(GameObject node, bool active)
	{
	}

	private void SetComponentNodeActive(Component component, bool active)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
