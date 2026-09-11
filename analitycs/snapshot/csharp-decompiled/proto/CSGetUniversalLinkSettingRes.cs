using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetUniversalLinkSettingRes : IMessage
{
	public List<UniversalLinkSettingDesc> universal_link_settings;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
