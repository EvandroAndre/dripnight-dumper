using System.Collections.Generic;

namespace proto;

public class CSBatchGetAccountFlame25BInfoRes
{
	public class AccountFlame25BInfo
	{
		public ulong account_id;

		public Flame25BPublicAccountInfo info;
	}

	public List<AccountFlame25BInfo> account_infos;
}
