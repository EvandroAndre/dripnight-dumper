using ProtoBuf;

namespace proto;

public class WishSettingDesc : IMessage
{
	public string region;

	public bool is_open;

	public uint wish_max;

	public uint end_time;

	public bool is_show_wish_value;

	public bool is_open_ranking;

	public uint ranking_number;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
