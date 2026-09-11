using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetBundleRes : IMessage
{
	public List<BundleShow> bundle_show;

	public List<BundleUpdateLocalDesc> bundle_update_locals;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
