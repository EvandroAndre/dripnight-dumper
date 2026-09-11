using ProtoBuf;

namespace proto;

public class CSProtectionDesc : IMessage
{
	public uint rank;

	public uint base_score;

	public uint extra_score;

	public uint multi_map_protect_points;

	public string region;

	public float cs_protection_battle_point_rank_cal;

	public uint cs_protection_battle_point_max;

	public uint rank_sort_id;

	public uint hacker_protection;

	public float assist;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
