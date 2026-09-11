using System.Collections.Generic;
using GCommon;

namespace COW;

public class ReplayAIClassifyConfigData : SingletonModule<ReplayAIClassifyConfigData>
{
	private List<ReplayAIClassify> m_ReplayAIClassifyList;

	private Dictionary<uint, List<ReplayAIClassify>> m_ReplayAIClassifyTypeDict;

	private Dictionary<uint, ReplayAIClassify> m_ReplayAIClassifyIDDict;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public ReplayAIClassify GetReplayAIClassifyByID(uint id)
	{
		return null;
	}

	public List<ReplayAIClassify> GetDataByType(uint type)
	{
		return null;
	}
}
