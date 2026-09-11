using ProtoBuf;

namespace proto;

public class BehavioralPointsDesc : IMessage
{
	public uint verbal_abuse_b_count;

	public uint verbal_abuse_c_count;

	public uint like_a_count;

	public uint credit_reduce_a_count;

	public uint credit_reduce_b_count;

	public uint credit_reduce_c_count;

	public int compensation_points_reduce_rate_c;

	public int br_rank_points_reduce_rate_c;

	public int compensation_points_reduce_rate_d;

	public int br_rank_points_reduce_rate_d;

	public uint behavior_result_punishment_c;

	public uint behavior_result_punishment_d;

	public uint[] verbal_abuse_count_arr;

	public uint[] like_count_arr;

	public uint[] credit_reduce_count_arr;

	public int compensation_points_reduce_rate_a;

	public int br_rank_points_reduce_rate_a;

	public bool mic_off_b;

	public bool mic_off_c;

	public int br_rank_points_limit;

	public int compensation_points_limit;

	public bool ban_voice_d;

	public uint friendly_a_count;

	public uint[] friendly_a_count_arr;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
