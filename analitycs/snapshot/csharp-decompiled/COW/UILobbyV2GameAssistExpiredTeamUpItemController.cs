using GCommon;

namespace COW;

internal class UILobbyV2GameAssistExpiredTeamUpItemController : UILobbyV2GameAssistNormalItemController, IUIModelDataChangeObserver
{
	private enum EFriendStatusType
	{
		None,
		CanInvite,
		CanJoinGroup,
		CanInviteAndJoin
	}

	private UILobbyV2GameAssistExpiredTeamUpItemView m_View;

	private AssistExpiredTeamUpInfo m_Info;

	private FriendAccountInfo m_FriendInfo;

	private UIBaseProfileInfoController m_ProfileCtrl;

	private UIModelFriends m_ModelFriends;

	private UIModelRelationShip m_ModelRelationShip;

	private UIModelGroup m_ModelGroup;

	private UIModelTeamReserve m_ModelTeamReserve;

	private UIModelGameAssistantIntroduction m_ModelGameAssistantIntroduction;

	private UIModelMatch m_ModelMatch;

	private EFriendStatusType m_FriendStatusType;

	private EInvitePushType m_InvitePushType;

	private bool m_IsCoolingDown;

	private UIPopupMessageBoxController m_MesBoxCtrl;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void SetViewData(object data, int index)
	{
	}

	private void ClearUIData()
	{
	}

	private bool IsRankingMatch()
	{
		return false;
	}

	private void SetFriendStatusType()
	{
	}

	private void SetReserveStatus()
	{
	}

	private void SetDefaultBtnStatus()
	{
	}

	private void SetReserveDefaultBtnState()
	{
	}

	private void SetInviteDefaultBtnState()
	{
	}

	private void RefreshStateAfterInviteOrJoin()
	{
	}

	private void UpdateBrRankState(uint rank, uint rankpoint, uint peakRankPos, bool isShowBRIcon = true)
	{
	}

	private void UpdateCsRankState(uint rank, uint rankpoint, uint peakRankPos, bool isShowCSIcon = true)
	{
	}

	private void RefreshInviteBtnState()
	{
	}

	private bool IsRoomLimit()
	{
		return false;
	}

	private bool IsOffline()
	{
		return false;
	}

	private void OnProfileBtnClick()
	{
	}

	private void OnInviteBtnClick()
	{
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

	private void InviteFriend()
	{
	}

	private bool CheckCanInviteOrJoin()
	{
		return false;
	}

	private void OnReserveBtnClick()
	{
	}

	private void OnSocialAreaBtnClick()
	{
	}

	private void OnAddFriendBtnClick()
	{
	}

	protected override void SetRead()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void _003CClickJoinInGroup_003Eb__33_0()
	{
	}

	private void _003CClickJoinInGroup_003Eb__33_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_SetRead()
	{
	}
}
