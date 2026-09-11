using ProtoBuf;

namespace proto;

public class GameplayFeedbackDesc : IMessage
{
	public uint game_mode;

	public uint[] match_modes;

	public uint question;

	public uint type;

	public long start_timestamp;

	public long end_timestamp;

	public uint[] delivery_ids;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
