namespace proto;

public class EUgcInventory
{
	public enum TransReason
	{
		TransReason_None,
		TransReason_Admin,
		TransReason_ExchangeTokens,
		TransReason_PurchaseProduct,
		TransReason_ConsumeItemByGS,
		TransReason_RefundProduct,
		TransReason_ClawbackTokens,
		TransReason_ReverseTokens
	}
}
