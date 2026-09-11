using ProtoBuf;

namespace proto;

public class PhotoWallReportInfo : IMessage
{
	public uint reports_today;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
