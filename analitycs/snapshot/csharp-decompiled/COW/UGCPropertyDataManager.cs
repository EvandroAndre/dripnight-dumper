using System.Collections.Generic;
using GCommon;

namespace COW;

public class UGCPropertyDataManager : SingletonModule<UGCPropertyDataManager>
{
	private Dictionary<string, HashSet<string>> m_TypeProperyHiddenDic;

	protected override void OnInit()
	{
	}

	public bool IsPropertyHidden(string typeName, string propertyName)
	{
		return false;
	}

	protected override void OnCleanup()
	{
	}
}
