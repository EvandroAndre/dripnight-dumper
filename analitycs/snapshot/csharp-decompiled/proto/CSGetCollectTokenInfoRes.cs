using System.Collections.Generic;

namespace proto;

public class CSGetCollectTokenInfoRes
{
	public List<LdcpTokenDesc> desc;

	public uint collected_tokens;
}
