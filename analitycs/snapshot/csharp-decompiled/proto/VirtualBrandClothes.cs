using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class VirtualBrandClothes : IMessage
{
	public uint brand_id;

	public List<VirtualBrandClothesDesc> clothes;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
