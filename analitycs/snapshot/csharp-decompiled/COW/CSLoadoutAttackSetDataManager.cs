using System.Collections.Generic;
using GCommon;

namespace COW;

public class CSLoadoutAttackSetDataManager : SingletonModule<CSLoadoutAttackSetDataManager>
{
	public Dictionary<uint, CSLoadoutAttackSetData> m_CSLoadoutAttackSetDataDic;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public CSLoadoutAttackSetData GetDataById(uint id)
	{
		return null;
	}

	public CSLoadoutAttackSetData GetDataByItemId(uint itemId)
	{
		return null;
	}

	public CSLoadoutAttackSetData GetRelatedDataByItemId(uint itemId)
	{
		return null;
	}

	public CSLoadoutAttackSetData GetRelatedDataByReplacerItemId(uint replacerItemId)
	{
		return null;
	}

	public bool IsSameReinforceData(uint itemIdA, uint itemIdB)
	{
		return false;
	}

	public uint GetReinforceCostTokenByItemId(uint itemId, uint curReinforceCount)
	{
		return 0u;
	}
}
