using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UIChatNewRecruitContainerController : UIChatBaseContainerController, IUIModelDataChangeObserver, IEasyList
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<uint, string> _003C_003E9__136_0;

		internal string _003COnTeamTagSelected_003Eb__136_0(uint id)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass95_0
	{
		public UIChatNewRecruitContainerController _003C_003E4__this;

		public List<object> list;

		internal bool _003CRefreshMessageList_003Eb__1(object teamInfo)
		{
			return false;
		}

		internal bool _003CRefreshMessageList_003Eb__2(object roomInfo)
		{
			return false;
		}

		internal void _003CRefreshMessageList_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass96_0
	{
		public UIChatNewRecruitContainerController _003C_003E4__this;

		public List<RecruitRoomInfo> list;

		internal bool _003CRefreshRoomMessageList_003Eb__1(RecruitRoomInfo roomInfo)
		{
			return false;
		}

		internal void _003CRefreshRoomMessageList_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass97_0
	{
		public UIGroupRecruitTagItemController tagItem;

		internal bool _003CSetTeamTagView_003Eb__0(uint id)
		{
			return false;
		}
	}

	private UIChatNewRecruitContainerView m_View;

	private UIModelGroup m_ModelGroup;

	private UIModelRecruit m_ModelRecruit;

	private UIModelChat m_ModelChat;

	private UIModelMapOpeningInfo m_ModelMap;

	private UIModelLadderMatch m_ModelLadderMatch;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournamentLadderMatch;

	private UIModelCustomRoom m_ModelCustomRoom;

	private UIModelProfile m_ModelProfile;

	private float GREY_ALPHA;

	private uint m_ArrowOffsetX;

	private bool m_DisableItemAnim;

	private ulong m_NeedScrollGroupId;

	private int m_NeedScrollIndex;

	private ulong m_NeedScrollRoomId;

	private uint m_FilterFullTeamDelayCall;

	private uint m_FilterFullRoomDelayCall;

	private uint m_ProtectRequestCD;

	private float m_ManualRefreshCD;

	private bool m_IsInManualRefreshCD;

	private float m_AutoRefreshCD;

	private bool m_IsInAutoRefreshCD;

	private List<GroupRecruitTeamInfo> m_ShowGroupRecruitTeamInfoList;

	private List<GroupRecruitTeamInfo> m_FilterFullTeamRecruitTeamInfoList;

	private List<ulong> m_RefreshGroupIds;

	private List<RecruitRoomInfo> m_ShowRoomRecruitTeamInfoList;

	private List<RecruitRoomInfo> m_FilterFullRoomRecruitTeamInfoList;

	private List<ulong> m_RefreshRoomIds;

	private uint m_MapModeId;

	private List<int> m_CSRankListForGroupRecruit;

	private List<int> m_BRRankListForGroupRecruit;

	private List<int> m_PeakScoreRangeList;

	private List<PopMenuData> m_ModeMenuData;

	private List<PopMenuData> m_GroupMenuData;

	private List<PopMenuData> m_BRMinRankMenuData;

	private List<PopMenuData> m_CSMinRankMenuData;

	private List<PopMenuData> m_PeakScoreMenuData;

	private UIRecruitPopMenuController m_GameModePopMenuCtrl;

	private UIRecruitPopMenuController m_GroupModePopMenuCtrl;

	private UIRecruitPopMenuController m_MinRankPopMenuCtrl;

	private float m_LabelAllModePosX;

	private List<UIGroupRecruitTagItemController> m_TagItems;

	private List<uint> m_TeamTags;

	private bool m_HasChangeTag;

	private bool m_HasReqManualRefresh;

	private bool m_HasShownUpdateTeamTips;

	private bool m_FirstOpen;

	private RecruitRoomInfo m_CurrentQuickJoinRoomInfo;

	private bool m_IsAllMode;

	private bool m_IsCustomRoomMode;

	private bool m_HasAdjustPanel;

	private bool m_CanChangeMapBonus;

	private bool m_isSelectCSSpecialMatch;

	private uint m_SpecialModeEventId;

	private int m_SelectMinRank;

	private string m_SelectMinRankName;

	private string m_SelectMinRankSpriteName;

	private int m_DefaultSelectMinRank;

	private RecruitRoomInfo m_CurrentJoinProcessRoomInfo;

	private string m_DefaultGameModeKey;

	private string m_DefaultGroupModeKey;

	private string m_CustomRoomModeKey;

	private uint m_BRRank;

	private uint m_CSRank;

	private uint m_CSPeakRank;

	private int m_PeakScoreRankIndex;

	protected override void OnUIInit()
	{
	}

	private bool AutoSelectPeakScoreRange()
	{
		return false;
	}

	private uint GetPlayerCSPeakMinRecuritScore()
	{
		return 0u;
	}

	protected override void OnUIDestory()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void AdaptScrollViewPos()
	{
	}

	private void RequestGetRecruitList(EGroup.RecruitListType recruitListType, List<ulong> groupIds)
	{
	}

	private void RequestGetRoomRecruitList(ERoom.RecruitListType recruitListType, List<ulong> roomIds, bool isAllMode)
	{
	}

	private void RequestGetGroupAndRoomRecruitList(EGroup.RecruitListType groupRecruitListType, ERoom.RecruitListType roomRecruitListType, List<ulong> groupIds, List<ulong> roomIds, bool isAllMode)
	{
	}

	private void Update()
	{
	}

	private void InitMinRankPopUpData()
	{
	}

	private void UpdateMinRankPopUpData()
	{
	}

	private void BuildPeakScoreMenuData()
	{
	}

	private void OnPeakScoreSelect(object scoreData)
	{
	}

	private void ConstructLadderPopData()
	{
	}

	private void SelectRankMinCallBack(object obj)
	{
	}

	private void ShowManualRefreshCD(bool show)
	{
	}

	private void SetBtnStateInCD(bool isInCD)
	{
	}

	private void OnCSSpecialToggleChange()
	{
	}

	private void OnMapBonusToggleChange()
	{
	}

	private void SetExtraView()
	{
	}

	public override GameObject GetContentNode()
	{
		return null;
	}

	public override GameObject GetEmptyNode()
	{
		return null;
	}

	public override UIScrollView GetMessageList()
	{
		return null;
	}

	public override UITable2 GetMessageListTable2()
	{
		return null;
	}

	public override void InitWidget(Transform parent)
	{
	}

	public override void RefreshContentNode()
	{
	}

	private List<object> GetMessageInfoList()
	{
		return null;
	}

	private void RefreshMessageList(bool resetPosition = true, bool needScrollTo = false)
	{
	}

	private void RefreshRoomMessageList(bool resetPosition = true, bool needScrollTo = false)
	{
	}

	private void SetTeamTagView()
	{
	}

	private bool IsTagCanChoose(uint tag)
	{
		return false;
	}

	private void ReinitSelecetedTag()
	{
	}

	private void SetResetBtnView()
	{
	}

	private void SetQuickJoinBtnView()
	{
	}

	private void InitRecruitScreen()
	{
	}

	private void SetPopMenusView()
	{
	}

	private void OnRecruitClick()
	{
	}

	private void OnModeBtnClick()
	{
	}

	private void AddRoomRecruitToMenu()
	{
	}

	private void InitTeamTags()
	{
	}

	private void InitRankData()
	{
	}

	private void InitGameMode(object modeData)
	{
	}

	private void InitCustomRoomMode()
	{
	}

	private void UpdateGameMode(object modeData)
	{
	}

	private void UpdateCustomRoomMode(object modeData)
	{
	}

	private void RefreshFilter()
	{
	}

	private void ExitCustomRoomMode()
	{
	}

	private void SetSelectGameMode(uint gameMode, uint matchMode)
	{
	}

	private void ConstructGroupMenuList()
	{
	}

	private void UpdateGroupMode(object groupData)
	{
	}

	private bool CanManualRefreshRecruitList()
	{
		return false;
	}

	private bool CanRequestManualRecruitList()
	{
		return false;
	}

	private bool CanAutoRefreshRecruitList()
	{
		return false;
	}

	private void OnGroupBtnClick()
	{
	}

	private void OnResetBtnClick()
	{
	}

	private void OnCloseMaskBtnClick()
	{
	}

	private void OnRefreshBtnClick()
	{
	}

	private void OnFilterBtnClick()
	{
	}

	private void InitGroupModePopMenu()
	{
	}

	private void InitMinRankPopMenu()
	{
	}

	private void SetMinRankSpriteData(int rank)
	{
	}

	private void OnGetRecruitList(object[] data)
	{
	}

	private void ShowUpdateTeamTipsWithFlag()
	{
	}

	private void ResetUpdateTeamTipsFlag()
	{
	}

	private void OnGetRoomRecruitList(object[] data)
	{
	}

	private void ProcessShowRoomRecruitList()
	{
	}

	private void OnPopUpMaskClick()
	{
	}

	private void OnGroupOrMinRankPopUpMaskClick()
	{
	}

	private void OnTeamTagSelected(object[] data)
	{
	}

	private void ProcessShowRecruitListByTag()
	{
	}

	private void OnQuickJoinBtnClick()
	{
	}

	private void OnGroupQuickJoinClick()
	{
	}

	private void OnRoomQuickJoinClick()
	{
	}

	private void FastJoinRoom(RecruitRoomInfo recruitRoomInfo)
	{
	}

	private void JoinProcess(RecruitRoomInfo recruitRoomInfo, bool solo = true)
	{
	}

	private void OnRoomQuickJoinClickConfirmSuccess()
	{
	}

	private void RecordJoinFailRoom(object[] param)
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
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

	private void _003CJoinProcess_003Eb__142_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_InitWidget(Transform P0)
	{
	}
}
