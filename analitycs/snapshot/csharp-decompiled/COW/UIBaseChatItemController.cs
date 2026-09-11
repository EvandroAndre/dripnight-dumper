using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UIBaseChatItemController : UIBaseController
{
	private enum FastMessageContainer
	{
		None,
		LuckyBuff,
		EvoGunShare,
		ClanTrend,
		UGCMapShare,
		HUDShare,
		PrimeSetShare,
		SquadTreasureTeamShare,
		RelayMartDiscountCodeShare
	}

	protected BaseChatMessageView LeftView;

	protected UIButton headbtnleft;

	protected UIButton LeftContentBtn;

	protected BaseChatMessageView RightView;

	protected UIButton headbtn;

	protected UIButton RightContentBtn;

	protected Transform TipsTrans;

	protected MessageInfo m_Data;

	private float defaultLeftViewOffset;

	private float defaultRightViewOffset;

	private float defaultItemWidth;

	private float defaultViewYAxis;

	private float changeViewYAxis;

	private float defaultTable2ItemWidth;

	private UIBigEventChatMsgItemController m_LeftBigEventMsgItemCtrl;

	private UIBigEventChatMsgItemController m_RightBigEventMsgItemCtrl;

	private UILuckyBuffMsgBannerController m_LeftLuckyBuffMsgBannerCtrl;

	private UILuckyBuffMsgBannerController m_RightLuckyBuffMsgBannerCtrl;

	private UIEVOGunShareBannerController m_LeftEVOGunShareBannerCtrl;

	private UIEVOGunShareBannerController m_RightEVOGunShareBannerCtrl;

	private UIPaymentSquadTreasureInviteItemDetailController m_LeftSquadTreasureTeamShareCtrl;

	private UIPaymentSquadTreasureInviteItemDetailController m_RightSquadTreasureTeamShareCtrl;

	private UIRelayMartDiscountCodeShareItemDetailController m_LeftRelayMartDiscountCodeShareItemDetailCtrl;

	private UIRelayMartDiscountCodeShareItemDetailController m_RightRelayMartDiscountCodeShareItemDetailCtrl;

	private UIPrimeShareClothesBannerController m_LeftPrimeSetShareBannerCtrl;

	private UIClanTrendMemberTrendController m_RightClanTrendCtrl;

	private UIClanTrendMemberTrendController m_LeftClanTrendCtrl;

	private UIUGCMapShareBannerController m_LeftUGCMapShareBannerCtrl;

	private UIUGCMapShareBannerController m_RightUGCMapShareBannerCtrl;

	private UIHUDShareBannerController m_LeftHUDShareBannerCtrl;

	private UIHUDShareBannerController m_RightHUDShareBannerCtrl;

	private UIChatMessageItemRoomInviteController m_LeftRoomInviteCtrl;

	private UIChatMessageItemRoomInviteController m_RightRoomInviteCtrl;

	private UIChatMessageItemRoomWinRateController m_LeftRoomWinRateCtrl;

	private UIChatMessageItemRoomWinRateController m_RightRoomWinRateCtrl;

	private UIChatMessageItemNewBieQuizController m_LeftItemNewBieQuizCtrl;

	private UIChatMessageItemNewbieTopRankController m_LeftItemNewbieTopRankCtrl;

	private UIChatMessageItemTipsController m_ChatMessageItemTipsController;

	protected Transform LeftFastMsgTrans;

	protected Transform RightFastMsgTrans;

	private UIChatMessageItemClanInviteController m_LeftItemClanInviteCtrl;

	private UIChatMessageItemClanInviteController m_RightItemClanInviteCtrl;

	private UIChatMessageItemClanGroupInviteController m_LeftItemClanGroupInviteCtrl;

	private UIChatMessageItemClanGroupInviteController m_RightItemClanGroupInviteCtrl;

	private UIChatMessageItemNewGroupInviteController m_LeftItemNewGroupInviteCtrl;

	private UIChatMessageItemNewGroupInviteController m_RightItemNewGroupInviteCtrl;

	private UIChatMessageItemChampionshipTeamInviteController m_LeftItemChampionshipTeamInviteCtrl;

	private UIChatMessageItemChampionshipTeamInviteController m_RightItemChampionshipTeamInviteCtrl;

	private UIChatMessageItemCupMatchTeamInviteController m_LeftItemCupMatchTeamInviteCtrl;

	private UIChatMessageItemCupMatchTeamInviteController m_RightItemCupMatchTeamInviteCtrl;

	private UIPrivilegeIconController m_PrivilegeIconControllerLeft;

	private UIPrivilegeIconController m_PrivilegeIconControllerRight;

	protected EChatInterfaceType InterfaceType;

	public Bounds bounds => default(Bounds);

	public MessageInfo Data => null;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected virtual EChannel.ChannelType GetParentChannelType()
	{
		return EChannel.ChannelType.ChannelType_GROUP;
	}

	protected void OnHeadBtnClick()
	{
	}

	public virtual void OpenIteractionPanel(InteractionPopUtil.UIInteractionPoptype PopType, string region)
	{
	}

	private void SetMessageUI(BaseChatMessageView view, bool showState)
	{
	}

	public virtual void SetUIData(MessageInfo info, Transform parent = null)
	{
	}

	private void InitItemState()
	{
	}

	public void AdjustChatTable2Layout(BaseChatMessageView view, bool showState, bool isSelf)
	{
	}

	public virtual void UpdateProfileInfo()
	{
	}

	private void OnGoposBtnlick()
	{
	}

	protected virtual void OnResendBtnClick()
	{
	}

	protected virtual void OnClickJoin()
	{
	}

	protected void OnContentClick()
	{
	}

	private void GoToReportBoard(object content)
	{
	}

	private void SetFastMessageContainerActive(bool isLeft, FastMessageContainer activeContainer)
	{
	}

	private int GetMaxPanelDepth()
	{
		return 0;
	}

	private float GetMessageListPanelWidth()
	{
		return 0f;
	}

	protected EChatInterfaceType GetParentInterfaceType()
	{
		return EChatInterfaceType.Normal;
	}

	protected static void CopyToClipBoard(object content)
	{
	}

	public void SetInterfaceType(EChatInterfaceType type)
	{
	}

	private void TrySetPrivilegeIcon(MessageInfo info, BaseChatMessageView currentView, bool isLeft = false)
	{
	}

	private void SetPrivilegeIcon(uint mainType, uint subType, BaseChatMessageView currentView, bool isLeft = false)
	{
	}

	private bool _003COnHeadBtnClick_003Eb__61_0(ClanMember temp)
	{
		return false;
	}

	private bool _003COnHeadBtnClick_003Eb__61_1(ClanMember temp)
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
