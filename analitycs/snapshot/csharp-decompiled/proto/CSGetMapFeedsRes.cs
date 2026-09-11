using System.Collections.Generic;

namespace proto;

public class CSGetMapFeedsRes
{
	public class WorkshopInfoWithQuality
	{
		public WorkshopBasicInfo info;

		public string quality;
	}

	public List<WorkshopInfoWithQuality> infos;

	public List<string> index;

	public bool has_more;

	public string strategy;
}
