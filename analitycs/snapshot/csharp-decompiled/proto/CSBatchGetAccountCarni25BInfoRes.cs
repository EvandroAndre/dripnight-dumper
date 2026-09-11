using System.Collections.Generic;

namespace proto;

public class CSBatchGetAccountCarni25BInfoRes
{
	public class AccountCarni25BInfo
	{
		public ulong account_id;

		public uint fan_level;

		public List<Carni25BEvent> events;

		public List<Carni25BEvent> consume_events;
	}

	public List<AccountCarni25BInfo> account_infos;
}
