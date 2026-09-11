using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMallV2SendGiftPopupWndController : UIPopupWindowController, IVoucher, IUIModelDataChangeObserver
{
	private const string DEFAULT_MESSAGE_KEY = "T_28_L_E_THE_JAM_DESC";

	private UIMallV2SendGiftPopupWndView m_View;

	private UIModelGift m_ModelGift;

	private UIModelMall m_ModelMall;

	private GiftItem m_SelectedGift;

	private CSSharedItemData m_GiftItemData;

	private EGiftSendSource m_GiftSource;

	private FriendInfo m_SelectedFriend;

	private UIMallV2IntimacyProfileInfoController m_IntimacyProfileController;

	private UIStandardItemMAXBController m_StandardItemController;

	private bool m_IsPrime;

	private string m_CurrentString;

	private int m_Count;

	private int m_MaxCount;

	private int m_MaxStoreCount;

	private VoucherData m_VoucherData;

	private UIMallVoucherV2Controller m_VoucherCtrl;

	private uint m_CoinsPrice;

	private uint m_GemsPrice;

	private uint m_TrueShowPrice;

	private bool m_InputExceedNotify;

	private bool m_CanShowModifyContainer;

	private bool m_CanOverflow;

	private int ItemCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

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

	public void SetData(GiftItem giftItem, FriendInfo friendInfo, bool isPrime, EGiftSendSource giftSource = EGiftSendSource.GiftMall)
	{
	}

	private void OnInputChange()
	{
	}

	public void OnCloseBtnClick()
	{
	}

	private void OnGemsPurchaseBtnClick()
	{
	}

	private void OnGoldPurchaseBtnClick()
	{
	}

	private void OnPlusBtnClick()
	{
	}

	private void OnMinsBtnClick()
	{
	}

	private void SetPriceLabelText()
	{
	}

	private void RefreshVoucherCtrlTotalPrice()
	{
	}

	private uint GetVoucherID()
	{
		return 0u;
	}

	private void SetMaxCount(int maxCount, int maxSotreCount = 0)
	{
	}

	private void SetMaxPurchaseCount(uint limited_purchase_times, uint purchase_times, int affordNum = int.MaxValue)
	{
	}

	private void ShowLimitedPurchase(uint limited_purchase_times, uint purchase_times)
	{
	}

	private void ShowModifyCountContainer()
	{
	}

	private void ShowVoucherContainer()
	{
	}

	public UIVoucherController OpenVoucherController(Transform parent)
	{
		return null;
	}

	public UIVoucherItemController OpenVoucherItemController(Transform parent)
	{
		return null;
	}

	public void OnVoucherItemClick(object[] data)
	{
	}

	private void SetBeforeVoucherLabel()
	{
	}

	private void ShowVoucherEffect()
	{
	}

	private void InitItemInfo(BaseItemInfo baseItemInfo)
	{
	}

	private bool CanShowModifyCountContainer(uint awardTime, uint limited_purchase_times)
	{
		return false;
	}

	private void EnableInput(bool enable)
	{
	}

	private void OnCountInputSubmit()
	{
	}

	private void RefreshCountInput()
	{
	}

	private void OnCountInputChanged()
	{
	}

	private void SendItem(EInventory.CurrencyType currency)
	{
	}

	private void SetPriceData()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
