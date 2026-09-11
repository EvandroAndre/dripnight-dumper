using System.Collections.Generic;

namespace proto;

public class CSGetBigEventTokenInfoRes
{
	public class TokenInfo
	{
		public uint token_id;

		public int token_total;
	}

	public List<TokenInfo> tokens;
}
