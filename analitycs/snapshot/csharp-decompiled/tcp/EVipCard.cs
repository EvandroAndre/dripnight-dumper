namespace tcp;

public class EVipCard
{
	public enum Proto
	{
		Proto_NONE,
		Proto_PURCHASE_CARD_NTF,
		Proto_PURCHASE_MEMBERSHIP_NTF
	}

	public enum ErrCode
	{
		ErrCode_SUSS
	}

	public enum VipCardType
	{
		VipCardType_NONE,
		VipCardType_WEEKLY,
		VipCardType_MONTHLY,
		VipCardType_SVIP,
		VipCardType_MINI_WEEKLY
	}
}
