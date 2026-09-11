namespace tcp;

public class EStore
{
	public enum Proto
	{
		Proto_NONE,
		Proto_IAP_PURCHASE_DONE,
		Proto_PBW_PURCHASE_DONE,
		Proto_IAP_INFO_CHANGE,
		Proto_PBW_INFO_PAY_LEVEL,
		Proto_RECEIVE_GIFT
	}

	public enum ErrCode
	{
		ErrCode_SUSS
	}
}
