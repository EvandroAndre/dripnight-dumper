using System.Collections.Generic;
using GCommon;

namespace COW;

public class WorkshopMapMailContentDataManager : SingletonModule<WorkshopMapMailContentDataManager>
{
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public uint id;

		internal bool _003CGetWorkshopMapMailDataByRewardId_003Eb__0(WorkshopMapMailContentData e)
		{
			return false;
		}
	}

	private List<WorkshopMapMailContentData> m_MapMailDataList;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public WorkshopMapMailContentData GetWorkshopMapMailDataByRewardId(uint id)
	{
		return null;
	}
}
