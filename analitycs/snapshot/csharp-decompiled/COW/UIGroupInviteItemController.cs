using GCommon;
using proto;
using tcp;

namespace COW;

public class UIGroupInviteItemController : UIEasyListItemController, IUIModelDataChangeObserver
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

	private UIGroupInviteItemView m_View;

	public GroupInviteMemberType InviteType;

	public int ItemIdex;

	private object m_Data;

	protected EFriendStatusType m_FriendStatusType;

	private GroupInviteUI m_InviteUI;

	private ClanMember clanMemberInfo;

	private FriendAccountInfo friendInfo;

	private TeamMemberWithAccountInfo teamMemberInfo;

	private UIModelCupMatch.AccountInfoBasicWithCupInfo cupMatchTeamMemberInfo;

	private ulong m_AccountId;

	private UIModelTeamReserve m_ModelTeamReserve;

	private UIModelGroup m_ModelGroup;

	private UIModelFriends m_ModelFriend;

	private float m_StartTime;

	private bool m_IsCoolingDown;

	private UIBaseProfileInfoController m_BaseProfile;

	private bool m_SentInvite;

	private bool m_IsFloatingWindow;

	private EInvitePushType m_InvitePushType;

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

	protected override void OnUIDestory()
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

	public bool IsOffline()
	{
		return false;
	}

	public proto.EPresence.AccountPresence GetPresence()
	{
		return proto.EPresence.AccountPresence.AccountPresence_NONE;
	}

	public proto.EPresence.SocialPresence GetSocialPresence()
	{
		return proto.EPresence.SocialPresence.AccountSocialPresence_NONE;
	}

	private void OnBgBtnClick()
	{
	}

	public void SetSelected(bool v)
	{
	}

	private void InviteFriend()
	{
	}

	private void onBtnReserveClick()
	{
	}

	protected virtual void onBtnInviteClick()
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

	private void SetFriendStatusTypeInGroup(proto.EPresence.AccountPresence presence, BaseProfileInfo info)
	{
	}

	private void SetFriendStatusTypeInRoom(proto.EPresence.AccountPresence presence)
	{
	}

	private void SetFriendStatusType(proto.EPresence.AccountPresence presence, BaseProfileInfo info)
	{
	}

	private ulong GetGroupID()
	{
		return 0uL;
	}

	private tcp.EGroup.InviteeType GetInviteeType(GroupInviteMemberType type)
	{
		return tcp.EGroup.InviteeType.InviteeType_NONE;
	}

	public void ClearUIData()
	{
	}

	public bool IsRoomLimit()
	{
		return false;
	}

	private void RefreshInviteBtnState()
	{
	}

	public void RefreshInviteBtnVisibility()
	{
	}

	private void SetReserveStatus()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void UpdateCsRankState(uint rank, uint rankpoint, uint peakRankPos)
	{
	}

	private void UpdateBrRankState(uint rank, uint rankpoint, uint peakRankPos)
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

	private bool _003COnJoinNtf_003Eb__64_0(GroupMemberInfo a)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
