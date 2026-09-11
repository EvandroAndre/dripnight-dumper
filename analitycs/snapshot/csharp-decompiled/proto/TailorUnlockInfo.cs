using System.Collections.Generic;

namespace proto;

public class TailorUnlockInfo
{
	public class UnlockItem
	{
		public uint unlock_id;

		public bool unlock;

		public uint progress;

		public uint max_process;
	}

	public uint tailor_id;

	public bool base_unlock;

	public List<UnlockItem> unlock_items;
}
