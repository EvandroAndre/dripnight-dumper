using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSWebViewSettingDescRes : IMessage
{
	public List<WebViewSettingDesc> web_view_setting;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
