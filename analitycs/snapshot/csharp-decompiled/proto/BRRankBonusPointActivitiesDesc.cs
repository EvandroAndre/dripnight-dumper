using ProtoBuf;

namespace proto;

public class BRRankBonusPointActivitiesDesc : IMessage
{
	public long start_time;

	public long end_time;

	public string region;

	public uint[] score_types;

	public uint[] rank_sort_ids;

	public int ratio;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
