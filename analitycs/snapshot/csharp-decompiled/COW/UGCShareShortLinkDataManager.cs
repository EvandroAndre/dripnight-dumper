using System.Collections.Generic;
using GCommon;

namespace COW;

public class UGCShareShortLinkDataManager : SingletonModule<UGCShareShortLinkDataManager>
{
	private Dictionary<string, Dictionary<string, Dictionary<string, string>>> m_Data;

	protected override void OnInit()
	{
	}

	public string GetUGCShareShortLinkMapping(string flag, string type, string original)
	{
		return null;
	}

	protected override void OnCleanup()
	{
	}
}
