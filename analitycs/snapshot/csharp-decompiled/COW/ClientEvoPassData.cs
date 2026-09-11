using proto;

namespace COW;

public class ClientEvoPassData
{
	public MembershipDesc Desc;

	public EVipCard.MembershipRebateType EvoPassType;

	public string ProductIdentifier;

	public string SubscriptionProductIdentifier;

	public uint RebateId;

	public uint SubscribeRebateId;

	public uint DuringTime;

	public uint SubscribeBonus;

	public string CDN;

	public bool ShowSalesTag;

	public uint GemsPrice;

	private PayItemData m_PayItemData;

	private PayItemData m_SubscribePayItemData;

	public PayItemData PayItemData => null;

	public PayItemData SubscribePayItemData => null;

	public ClientEvoPassData(MembershipDesc desc)
	{
	}

	public bool SupportSubscription()
	{
		return false;
	}
}
