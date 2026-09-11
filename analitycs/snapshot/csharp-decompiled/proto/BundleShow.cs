using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class BundleShow : IMessage
{
	public uint id;

	public List<BundleShowData> bundles;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
