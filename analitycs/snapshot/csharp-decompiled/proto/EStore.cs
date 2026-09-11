namespace proto;

public class EStore
{
	public enum GiftRankType
	{
		GiftRankType_NONE,
		GiftRankType_RECEIVER,
		GiftRankType_GIVER
	}

	public enum IapType
	{
		IapType_NORMAL,
		IapType_VETERAN,
		IapType_NEWBIE
	}

	public enum IapConsumeType
	{
		IapConsumeType_CASH,
		IapConsumeType_DIAMOND
	}

	public enum IapSpecialDropType
	{
		IapSpecialDropType_NONE,
		IapSpecialDropType_HEAD_SHOT_KILLS,
		IapSpecialDropType_KILLS,
		IapSpecialDropType_HP_PKG_USED_CNT,
		IapSpecialDropType_DAMAGE
	}

	public enum IapStoreType
	{
		IapStoreType_NONE,
		IapStoreType_AFTER_FIGHT,
		IapStoreType_WEB_ACTIVITY,
		IapStoreType_OPTIONAL_BUNDLE,
		IapStoreType_VIPCARD
	}

	public enum IapDropSituation
	{
		IapDropSituation_NONE,
		IapDropSituation_AFTER_FIGHT,
		IapDropSituation_RECHARGE,
		IapDropSituation_EXCHANGE_ITEM
	}

	public enum RebateCardBillStatus
	{
		RebateCardBillStatus_NONE,
		RebateCardBillStatus_HITTING,
		RebateCardBillStatus_DONE,
		RebateCardBillStatus_TIMEOUT,
		RebateCardBillStatus_PENDING,
		RebateCardBillStatus_INVALID
	}

	public enum PbwConsumeType
	{
		PbwConsumeType_CASH,
		PbwConsumeType_DIAMOND,
		PbwConsumeType_FREE
	}

	public enum PayLevelRewardHintType
	{
		PayLevelRewardHintType_NONE,
		PayLevelRewardHintType_NOPAY,
		PayLevelRewardHintType_PAY,
		PayLevelRewardHintType_ALL
	}

	public enum PayLevelInfoState
	{
		PayLevelInfoState_RECEIVED,
		PayLevelInfoState_FINISHED,
		PayLevelInfoState_AWARDED
	}

	public enum PurchaseItemChannel
	{
		PurchaseItemChannel_OTHER,
		PurchaseItemChannel_GOOGLE_PLAY_POINT
	}

	public enum HyperBookType
	{
		HyperBookType_FREE,
		HyperBookType_PAID
	}

	public enum DeliverItemStatus
	{
		DeliverItemStatus_NONE,
		DeliverItemStatus_MAIL_SENT
	}

	public enum PbwActivityType
	{
		PbwActivityType_NONE,
		PbwActivityType_GENERAL,
		PbwActivityType_FRESH,
		PbwActivityType_LUPV1,
		PbwActivityType_LUPV2
	}
}
