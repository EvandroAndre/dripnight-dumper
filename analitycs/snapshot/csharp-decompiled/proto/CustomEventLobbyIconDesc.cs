using ProtoBuf;

namespace proto;

public class CustomEventLobbyIconDesc : IMessage
{
	public uint custom_event_id;

	public uint title;

	public uint icon_url;

	public string icon_effect;

	public string fly_effect;

	public uint banner_cdn;

	public uint banner_content;

	public string banner_appear_effect;

	public string banner_disappear_effect;

	public uint banner_duration;

	public string icon_sprite;

	public string banner_sprite;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
