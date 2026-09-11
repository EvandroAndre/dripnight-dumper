namespace proto;

public class ESubscription
{
	public enum SubscribeType
	{
		SubscribeType_NONE,
		SubscribeType_REBATE,
		SubscribeType_EP,
		SubscribeType_BUNDLE
	}

	public enum PriceType
	{
		PriceType_NONE,
		PriceType_WEEK,
		PriceType_MONTH
	}

	public enum TagType
	{
		TagType_NONE,
		TagType_LIMITEDTIME,
		TagType_NEW
	}
}
