using System.Collections.Generic;

namespace proto;

public class CSBatchGetResourceAuthorNameRes
{
	public class Detail
	{
		public ulong account_id;

		public string nickname;

		public uint head_pic;
	}

	public List<Detail> details;
}
