namespace proto;

public class EVipCard
{
	public enum VipCardType
	{
		VipCardType_NONE = 0,
		VipCardType_WEEKLY = 1,
		VipCardType_MONTHLY = 2,
		VipCardType_MINI_WEEKLY = 4,
		VipCardType_MAX = 9
	}

	public enum AwardStatus
	{
		AwardStatus_INIT,
		AwardStatus_CLAIMED,
		AwardStatus_LOGIN_NOT_CLAIMED
	}

	public enum GoodsType
	{
		GoodsType_NONE,
		GoodsType_VIPONLY,
		GoodsType_FREE
	}

	public enum GoodsPriceType
	{
		GoodsPriceType_NONE,
		GoodsPriceType_GEMS,
		GoodsPriceType_COINS
	}

	public enum RebateType
	{
		RebateType_NONE,
		RebateType_WEEKLY,
		RebateType_MONTHLY,
		RebateType_WEEKLY_DISCOUNT,
		RebateType_MONTHLY_DISCOUNT,
		RebateType_MINI_WEEKLY
	}

	public enum PrivilegeID
	{
		PrivilegeID_NONE,
		PrivilegeID_V_BADGE,
		PrivilegeID_PROFILE_USE,
		PrivilegeID_PET_USE,
		PrivilegeID_MSG_BUBBLE,
		PrivilegeID_FRIEND_LIMIT,
		PrivilegeID_CLOTHES_SLOT_LIMIT
	}

	public enum MembershipRebateType
	{
		MembershipRebateType_NONE,
		MembershipRebateType_TRIDUUM,
		MembershipRebateType_WEEKLY,
		MembershipRebateType_MONTHLY
	}
}
