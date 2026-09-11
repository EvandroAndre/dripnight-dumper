using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSShareSettingDescRes : IMessage
{
	public List<ShareSettingDesc> share_settings;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
