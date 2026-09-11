using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetVeteranStoreDescRes : IMessage
{
	public List<VeteranStoreDesc> veteran_stores;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
