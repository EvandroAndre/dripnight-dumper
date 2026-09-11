namespace proto;

public class EUgcMonetize
{
	public enum OwnerType
	{
		OwnerType_None,
		OwnerType_Creator,
		OwnerType_OfficialRevenue,
		OwnerType_OfficialRisk,
		OwnerType_OfficialCash
	}

	public enum OrderType
	{
		OrderType_None,
		OrderType_Sale,
		OrderType_Refund,
		OrderType_Transfer,
		OrderType_Clawback
	}

	public enum TransReason
	{
		TransReason_None = 0,
		TransReason_RevenueShare = 101,
		TransReason_RefundDeduct = 102,
		TransReason_ClawbackDeduct = 103,
		TransReason_AdminTransfer = 104
	}
}
