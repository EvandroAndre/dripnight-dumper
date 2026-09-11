using ProtoBuf;

namespace proto;

public class LivePopupDesc : IMessage
{
	public string tips;

	public uint tips_start_time;

	public uint tips_end_time;

	public ECDN.LivePopupTipsType tips_type;

	public string tips_cdn;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
