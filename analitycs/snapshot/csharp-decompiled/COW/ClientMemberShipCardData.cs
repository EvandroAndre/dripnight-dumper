using proto;

namespace COW;

public class ClientMemberShipCardData
{
	public bool HasProcessed;

	public uint ID;

	public EVipCard.VipCardType Type;

	public RebateCardData RebateCardData;

	private PayItemData _003CSubscriptionProductFromCSV_003Ek__BackingField;

	public uint Percent;

	public uint CardWorth;

	public uint SignDiamondGet;

	public uint InstantDiamondGet;

	public uint TotalDiamondReward;

	public uint RemainingDays;

	public ulong CardEndTime;

	public uint CurrentDay;

	public uint DiscountStartTime;

	public uint DiscountEndTime;

	public float DiscountPrice;

	public uint DiscountPurchaseLimitTime;

	public int DiscountRebateID;

	public string DiscountProductIdentifier;

	public uint TodayGemReward;

	public VipCardRebateDesc AirDropRebateDesc;

	public uint WarnTime;

	public string DescBGCDN;

	public uint ReissueCoins;

	public PayItemData SubscriptionProductFromCSV
	{
		get
		{
			return _003CSubscriptionProductFromCSV_003Ek__BackingField;
		}
		private set
		{
			_003CSubscriptionProductFromCSV_003Ek__BackingField = value;
		}
	}

	public ClientMemberShipCardData(EVipCard.VipCardType type)
	{
	}

	public void LoadRebateCardData()
	{
	}

	public void Reset()
	{
	}
}
