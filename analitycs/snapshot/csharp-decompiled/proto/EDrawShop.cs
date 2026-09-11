namespace proto;

public class EDrawShop
{
	public enum RareType
	{
		RareType_NORMAL,
		RareType_RARE,
		RareType_SUPER_RARE
	}

	public enum DiscountType
	{
		DiscountType_NONE,
		DiscountType_NORMAL_DISCOUNT,
		DiscountType_LIMIT_DISCOUNT,
		DiscountType_DAILY_DISCOUNT
	}

	public enum PurChaseType
	{
		PurChaseType_NONE,
		PurChaseType_FREE,
		PurChaseType_ITEM,
		PurChaseType_CURRENCY,
		PurchaseType_MIXED
	}

	public enum LimitedPoolOperationType
	{
		LimitedPoolOperationType_NONE,
		LimitedPoolOperationType_FIRST_DRAW,
		LimitedPoolOperationType_NORMAL_PURCHASE
	}

	public enum AdminResetType
	{
		ResetType_NONE,
		ResetType_LIMITED_POOL,
		ResetType_UNLIMITED_WHEEL,
		ResetType_UNLIMITED_TOWER
	}
}
