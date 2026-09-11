using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIMallGiftSendController : UIMallPurchaseBaseController
{
	private GiftItem m_GiftItemData;

	private PrimeStoreItemDesc m_PrimeGiftItemData;

	private string m_ReceiversName;

	private Dictionary<ulong, string> m_MessageDict;

	private ulong[] m_ReceiversIdList;

	private EGiftStore_BuddyType m_BuddyType;

	private EGiftSendSource m_GiftSource;

	private bool m_IsPrimeSend;

	private string m_Message;

	private uint m_TrueShowPrice;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnGemsPurchaseBtnClick()
	{
	}

	private void OnGoldPurchaseBtnClick()
	{
	}

	private void SendItem(EInventory.CurrencyType currency)
	{
	}

	public void RefreshData(GiftItem giftItem, ulong[] receiversIdList, EGiftStore_BuddyType buddyType, string message, string receiversName, int itemCount = 1, Dictionary<ulong, string> messageDict = null, EGiftSendSource source = EGiftSendSource.GiftMall, bool isPrime = false)
	{
	}

	private void SetPriceData()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
