using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UILobbyV2GameAssistRequestItemController : UILobbyV2GameAssistNormalItemController
{
	private UILobbyV2GameAssistRequestItemView m_View;

	private FriendAccountInfo m_FriendInfo;

	private ClanApplicationAndInvitationInfo m_ClanApplyInfo;

	private UIModelGameAssistantIntroduction m_ModelGameAssistantIntroduction;

	private UIBaseProfileInfoController m_BaseProfile;

	private UISocialHighlightIconController m_SocialHighLightCtrl;

	private UILeaderBoardTitleIconController m_LeaderBoardTitleController;

	private Vector3 Big_Size;

	private Vector3 Small_Size;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData()
	{
	}

	protected override void SetRead()
	{
	}

	private void BtnProfileOnClick()
	{
	}

	private void BtnAcceptOnClick()
	{
	}

	private void BtnRefuseOnClick()
	{
	}

	private void AcceptFriend()
	{
	}

	private void RefuseFriend()
	{
	}

	private void AcceptClanApply()
	{
	}

	private void RefuseClanApply()
	{
	}

	private ELobbyAssistDataType GetDataType()
	{
		return ELobbyAssistDataType.None;
	}

	private void RefreshFriendRequestView()
	{
	}

	private void RefreshClanApplyView()
	{
	}

	protected override void SetViewData(object data, int index)
	{
	}

	private void OnCommonFriendsButtonClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SetRead()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}
}
