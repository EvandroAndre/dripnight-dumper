using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetIAPStoreDescRes : IMessage
{
	public List<IAPStoreDesc> iap_store_desc;

	public ClientStoreDesc store_desc;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
