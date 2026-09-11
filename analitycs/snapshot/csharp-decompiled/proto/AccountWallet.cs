using ProtoBuf;

namespace proto;

public class AccountWallet : IMessage
{
	public uint coins;

	public int gems;

	public uint gop_gems;

	public ulong total_topup;

	public long last_topup_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
