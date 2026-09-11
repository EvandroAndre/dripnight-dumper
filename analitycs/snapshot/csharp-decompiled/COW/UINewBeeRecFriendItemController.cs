using GCommon;
using proto;

namespace COW;

public class UINewBeeRecFriendItemController : UIBaseController
{
	private UINewBeeRecFriendItemView m_View;

	private UIModelFriends m_ModelFriend;

	private UIBaseProfileInfoController m_BaseProfile;

	private CSRecommendFriendsToFreshPlayerRes.Player m_PlayerData;

	private FriendAccountInfo m_FriendInfo;

	private FriendAccountInfoData m_FriendInfoData;

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

	public void SetViewData(CSRecommendFriendsToFreshPlayerRes.Player data, int dataIndex)
	{
	}

	public ulong GetAccountId()
	{
		return 0uL;
	}

	public EFriendAddFrom GetNewBeeRecAddFrom()
	{
		return EFriendAddFrom.None;
	}

	private void ClearUIData()
	{
	}

	private void RefreshData()
	{
	}

	private void OnBgBtnClick()
	{
	}

	private void OnAddFriendBtnClick()
	{
	}

	private ERecommandReason SelectRecommandReason(CSRecommendFriendsToFreshPlayerRes.Player data)
	{
		return ERecommandReason.None;
	}

	private ERecommandReason SelectBestTeamUpReason(CSRecommendFriendsToFreshPlayerRes.Player data)
	{
		return ERecommandReason.None;
	}

	public EFriendAddFrom GetNewBeeRecAddFromByReason(ERecommandReason reason)
	{
		return EFriendAddFrom.None;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
