using ProtoBuf;

namespace proto;

public class CreditSettingDesc : IMessage
{
	public uint credit_max;

	public uint credit_min;

	public uint credit_default;

	public uint teammate_report_mail_threshold;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
