using ProtoBuf;

namespace proto;

public class WebViewRegionalSettingsDesc : IMessage
{
	public string region;

	public string fallback_url;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
