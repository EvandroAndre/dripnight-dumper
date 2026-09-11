using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class OptionalBundleShow : IMessage
{
	public uint id;

	public List<OptionalBundleShowData> bundles;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
