using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UILobbyV2GroupInviteItemController : UIEasyListItemController, IUIModelDataChangeObserver
{
	public enum EFriendStatusType
	{
		None,
		CanInvite,
		CanJoinGroup,
		CanInviteAndJoin
	}

	public enum GroupInviteUI
	{
		Group,
		Room,
		InGameUGC
	}

	private sealed class _003C_003Ec__DisplayClass69_0
	{
		public UIModelCustomRoom modelRoom;

		public ulong roomId;

		public uint roomType;

		public UILobbyV2GroupInviteItemController _003C_003E4__this;

		internal void _003CClickJoinInGroup_003Eb__4()
		{
		}

		internal void _003CClickJoinInGroup_003Eb__6()
		{
		}
	}

	private sealed class _003CShowCommonFriendAndSocialLight_003Ed__98 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILobbyV2GroupInviteItemController _003C_003E4__this;

		private TeamUpRecommendAccountInfo _003Cinfo_003E5__2;

		private bool _003CisBr_003E5__3;

		private proto.RankingStatsSummary _003Cstats_003E5__4;

		private TeamUpRecommendConfigDesc _003Cconfig_003E5__5;

		private UITeamUpRecommendReasonItemController _003Cctrl_003E5__6;

		private bool _003ChasAddLeaderBoardTitle_003E5__7;

		private List<proto.SocialHighLight>.Enumerator _003C_003E7__wrap7;

		private UILeaderBoardTitleIconController _003CweaponTitleCtrl_003E5__9;

		private UISocialHighlightIconController _003ChighLightCtrl_003E5__10;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CShowCommonFriendAndSocialLight_003Ed__98(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UILobbyV2GroupInviteItemView m_View;

	public GroupInviteMemberType InviteType;

	private EFriendStatusType m_FriendStatusType;

	public int ItemIdex;

	private object m_Data;

	private GroupInviteUI m_InviteUI;

	private ClanMember clanMemberInfo;

	private FriendAccountInfo friendInfo;

	private TeamMemberWithAccountInfo teamMemberInfo;

	private UIModelCupMatch.AccountInfoBasicWithCupInfo cupMatchTeamMemberInfo;

	private TeamUpRecommendAccountInfo teamUpRecommendPlayerInfo;

	private RoomPlayerInfo roomPlayerInfo;

	private UIModelFriends m_ModelFriend;

	private UIModelTeamReserve m_ModelTeamReserve;

	private UIModelGroup m_ModelGroup;

	private UIModelMatch m_ModelMatch;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournamentLadderMatch;

	private UIModelChampionship m_ModelChampionShip;

	private UIModelCupMatch m_ModelCupMatch;

	protected ulong m_AccountId;

	private bool m_IsCoolingDown;

	private UIBaseProfileInfoController m_BaseProfile;

	private UIPopupMessageBoxController m_MesBoxCtrl;

	private UILobbyV2ReserveAndObserveWndController m_ResAndObsWndCtrl;

	private UILobbyV2UGCReserveWndController m_UGCResWndCtrl;

	private bool m_IsFloatingWindow;

	private UIModelRelationShip m_ModelRelationShip;

	private EInvitePushType m_InvitePushType;

	private bool m_IsInGame;

	private uint m_FriendGameMode;

	private UIModelOptionalDownload m_ModelDownload;

	private UINewDownloadInfoController m_DownloadCtrl;

	private float m_NextCheckTime;

	private const string PRIMENICKNAMEKEY = "[x1.5][S0][-]{0}";

	private bool m_IsUGCInviteCoolDown;

	private bool m_ShowReasonReachLimit;

	private const uint MAX_REASON_WIDTH = 228u;

	private List<UIBaseController> m_RecommendReasonCtrls;

	public bool IsFloatingWindow
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HasGroup => false;

	public bool InGame => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void SetInviteDefaultBtnState()
	{
	}

	public void SetReserveDefaultBtnState()
	{
	}

	public void SetDefaultBtnStatus()
	{
	}

	public proto.EPresence.AccountPresence GetPresence()
	{
		return proto.EPresence.AccountPresence.AccountPresence_NONE;
	}

	public proto.EPresence.SocialPresence GetSocialPresence()
	{
		return proto.EPresence.SocialPresence.AccountSocialPresence_NONE;
	}

	private bool IsInSocialHall(BaseProfileInfo info)
	{
		return false;
	}

	public bool IsOffline()
	{
		return false;
	}

	private void OnBgBtnClick()
	{
	}

	private void InviteFriend()
	{
	}

	public void onBtnReserveClick()
	{
	}

	private void OnBtnObserveClick()
	{
	}

	private void OnClickSocialAreaBtn()
	{
	}

	private bool IsNinthResDownloadReady()
	{
		return false;
	}

	private void FixedUpdate()
	{
	}

	private void RefreshDownloadState()
	{
	}

	private void OnDownloadStateChangeCallback()
	{
	}

	private bool CanShowDownloadCtrl()
	{
		return false;
	}

	private void SetDownloadContainerVisable(bool isShow)
	{
	}

	private void HideDownloadCtrl()
	{
	}

	private void OnBtnWorkshopReserveClick()
	{
	}

	protected virtual void OnBtnInviteClick()
	{
	}

	private void OnAddFriendBtnClick()
	{
	}

	private bool CheckCanInviteOrJoin()
	{
		return false;
	}

	private void ClickJoinInGroup()
	{
	}

	private void ClickInviteFriend()
	{
	}

	private void InitCreateGroupToInviteData()
	{
	}

	private void RefreshStateAfterInviteOrJoin()
	{
	}

	private ulong GetAccountID()
	{
		return 0uL;
	}

	private bool CheckCanGroupInvite(BaseProfileInfo info, uint matchMode)
	{
		return false;
	}

	private bool CheckCanGroupJoin(BaseProfileInfo info)
	{
		return false;
	}

	private bool CheckCanGroupInviteAndJoin(BaseProfileInfo info, uint matchMode)
	{
		return false;
	}

	private void SetFriendStatusTypeInGroup(BaseProfileInfo info)
	{
	}

	private void ModifyFriendStatusTypeForSocialArea(proto.EPresence.AccountPresence presence)
	{
	}

	private void SetFriendStatusTypeInRoom(proto.EPresence.AccountPresence presence, BaseProfileInfo info)
	{
	}

	private void SetFriendStatusTypeInGameUGC(proto.EPresence.AccountPresence presence, BaseProfileInfo info)
	{
	}

	private void SetFriendStatusType(BaseProfileInfo info)
	{
	}

	private ulong GetGroupID()
	{
		return 0uL;
	}

	private void GetTargetGameModeAndMatchMode(out uint targetGameMode, out uint targetMatchMode)
	{
		targetGameMode = default(uint);
		targetMatchMode = default(uint);
	}

	private tcp.EGroup.InviteeType GetInviteeType(GroupInviteMemberType type)
	{
		return tcp.EGroup.InviteeType.InviteeType_NONE;
	}

	public void ClearUIData()
	{
	}

	private void SetObserveButtonState(bool show, bool showUGCHalfJoin)
	{
	}

	public bool IsRoomLimit()
	{
		return false;
	}

	private void RefreshInviteBtnState()
	{
	}

	private void OnCancelMatch()
	{
	}

	public void RefreshInviteBtnVisibility()
	{
	}

	private void RefreshInviteBtnFinal()
	{
	}

	private void SetReserveStatus()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	protected virtual void RefreshData()
	{
	}

	protected void RefreshSquadTreasureData()
	{
	}

	public void ShowTeamUpRecommendInfo()
	{
	}

	private IEnumerator ShowCommonFriendAndSocialLight()
	{
		return null;
	}

	private void CheckShowMaxLimit(UIBaseController ctrl)
	{
	}

	private void RefreshSocialAreaBtn()
	{
	}

	private void UpdateCsRankState(uint rank, uint rankpoint, uint peakRankPos, uint brRank, bool isShowCSIcon = true, bool isShowCSPeakIcon = false, uint csPeakPoints = 0u)
	{
	}

	private void RefreshReserveAndObserveWndView()
	{
	}

	private void RefreshUGCReserveWndView()
	{
	}

	private void UpdateHCRankState(uint rank, uint rankpoint)
	{
	}

	private void UpdateBrRankState(uint rank, uint rankpoint, uint peakRankPos, uint csRank, bool isShowBRIcon = true)
	{
	}

	private bool CanShowReserveBtn(FriendAccountInfo info)
	{
		return false;
	}

	private void OnClickRefreshRecommendBtn()
	{
	}

	private void OnClickHeadBtn()
	{
	}

	private void OnGroupChangeNtf(object[] data)
	{
	}

	private void OnJoinNtf(object[] data)
	{
	}

	private bool IsRankingMatch()
	{
		return false;
	}

	public void SetInviteUIType(GroupInviteUI ui)
	{
	}

	public void SetInviteMemberType(GroupInviteMemberType ui)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void SetFloatingWindowsBG(bool isActive)
	{
	}

	public void SetClanIconCarousel(bool isShowClanIcon)
	{
	}

	public void ShowRecommendIcon(bool show)
	{
	}

	private void _003COnClickSocialAreaBtn_003Eb__57_0()
	{
	}

	private void _003CClickJoinInGroup_003Eb__69_5()
	{
	}

	private void _003CClickJoinInGroup_003Eb__69_0()
	{
	}

	private void _003CClickJoinInGroup_003Eb__69_1()
	{
	}

	private void _003CClickJoinInGroup_003Eb__69_7()
	{
	}

	private void _003CClickJoinInGroup_003Eb__69_2()
	{
	}

	private void _003CClickJoinInGroup_003Eb__69_3()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
