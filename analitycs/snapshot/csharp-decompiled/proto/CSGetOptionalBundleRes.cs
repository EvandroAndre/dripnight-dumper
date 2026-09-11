using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetOptionalBundleRes : IMessage
{
	public List<OptionalBundleShow> optional_bundle_show;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
