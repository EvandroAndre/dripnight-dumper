using ProtoBuf;

namespace proto;

public class RebateCardDesc : IMessage
{
	public uint rebate_id;

	public uint subscription_bonus;

	public uint rebate_type;

	public string rebate_name;

	public string price;

	public uint rebate_days;

	public string product_identifier;

	public string rebate_percentage;

	public uint days_ahead_for_renewal_reminding;

	public string subscribe_price;

	public string subscription_product_identifier_android;

	public string subscription_product_identifier_ios;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
