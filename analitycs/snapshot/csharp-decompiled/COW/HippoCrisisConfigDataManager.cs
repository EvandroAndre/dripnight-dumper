using System.Collections.Generic;
using GCommon;

namespace COW;

public class HippoCrisisConfigDataManager : SingletonModule<HippoCrisisConfigDataManager>
{
	private CSVAsyncDataMap<uint, HippoCrisisPreStartConditionData> m_HippoCrisisPrestartConditionDataDic;

	private Dictionary<uint, List<HippoCrisisPreSetData>> m_HippoCrisisPresetBundleDic;

	private Dictionary<uint, uint> m_HippoCrisisPrestartConditionAmmoLimit;

	private uint m_DefaultLimit;

	public Dictionary<uint, List<HippoCrisisPreSetData>> HippoCrisisPresetBundleDic => null;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public HippoCrisisPreStartConditionData GetHippoCrisisPreStartConditionDataById(uint id)
	{
		return null;
	}

	public void LoadRecommendPreSet(List<CSVBaseData> bundleData)
	{
	}

	private void ProcessPrestartContionData()
	{
	}

	public uint GetHippoCrisisPrestartConditionAmmoLimit(uint id)
	{
		return 0u;
	}
}
