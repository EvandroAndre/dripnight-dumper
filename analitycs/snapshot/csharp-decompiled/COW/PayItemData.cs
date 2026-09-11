using GCommon;

namespace COW;

public class PayItemData
{
	public string ItemIdentifier;

	public int VirtualCurrencyCount;

	public int BonusVirtualCurrencyCount;

	public int PromotionVirtualCurrencyCount;

	public double CostAmount;

	public string CostString;

	public string CdnUrl;

	public string ResourceName;

	public ResourceID ResourceId;

	public Subscription Subscription;

	public long RebateId;

	public static string Brief(PayItemData data)
	{
		return null;
	}

	public static string Detail(PayItemData data)
	{
		return null;
	}
}
