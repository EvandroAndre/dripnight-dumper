using GCommon;

namespace COW;

public class UIGitfGetRewardController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private const string GIFT_CHAT_MESSAGE_KEY = "T_50_TT_THANKS_GIFT_CHAT";

	private UIGiftGetRewardView m_View;

	private RewardBtn m_BtnData;

	private UIModelFriends m_ModelFriends;

	private GiftRewardPopupData m_Data;

	private CSSharedItemData m_ItemData;

	private FriendInfo m_SenderInfo;

	private bool m_IsFriend;

	private bool m_IsRequestingClaim;

	private UIMallV2IntimacyProfileInfoController m_ReceiveGiftCallsignCtrl;

	private UIMallV2IntimacyProfileInfoController m_GiftCardCallsignCtrl;

	private UIStandardItemMAXBController m_ReceiveGiftItemCtrl;

	private UIStandardItemMAXBController m_GiftCardItemCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	public void ShowGiftMessage(GiftRewardPopupData info)
	{
	}

	private void RefreshCallsignView()
	{
	}

	private void OnOKBtnClick()
	{
	}

	private void OnAddFriendBtnClick()
	{
	}

	private void OnRequestAccountInfoFinish(object[] data)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}
}
