using ProtoBuf;

namespace proto;

public class RankingAwardExhibitDesc : IMessage
{
	public uint module;

	public uint[] id_award_exhibit;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
