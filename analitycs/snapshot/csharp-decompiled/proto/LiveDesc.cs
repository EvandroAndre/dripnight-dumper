using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class LiveDesc : IMessage
{
	public uint id;

	public string tab_name;

	public string web_link;

	public List<LivePopupDesc> live_popup;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
