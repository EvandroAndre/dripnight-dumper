using System.Collections.Generic;
using proto;

namespace COW;

public class RebateCardData
{
	public int ID;

	public int RebateID;

	public string Price;

	public int RebateDays;

	public RebateCardType RebateCardType;

	public int RebateAmount;

	public int FirstRebateAmount;

	public string ProductIdentifier;

	public int EarningRatePercentage;

	public string NameKey;

	public int DaysAheadForRenewalReminding;

	public string SubscriptionProductIdentifier_iOS;

	public string SubscriptionProductIdentifier_Android;

	public string SubscribePrice;

	public int SubscribeBonus;

	private static Dictionary<int, RebateCardData> _Data;

	public string SubscriptionProductIdentifier => null;

	public static Dictionary<int, RebateCardData> Data => null;

	public bool SupportSubscription()
	{
		return false;
	}

	public void ParseDataFromRebateCardDesc(RebateCardDesc desc)
	{
	}
}
