using ProtoBuf;

namespace proto;

public class PrimeStoreDesc : IMessage
{
	public uint store_id;

	public long start_timestamp;

	public long end_timestamp;

	public uint giver_level;

	public uint receiver_level;

	public uint gift_time_limited;

	public uint gift_num_limited;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
