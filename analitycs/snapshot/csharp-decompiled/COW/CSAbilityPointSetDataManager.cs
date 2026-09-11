using System.Collections.Generic;
using GCommon;

namespace COW;

public class CSAbilityPointSetDataManager : SingletonModule<CSAbilityPointSetDataManager>
{
	public Dictionary<uint, CSAbilityPointSetData> m_CSAbilityPointSetDataDic;

	protected override void OnInit()
	{
	}

	public CSAbilityPointSetData GetDataById(uint id)
	{
		return null;
	}

	protected override void OnCleanup()
	{
	}
}
