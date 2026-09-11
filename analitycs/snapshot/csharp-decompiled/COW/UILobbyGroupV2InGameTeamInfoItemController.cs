using GCommon;
using tcp;

namespace COW;

internal class UILobbyGroupV2InGameTeamInfoItemController : UIBaseController, IUIModelDataChangeObserver
{
	private UILobbyGroupV2InGameTeamInfoItemView m_View;

	private UIModelFriends m_ModelFriend;

	private UIModelGroup m_ModelGroup;

	private UIModelUser m_ModelUser;

	private UIModelCollection m_ModelCollection;

	private UIModelPrime m_ModelPrime;

	private UIModelRole m_ModelRole;

	private UIModelMatch m_ModelMatch;

	private UIBRRankIconController m_BRRankIconController;

	private UICSRankIconController m_CSRankIconController;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private GroupMemberInfo m_MemInfo;

	private UIHudSocialLobbyPrimeGroupMemberInfoShareClothesController m_ShareClothesController;

	private const string COUNTDOWN_TIME_FORMAT = "({0}s)";

	private bool m_BubbleVisible;

	private float m_BubbleHideTime;

	private uint m_BubbleSetShareID;

	private bool m_AcceptRequestVisible;

	private EPrimeShareClothesBubbleState m_PendingNtfState;

	private ulong m_PendingSharerAccountID;

	private ulong m_PendingShareeAccountID;

	private uint m_PendingSetShareID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void Update()
	{
	}

	public GroupMemberInfo GetMemberInfo()
	{
		return null;
	}

	private void OnSelectBtnClick()
	{
	}

	public void SetVacant()
	{
	}

	public void SetMember(GroupMemberInfo member)
	{
	}

	private void RefreshRankLimitContainer(GroupMemberInfo member)
	{
	}

	private void HideRankLimitContainer()
	{
	}

	private bool RefreshPrivilegeIcon(GroupMemberInfo member)
	{
		return false;
	}

	private void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	private void ApplyMemberNameLabel(GroupMemberInfo member, string display, bool hasPrivilege)
	{
	}

	private void ApplyPrimeNameStyle(GroupMemberInfo member)
	{
	}

	private void RefreshLocalPrimeDisplay()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshLocalMemberInfo()
	{
	}

	private void RefreshRankContainer(GroupMemberInfo member)
	{
	}

	public void SetReadyState(bool ready, bool leader, bool isNeedShowNoInLobbyTip = false)
	{
	}

	public void RefreshReadyState()
	{
	}

	public void RefreshPrimeSetShareView()
	{
	}

	private void HidePrimeShareContainer()
	{
	}

	private void OnPrimeSetShareNtf(GEvent evt)
	{
	}

	private string BuildBubbleText(GEventSetShareNtf data)
	{
		return null;
	}

	private static string StripCountdownPlaceholder(string text)
	{
		return null;
	}

	private void ShowPrimeBubble(string text, float duration, uint setShareID)
	{
	}

	private void HidePrimeBubble(bool refreshPrimeShareContainer = false)
	{
	}

	private void ShowAcceptRequestButton(GEventSetShareNtf data)
	{
	}

	private void OnPrimeBubbleCountDownFinished()
	{
	}

	private void HideAcceptRequestButton()
	{
	}

	private bool CheckInMatchMaking()
	{
		return false;
	}

	private void OnOfferSetShareBtnClick()
	{
	}

	private void OnApplySetShareBtnClick()
	{
	}

	private void OnPrimeSetShareBubbleHide(uint setShareID)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
