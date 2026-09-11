using System.Collections.Generic;
using GCommon;

namespace COW;

public class CompatibleLoginBlackListDataManager : SingletonModule<CompatibleLoginBlackListDataManager>
{
	private HashSet<string> m_BlackListNavigationNames;

	private HashSet<string> BlackListNavigationNames => null;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public bool NavigationCanAccess(string navigationName)
	{
		return false;
	}

	public bool IsInBlackList(string name = null)
	{
		return false;
	}
}
