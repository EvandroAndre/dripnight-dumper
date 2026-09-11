namespace proto;

public class EUgcAdmin
{
	public enum TransReason
	{
		TransReason_None = 0,
		TransReason_Admin = 1,
		TransReason_ExchangeTokens = 2,
		TransReason_PurchaseProduct = 3,
		TransReason_ConsumeItemByGS = 4,
		TransReason_RefundProduct = 5,
		TransReason_ClawbackTokens = 6,
		TransReason_ReverseTokens = 7,
		TransReason_RevenueShare = 101,
		TransReason_RefundDeduct = 102,
		TransReason_ClawbackDeduct = 103,
		TransReason_AdminTransfer = 104
	}

	public enum QueryType
	{
		QueryType_Player,
		QueryType_Creator,
		QueryType_OfficialRevenue,
		QueryType_OfficialRisk,
		QueryType_OfficialCash
	}

	public enum TxDirection
	{
		TxDirection_All,
		TxDirection_Income,
		TxDirection_Expense
	}

	public enum ItemsTransReason
	{
		ItemsTransReason_None = 0,
		ItemsTransReason_PurchaseProduct = 3,
		ItemsTransReason_ConsumeItemByGS = 4
	}

	public enum ReverseTokensMode
	{
		ReverseTokensMode_All,
		ReverseTokensMode_Specific
	}
}
