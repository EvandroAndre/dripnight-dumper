using ProtoBuf;

namespace proto;

public class WebViewSettingDesc : IMessage
{
	public uint id;

	public string url;

	public bool use_web_page;

	public bool hardware_acceleration;

	public string mod_user_agent;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
