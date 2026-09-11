namespace proto;

public class CSPayBundleWindowPurchaseReq
{
	public string login_token;

	public uint rebate_card_id;

	public uint id;

	public EStore.PbwConsumeType consume_type;

	public uint rebate_card_end_timestamp;
}
