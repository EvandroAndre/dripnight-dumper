using GCommon;
using proto;

namespace COW;

internal class UIProfileRecentVisitorItemController : UIEasyListItemController
{
	private UIProfileRecentVisitorItemView m_View;

	private CSGetVisitorsRes.VisitorRecord m_PlayerVisitorInfo;

	private UIBaseProfileInfoController m_BaseProfileInfo;

	private UIProfileRecentVisitorPopWndController m_Parent;

	private AccountInfoBasic m_VisitorAccountInfo;

	private uint m_VisitGameMode;

	private uint m_VisitMatchMode;

	private bool m_VisitorIsFriend;

	private bool m_VisitorIsLiked;

	private bool m_VisitorIsGifted;

	private UIModelProfile m_ModelProfile;

	private UIModelFriends m_ModelFriend;

	private ulong m_LastInteractionTime;

	private uint m_RewardTotalCoinsNum;

	private UIProfileRecentVisitorPopWndController.EVisitorTabType m_Type;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SetDefaultView()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshVisitorView()
	{
	}

	public void SetParent(UIProfileRecentVisitorPopWndController parent)
	{
	}

	public string GetLastVisitTime(ulong lastLoginAt)
	{
		return null;
	}

	private void OnAddFriendBtnClick()
	{
	}

	private void OnShowBriefBoxClickShow()
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
}
