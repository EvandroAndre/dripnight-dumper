using ProtoBuf;

namespace proto;

public class OccupationSeasonInfo : IMessage
{
	public uint season_id;

	public uint game_mode;

	public OccupationInfo info;

	public uint match_mode;

	public uint extend_val;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
