using ProtoBuf;

namespace proto;

public class SharedGachaCollectRewardDesc : IMessage
{
	public uint chest_id;

	public uint chest_sub_id;

	public uint unique_id;

	public uint[] req_item_id;

	public uint award_type;

	public uint award_id;

	public uint award_num;

	public uint award_time;

	public uint limited_times;

	public uint owned_change_item_type;

	public uint owned_change_item_id;

	public uint owned_change_item_num;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
