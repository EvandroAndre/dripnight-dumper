using System.Collections.Generic;

namespace proto;

public class CSCustomCardReceiveListRes
{
	public class receiveCardInfo
	{
		public ulong account_id;

		public uint card_id;

		public uint serial;
	}

	public List<receiveCardInfo> infos;
}
