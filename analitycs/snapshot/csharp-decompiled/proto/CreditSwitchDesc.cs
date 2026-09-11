using ProtoBuf;

namespace proto;

public class CreditSwitchDesc : IMessage
{
	public bool credit_switch;

	public string open_key;

	public string close_key;

	public uint reduce_exemption_day_cnt;

	public bool write_penalty_info_switch;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
