using ProtoBuf;

namespace proto;

public class AntiAddictionBRCommonConfigDesc : IMessage
{
	public long play_time_min_limit;

	public long play_time_max_limit;

	public string hint_key;

	public uint hint_key_time;

	public uint parental_control_apply_cold_time;

	public uint max_child;

	public uint max_apply_limit;

	public string quit_key;

	public uint verifying_age_index;

	public uint skip_age_index;

	public uint refresh_cd;

	public uint active_refresh_cd;

	public uint cool_down_time;

	public uint twice_cool_down_time;

	public string web_link;

	public uint log_interval_seconds;

	public uint log_max_adults_limit;

	public uint re_auth_cd;

	public bool unverified_comms_switch;

	public bool enable_new_age_verify_flow;

	public bool enable_platform_age_verify_api;

	public bool age_verify_priority;

	public uint platform_verify_fail_strategy;

	public bool enable_age_verify_retry;

	public uint max_age_verify_retry_count;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
