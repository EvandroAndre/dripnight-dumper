namespace tcp;

public class JoinGeneralChanNtf
{
	public ulong channel_id;

	public uint left_talk_times_default;

	public uint left_talk_times_fast;

	public uint daily_msg_limit_default;

	public uint daily_msg_limit_fast;

	public bool enable_custom_msg;

	public EChannel.ChannelType channel_type;
}
