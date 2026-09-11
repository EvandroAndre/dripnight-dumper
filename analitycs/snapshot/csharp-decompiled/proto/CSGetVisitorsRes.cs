using System.Collections.Generic;

namespace proto;

public class CSGetVisitorsRes
{
	public class VisitorRecord
	{
		public AccountInfoBasic info;

		public long visit_at;

		public bool liked;
	}

	public List<VisitorRecord> visitors;

	public uint total_num;

	public uint today_num;
}
