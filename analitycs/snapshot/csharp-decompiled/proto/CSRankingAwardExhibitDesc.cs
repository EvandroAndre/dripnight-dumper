using ProtoBuf;

namespace proto;

public class CSRankingAwardExhibitDesc : IMessage
{
	public uint module;

	public uint[] id_award_exhibit;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
