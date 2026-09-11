using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class WorkShopLevelExpDataManager : SingletonModule<WorkShopLevelExpDataManager>
{
	private List<WorkShopLevelExp> m_WorkShopLevelExpList;

	private uint m_MaxLevel;

	protected override void OnInit()
	{
	}

	public void ApplyServerData(List<WorkshopLevelExpDesc> res)
	{
	}

	public List<WorkShopLevelExp> GetWorkShopLevelExpList()
	{
		return null;
	}

	protected override void OnCleanup()
	{
	}

	public bool CheckLevelIsMax(uint exp)
	{
		return false;
	}

	public WorkShopLevelExp GetDataByLevel(uint level)
	{
		return null;
	}

	public void GetLevelByExp(uint exp, out uint level1, out uint nextexp)
	{
		level1 = default(uint);
		nextexp = default(uint);
	}

	public WorkShopLevelExp GetMaxLevelData()
	{
		return null;
	}

	private void LoadLocalData()
	{
	}

	private int CompareLevelExp(WorkShopLevelExp a, WorkShopLevelExp b)
	{
		return 0;
	}

	private void RebuildLevelCache()
	{
	}

	private void ApplyDisplayData(WorkShopLevelExp data, WorkshopLevelExpDesc desc)
	{
	}

	private void ApplyAwards(WorkShopLevelExp data, List<ExchangedAward> awards)
	{
	}

	private void ApplyAward(WorkShopLevelExp data, int index, ExchangedAward award)
	{
	}
}
