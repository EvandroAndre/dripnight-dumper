namespace proto;

public class ELottery
{
	public enum LotteryType
	{
		LotteryType_NONE,
		LotteryType_ONE,
		LotteryType_SOME,
		LotteryType_DROPUP_BUFF,
		LotteryType_RERANDOM
	}

	public enum PoolType
	{
		PoolType_ALL,
		PoolType_FR,
		PoolType_R,
		PoolType_SR,
		PoolType_NO_R,
		PoolType_NO_SR,
		PoolType_NO_R_SR,
		PoolType_NO_FR,
		PoolType_NO_FR_R,
		PoolType_NO_FR_SR,
		PoolType_NO_FR_R_SR,
		PoolType_MUST_DROP,
		PoolType_VETERAN,
		PoolType_LUCKY_SPIN
	}

	public enum CoinType
	{
		CoinType_NONE,
		CoinType_COINS,
		CoinType_GEMS,
		CoinType_ONLYTOKEN
	}

	public enum WeightType
	{
		WeightType_NONE,
		WeightType_FIRST_REWARD,
		WeightType_BASE,
		WeightType_SECOND_LEVEL,
		WeightType_THIRD_LEVEL,
		WeightType_VETERAN,
		WeightType_FOURTH_LEVEL,
		WeightType_FIFTH_LEVEL
	}

	public enum ConsumeType
	{
		ConsumeType_NONE,
		ConsumeType_FREE,
		ConsumeType_EXCHANGE_ITEM,
		ConsumeType_MONEY,
		ConsumeType_MIXED,
		ConsumeType_DISCOUNT_FREE
	}

	public enum ExtraRewardState
	{
		ExtraRewardState_NONE,
		ExtraRewardState_RECEIVED
	}

	public enum Type
	{
		Type_NORMAL = 0,
		Type_TURNTABLE = 1,
		Type_LIMIT_POOL = 4,
		Type_TOKEN_GACHA = 5,
		Type_COMPLETION = 7,
		Type_HACKERSTORE = 8,
		Type_UNLIMIT_POOL = 9,
		Type_DOUBLE_WHEEL = 10,
		Type_SHARED_GACHA = 11
	}

	public enum RareType
	{
		RareType_NORMAL,
		RareType_RARE,
		RareType_SUPER_RARE
	}

	public enum LimitPurchaseType
	{
		LimitPurchaseType_NONE,
		LimitPurchaseType_DAILY,
		LimitPurchaseType_SUBID
	}

	public enum ExtraRewardCdtType
	{
		ExtraRewardCdtType_NONE,
		ExtraRewardCdtType_LOTTERY_COUNT,
		ExtraRewardCdtType_PROGRESS
	}

	public enum BuffUpDisplayLevel
	{
		BuffUpDisplayLevel_LOW,
		BuffUpDisplayLevel_MEDIUM,
		BuffUpDisplayLevel_HIGH
	}

	public enum LuckySpinType
	{
		LuckySpinType_NONE,
		LuckySpinType_LOTTERY,
		LuckySpinType_LIMITED_CHEST
	}

	public enum ExchangeItemGroupType
	{
		EXCHANGE_ITEM_GROUP_1,
		EXCHANGE_ITEM_GROUP_2
	}
}
