using ProtoBuf;

namespace tcp;

public class AccountMicMuteTCP : IMessage
{
	public ulong account_id;

	public uint duration;

	public uint remaining_games;

	public bool is_match_result_notify;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
