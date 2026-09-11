using System.Collections.Generic;

namespace proto;

public class CSCustomCardReleaseListRes
{
	public class releaseCardInfo
	{
		public ulong account_id;

		public uint card_id;

		public ulong ts_wish;

		public uint serial;

		public uint give_me_total;
	}

	public List<releaseCardInfo> infos;
}
