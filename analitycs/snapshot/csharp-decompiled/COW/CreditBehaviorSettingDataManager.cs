using System.Collections.Generic;
using GCommon;

namespace COW;

public class CreditBehaviorSettingDataManager : SingletonModule<CreditBehaviorSettingDataManager>
{
	private Dictionary<uint, CreditBehaviorSettingData> m_CreditBehaviorSettingDataMap;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public CreditBehaviorSettingData GetCreditBehaviorSettingData(uint behaviorID)
	{
		return null;
	}
}
