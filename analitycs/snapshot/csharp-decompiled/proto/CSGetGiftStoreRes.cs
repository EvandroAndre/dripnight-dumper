using ProtoBuf;

namespace proto;

public class CSGetGiftStoreRes : IMessage
{
	public uint store_id;

	public uint open_time;

	public uint close_time;

	public bool is_time_show;

	public uint giver_level;

	public uint receiver_level;

	public uint gift_time_limited;

	public uint gift_num_limited;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
