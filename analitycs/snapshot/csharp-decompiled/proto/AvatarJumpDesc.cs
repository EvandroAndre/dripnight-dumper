using ProtoBuf;

namespace proto;

public class AvatarJumpDesc : IMessage
{
	public uint sort_id;

	public uint avatar_id;

	public string language;

	public string skill_jump_url;

	public string video_jump_url;

	public string training;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
