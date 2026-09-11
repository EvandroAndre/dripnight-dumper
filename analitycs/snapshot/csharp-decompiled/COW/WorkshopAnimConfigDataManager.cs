using System.Collections.Generic;
using GCommon;

namespace COW;

internal class WorkshopAnimConfigDataManager : SingletonModule<WorkshopAnimConfigDataManager>
{
	private Dictionary<string, string> m_UGCAnimStateOverrideConfigs;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public string GetUGCAnimOverrideStateName(string stateName)
	{
		return null;
	}
}
