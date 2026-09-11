namespace tcp;

public class JoinFreshChanNtf
{
	public ulong channel_id;

	public uint left_talk_times_default;

	public uint daily_msg_limit_default;

	public uint left_talk_times_fast;

	public uint daily_msg_limit_fast;

	public bool enable_custom_msg;

	public uint level_limit;

	public bool unbind_limit;
}
