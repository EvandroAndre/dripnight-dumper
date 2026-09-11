using ProtoBuf;

namespace proto;

public class ChestLuckyRemindConfigDesc : IMessage
{
	public uint lucky_id;

	public uint type;

	public uint number;

	public float min_lucky;

	public float max_lucky;

	public string title;

	public string describe;

	public uint emoji_icon;

	public uint chest_type;

	public uint max_spins_number;

	public uint parameter_a;

	public uint parameter_b;

	public uint parameter_c;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
