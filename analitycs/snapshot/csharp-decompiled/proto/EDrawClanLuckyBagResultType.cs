namespace proto;

public class EDrawClanLuckyBagResultType
{
	public enum ResultType
	{
		ResultType_NONE,
		ResultType_SUCCESS,
		ResultType_TOO_EARLY,
		ResultType_MAX_NUM_PER_DAY,
		ResultType_EXPIRED,
		ResultType_ALL_TAKEN,
		ResultType_ALREADY_DRAWN,
		ResultType_BAG_NOT_FOUND
	}
}
