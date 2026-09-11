using ProtoBuf;

namespace proto;

public class HippoCrisisSeasonInfoDesc : IMessage
{
	public uint id;

	public long open_time;

	public long end_time;

	public string season_name;

	public uint starting_rp;

	public uint[] season_award_preview_rank;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
