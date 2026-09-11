using System.Collections.Generic;
using GCommon;

namespace COW;

public class HDFireEffectDataManager : SingletonModule<HDFireEffectDataManager>
{
	private Dictionary<uint, HDFireEffectData> m_HDFireEffectDic;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public ResourceID GetEffectIndexByRandom(uint weaponType, float num)
	{
		return default(ResourceID);
	}

	private int CalculateIndex(List<float> list, float num)
	{
		return 0;
	}
}
