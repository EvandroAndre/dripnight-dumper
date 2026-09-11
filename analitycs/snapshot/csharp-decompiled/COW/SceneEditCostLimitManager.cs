using System.Collections.Generic;
using GCommon;

namespace COW;

public class SceneEditCostLimitManager : SingletonModule<SceneEditCostLimitManager>
{
	private List<WorkshopCostLimitData> m_CostLimitDataList;

	protected override void OnInit()
	{
	}

	public WorkshopCostLimitData GetCurrentCostLimitData(float costPercent)
	{
		return null;
	}

	protected override void OnCleanup()
	{
	}
}
