using System.Collections.Generic;

namespace proto;

public class CSBatchGetWorkshopBasicInfoByCodesRes
{
	public class WorkshopBasicInfoWithState
	{
		public EWorkshop.SlotState state;

		public WorkshopBasicInfo info;
	}

	public List<WorkshopBasicInfoWithState> infos;
}
