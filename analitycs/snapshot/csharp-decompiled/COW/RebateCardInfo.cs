using System.Collections.Generic;

namespace COW;

public class RebateCardInfo
{
	public enum ELocalizedPriceStatus
	{
		Unloaded,
		Loading,
		Loaded
	}

	public ELocalizedPriceStatus PriceStatus;

	public ELocalizedPriceStatus SubscriptionPriceStatus;

	public RebateCardData CardInfo;

	public bool Owned;

	public bool Valid_To_Redeem;

	public bool Valid_To_Purchase;

	public int Remaining_Days;

	public ulong TimeSpan_To_NextRedeem;

	public RebateCardType Type;

	public string CDN_URL;

	public uint CDN_EndTime;

	private PayItemData _SubscriptionProductFromCSV;

	public PayItemData SubscriptionProductFromCSV => null;

	public RebateCardInfo(RebateCardType type, List<RebateCardData> rebateCardDatas = null)
	{
	}

	public void UpdateDynamicData(RebateItemData rebateItemData)
	{
	}
}
