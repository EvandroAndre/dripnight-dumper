using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetPreviewWebDescRes : IMessage
{
	public List<PreviewWebDesc> preview_web_descs;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
