using ProtoBuf;

namespace proto;

public class PhotoWallReportDesc : IMessage
{
	public uint punish_reported_limit;

	public uint ban_duration;

	public uint daily_report_limit;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
