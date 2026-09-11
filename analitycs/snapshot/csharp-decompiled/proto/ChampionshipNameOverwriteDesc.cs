using ProtoBuf;

namespace proto;

public class ChampionshipNameOverwriteDesc : IMessage
{
	public uint championship_type;

	public uint championship_id;

	public uint name_type;

	public string language;

	public string content;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
