using System.Collections.Generic;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UINewBriefProfileInfoController : UIBaseController, IUIModelDataChangeObserver
{
	private uint DisconnectDelayCallId;

	private bool m_IsDisconnected;

	private UINewBriefProfileInfoView m_View;

	private bool m_isSelf;

	private string m_NickName;

	private ulong m_AccountID;

	private bool m_IsMute;

	private int m_MemberIndex;

	private uint m_RankLimitVFXDelayCall;

	private GroupMemberInfo m_MemInfo;

	private UINewGroupMemberVoiceInfoController m_Voice;

	private UIBRRankIconController m_BRRankIconController;

	private UICSRankIconController m_CSRankIconController;

	private UIHippoCrisisRankIconController m_HCRankIconController;

	private UILimitedTimeRankIconController m_LimitedTimeRankIconController;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private float m_ladderIconSize;

	private UIModelGroup m_ModelGroup;

	private UICSPeakTournamentRankIconController m_CSPeakTournamentController;

	private UIBaseGroupMemberInfoController.InviteClickCallBack m_CallBack;

	private List<GameObject> m_AutoScrollGameObjects;

	private bool m_HasFetchedInGamePresence;

	private uint m_CachedGameMode;

	private uint m_CachedMatchMode;

	private uint m_CachedMapID;

	private uint m_DelayHideNoMicStatusId;

	private float m_DelayHideNoMicStatusTime;

	private const int PRIVILEGE_ICON_WIDTH = 23;

	public bool IsMute
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

	public void SetIsHippo(bool isShowHippoLobby)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private bool OnEscapeClick()
	{
		return false;
	}

	public void StreakScroll(uint streakScrollIndex)
	{
	}

	public void SetMemberIndex(int memberIndex)
	{
	}

	public void SetUIData(GroupMemberInfo info, bool leader)
	{
	}

	public void RefreshInGameTeammateStat()
	{
	}

	public void SetReadyState(bool ready, bool leader, bool isNeedShowNoInLobbyTip = false)
	{
	}

	public void RefreshReadyState()
	{
	}

	public void RefreshTeammateState()
	{
	}

	public void SetVoiceVisible(bool flag)
	{
	}

	public void SetMuteVisible(bool flag)
	{
	}

	private void OnMicBtnClick()
	{
	}

	private void OnSpeackerBtnClick()
	{
	}

	public void ShowHideMicPressedVFX(bool show)
	{
	}

	private void RefreshMicBtnPresssedState()
	{
	}

	public void RefreshGameVoiceBtnView()
	{
	}

	private void RefreshDisconnectedView()
	{
	}

	private void OnDisconnectClick()
	{
	}

	private void RefreshDisconnectState(object[] data)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void RefreshMicBanView()
	{
	}

	private void OnMicrophoneChanged(object[] data)
	{
	}

	private void OnMicrophoneListenModeChange(int mode)
	{
	}

	private void OnSpeakerListnModeChange(int mode)
	{
	}

	private void OnJoinedGameVoiceRoom(object[] data)
	{
	}

	private void OnLeavedGameVoiceRoom(object[] data)
	{
	}

	public void SetFriendState(bool friend, UIBaseGroupMemberInfoController.InviteClickCallBack cb = null)
	{
	}

	private void OnBtnCloseClick()
	{
	}

	private void OnInviteBtnClick()
	{
	}

	private void OnHighlightRankLimited()
	{
	}

	private void ScrollFinish()
	{
	}

	public void ResetScroll()
	{
	}

	public void EnableInivte(bool enable)
	{
	}

	private void ResetLadderScroll()
	{
	}

	public void RefreshLadderIcon()
	{
	}

	public void RefreshWinStreakIcon()
	{
	}

	public void RefreshCSPeakIcon()
	{
	}

	public void HandleSingleLadderIcon()
	{
	}

	public void SetNeedScrollGameObjects()
	{
	}

	public bool NeedScroll()
	{
		return false;
	}

	public uint GetScrollCount()
	{
		return 0u;
	}

	private void OnRoomHangup(object[] data)
	{
	}

	private void OnRoomHangupEnd(object[] data)
	{
	}

	private void UpdateNickNameAndAlias()
	{
	}

	private void OnGoToCreditBtnClick()
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	public void OnInTakePhotoState(object[] objects)
	{
	}

	public void OnOutTakePhotoState(object[] objects)
	{
	}

	private void RequestMemberPresenceForInGameState()
	{
	}

	private void OnMixedGroupMemberPresenceNtf(object[] args)
	{
	}

	private void RefreshBRAntiAddictionIcon()
	{
	}

	private void _003COnUIInit_003Eb__32_0()
	{
	}

	private void _003COnUIInit_003Eb__32_1()
	{
	}

	private void _003COnUIInit_003Eb__32_2()
	{
	}

	private void _003CSetUIData_003Eb__38_0()
	{
	}

	private bool _003CRefreshInGameTeammateStat_003Eb__39_0(FriendAccountInfo x)
	{
		return false;
	}

	private void _003COnMicBtnClick_003Eb__45_0()
	{
	}

	private void _003COnHighlightRankLimited_003Eb__63_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
