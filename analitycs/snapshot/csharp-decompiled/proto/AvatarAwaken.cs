using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class AvatarAwaken : IMessage
{
	public uint awaken_avatar_id;

	public uint original_avatar_id;

	public string awaken_cdn;

	public string unlock_time;

	public List<AwardDesc> awards;

	public string awaken_description;

	public string awaken_title;

	public string go_pos;

	public string end_time;

	public bool is_new;

	public string awaken_key_art_cdn;

	public long unlock_timestamp;

	public long end_timestamp;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
