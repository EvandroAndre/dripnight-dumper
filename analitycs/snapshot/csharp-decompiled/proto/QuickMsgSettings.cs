using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class QuickMsgSettings : IMessage
{
	public uint voice;

	public List<QuickMsgModeSettings> mode_settings;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
