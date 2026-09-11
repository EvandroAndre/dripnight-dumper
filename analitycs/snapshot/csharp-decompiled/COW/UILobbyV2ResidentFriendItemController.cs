using GCommon;
using UnityEngine;
using proto;
using tcp;

namespace COW;

public class UILobbyV2ResidentFriendItemController : UIEasyListItemController, IUIModelDataChangeObserver
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
		Room
	}

	private sealed class _003C_003Ec__DisplayClass53_0
	{
		public UIModelCustomRoom modelRoom;

		public UILobbyV2ResidentFriendItemController _003C_003E4__this;

		internal void _003CClickJoinInGroup_003Eb__2()
		{
		}

		internal void _003CClickJoinInGroup_003Eb__3()
		{
		}

		internal void _003CClickJoinInGroup_003Eb__0()
		{
		}

		internal void _003CClickJoinInGroup_003Eb__1()
		{
		}
	}

	private UILobbyV2ResidentFriendItemView m_View;

	private UIModelTeamReserve m_ModelTeamReserve;

	private UIModelGroup m_ModelGroup;

	private UIModelFriends m_ModelFriends;

	private UIModelMatch m_ModelMatch;

	private FriendAccountInfo m_FriendInfo;

	private UILobbyV2ReserveAndObserveWndController m_ResAndObsWndCtrl;

	private EFriendStatusType m_FriendStatusType;

	private ulong m_AccountId;

	private bool m_IsCoolingDown;

	private bool m_SentInvite;

	private string m_NickName;

	private const uint INVITEORJOINWNDOFFSET = 168u;

	private UIModelRelationShip m_ModelRelationShip;

	private EInvitePushType m_InvitePushType;

	private UIPopupMessageBoxController m_MesBoxCtrl;

	private bool m_IsInGame;

	private uint m_FriendGameMode;

	private UIModelOptionalDownload m_ModelDownload;

	private UINewDownloadInfoController m_DownloadCtrl;

	private float m_NextCheckTime;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeak;

	private GameObject m_PrimeAvatarFrame;

	private ResourceID m_AvatarFrameRes;

	public bool HasGroup => false;

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

	public void SetUIData(uint showState = 0u)
	{
	}

	private void UpdatePin(uint pinId)
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

	private proto.EPresence.AccountPresence GetPresence()
	{
		return proto.EPresence.AccountPresence.AccountPresence_NONE;
	}

	private void OnHeadBtnClick()
	{
	}

	private tcp.EGroup.InviteeType GetFriendInviteeType()
	{
		return tcp.EGroup.InviteeType.InviteeType_NONE;
	}

	private void InviteFriend()
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

	private void onBtnReserveClick()
	{
	}

	private void onBtnInviteClick()
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

	public void ClearUIData()
	{
	}

	private void SetObserveButtonState(bool show, bool showUGCHalfJoin)
	{
	}

	private void RefreshInviteBtnState()
	{
	}

	private void RefreshStateAfterInviteOrJoin()
	{
	}

	private void OnCancelMatch()
	{
	}

	private void SetReserveStatus()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshData()
	{
	}

	private void RefreshSocialAreaBtn()
	{
	}

	private void RefreshReserveAndObserveWndView()
	{
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

	private void SetFriendStatusType(BaseProfileInfo info)
	{
	}

	private void RefreshInviteBtnFinal()
	{
	}

	private void RefreshSocialStatus(bool isShowSocialStatus)
	{
	}

	private bool ShowReserveBtn(FriendAccountInfo info)
	{
		return false;
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

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public bool IsOffline()
	{
		return false;
	}

	public void RefreshInviteBtnVisibility()
	{
	}

	private void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	private void _003COnClickSocialAreaBtn_003Eb__42_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
