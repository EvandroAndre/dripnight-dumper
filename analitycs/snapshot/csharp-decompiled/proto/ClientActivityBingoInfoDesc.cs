using ProtoBuf;

namespace proto;

public class ClientActivityBingoInfoDesc : IMessage
{
	public uint level;

	public uint key_id;

	public uint init_key_num;

	public uint cost_key_num;

	public uint cost_diamond;

	public long start_time;

	public long end_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
