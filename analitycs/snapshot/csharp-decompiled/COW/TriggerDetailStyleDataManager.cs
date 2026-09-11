using System.Collections.Generic;
using GCommon;

namespace COW;

public class TriggerDetailStyleDataManager : SingletonModule<TriggerDetailStyleDataManager>
{
	public Dictionary<uint, TriggerDetailStyleData> TriggerDetailDataDict;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public TriggerDetailStyleData GetTriggerDetailDataById(uint id)
	{
		return null;
	}
}
