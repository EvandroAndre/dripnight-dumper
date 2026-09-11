namespace proto;

public class RelayMartDiscountCodeInfo
{
	public string discount_code;

	public ulong owner_id;

	public ERelayMart.DiscountCodeStatus status;

	public ulong occupant_id;

	public bool is_shared;

	public bool is_rebate_claimed;

	public uint rebate_diamonds;
}
