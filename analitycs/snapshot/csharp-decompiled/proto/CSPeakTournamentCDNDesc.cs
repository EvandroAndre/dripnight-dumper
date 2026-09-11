using ProtoBuf;

namespace proto;

public class CSPeakTournamentCDNDesc : IMessage
{
	public uint id;

	public string cdn_url;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
