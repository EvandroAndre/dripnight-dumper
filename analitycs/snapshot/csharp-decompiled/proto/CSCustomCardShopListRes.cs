using System.Collections.Generic;

namespace proto;

public class CSCustomCardShopListRes
{
	public class cardInfo
	{
		public uint card_id;

		public uint amount;
	}

	public List<cardInfo> cards;
}
