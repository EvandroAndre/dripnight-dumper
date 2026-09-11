namespace proto;

public class ESharedGacha
{
	public enum RareType
	{
		RareType_NONE,
		RareType_S,
		RareType_A,
		RareType_B,
		RareType_C,
		RareType_D
	}

	public enum DrawStatus
	{
		DrawStatus_SUCCESS,
		DrawStatus_PARTIAL,
		DrawStatus_POOL_EMPTY,
		DrawStatus_PITY_FAILED
	}

	public enum PurchaseType
	{
		PurchaseType_NONE,
		PurchaseType_CD_FREE,
		PurchaseType_DISCOUNT_FREE,
		PurchaseType_ITEM,
		PurchaseType_CURRENCY,
		PurchaseType_MIXED
	}
}
