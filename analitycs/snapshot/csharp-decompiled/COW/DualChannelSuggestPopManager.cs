using System.Collections.Generic;
using GCommon;

namespace COW;

public class DualChannelSuggestPopManager : SingletonModule<DualChannelSuggestPopManager>
{
	private Dictionary<string, DualChannelSuggestPopData> m_dicData;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public DualChannelSuggestPopData GetData(string info)
	{
		return null;
	}
}
