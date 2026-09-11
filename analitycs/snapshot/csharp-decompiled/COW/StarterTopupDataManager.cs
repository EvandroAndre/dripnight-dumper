using System.Collections.Generic;
using GCommon;

namespace COW;

public class StarterTopupDataManager : SingletonModule<StarterTopupDataManager>
{
	private CSVAsyncDataMap<uint, StarterTopup> m_Dict;

	private List<CSVBaseData> m_List;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public List<CSVBaseData> GetStarterTopupDataList()
	{
		return null;
	}

	public override bool NeedResetCleanup()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedResetCleanup()
	{
		return false;
	}
}
