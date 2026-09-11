using ProtoBuf;

namespace proto;

public class CSGetHideAvatarRes : IMessage
{
	public uint[] avatar_id;

	public uint[] ip_expired_avatar_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
