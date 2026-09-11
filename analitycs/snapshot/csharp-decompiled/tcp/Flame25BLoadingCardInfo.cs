using ProtoBuf;

namespace tcp;

public class Flame25BLoadingCardInfo : IMessage
{
	public uint flame_level;

	public uint choose_clan_id;

	public uint cur_progress;

	public string role_cdn_url;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
