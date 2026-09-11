using ProtoBuf;

namespace proto;

public class ChampionshipOpenInfoDesc : IMessage
{
	public uint championship_type;

	public uint championship_id;

	public long season_start_time;

	public long season_end_time;

	public long trial_start_time;

	public long trial_end_time;

	public long final_start_time;

	public long final_end_time;

	public string map_id;

	public long entrance_open_time;

	public long entrance_end_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
