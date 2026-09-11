using GCommon;
using proto;
using tcp;

namespace COW;

public class UILobbyNotificationFriendOnlineController : UILobbyNotificationPopUpContentBaseController, IUIModelDataChangeObserver
{
	private enum EFriendType
	{
		None,
		Confidant,
		Veteran,
		TeamUpRecommend,
		NewFriendInvite,
		TeamUpFriendIntimacy
	}

	private sealed class _003C_003Ec__DisplayClass43_0
	{
		public ulong veteranAccountId;

		internal bool _003CIsRoomLimit_Veteran_003Eb__0(FriendAccountInfo x)
		{
			return false;
		}
	}

	private UILobbyNotificationFriendOnlineView m_View;

	private UIModelFriends m_ModelFriends;

	private UIModelGroup m_ModelGroup;

	private UIModelTeamReserve m_ModelTeamReserve;

	private EFriendType m_FriendType;

	private ulong m_AccountId;

	private VeteranFriendOnlineNtf m_VeteranNtf;

	private RelatedFriendOnlineNtf m_ConfidantNtf;

	private AccountInfoBasic m_TeamUpRecommendAccountInfo;

	private FriendAccountInfo m_FriendAccountInfo;

	private FriendAccountInfo m_TeamUpFriendIntimacyInfo;

	private UIBaseProfileInfoController m_ProfileCtrl;

	protected override ENotificationPopUpType NotificationType => ENotificationPopUpType.None;

	private UIBaseProfileInfoController ProfileCtrl => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitView()
	{
	}

	protected override UIButton InitInteractionButton()
	{
		return null;
	}

	protected override void OnInteractionBtnClick()
	{
	}

	public override void OnCloseClick()
	{
	}

	public override void OnIgnoreNotification()
	{
	}

	public override void OnOutAnimFinished()
	{
	}

	protected override void OnReset()
	{
	}

	protected override void OnSetViewData(object data)
	{
	}

	private void OnSetViewData(RelatedFriendOnlineNtf data)
	{
	}

	private void OnSetViewData(VeteranFriendOnlineNtf data)
	{
	}

	private void OnSetViewData(FriendAccountInfo data)
	{
	}

	private void OnSetViewData(FriendOnlineNtf friendOnlineNtf)
	{
	}

	private void ClearInviteUI()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void InviteConfidantFriend()
	{
	}

	private void InviteFriend_Confidant()
	{
	}

	private void InitCreateGroupToInviteData()
	{
	}

	private tcp.EGroup.InviteeType GetInviteeType(ulong accountId)
	{
		return tcp.EGroup.InviteeType.InviteeType_NONE;
	}

	private proto.EPresence.AccountPresence GetPresence()
	{
		return proto.EPresence.AccountPresence.AccountPresence_NONE;
	}

	private proto.EPresence.SocialPresence GetSocailPresence()
	{
		return proto.EPresence.SocialPresence.AccountSocialPresence_NONE;
	}

	private bool CheckCanInviteOrJoin()
	{
		return false;
	}

	private bool IsRoomLimit_Confidant()
	{
		return false;
	}

	private void InviteVeteranFriend()
	{
	}

	private void InviteFriend_Veteran()
	{
	}

	private bool IsRoomLimit_Veteran()
	{
		return false;
	}

	private void InviteNewFriend()
	{
	}

	private void InviteFriend_NewFriend()
	{
	}

	private void InviteTeamUpFriendIntimacy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInteractionBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCloseClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnIgnoreNotification()
	{
	}

	public void _003C_003EiFixBaseProxy_OnOutAnimFinished()
	{
	}
}
