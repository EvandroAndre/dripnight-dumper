using System.Collections.Generic;
using GCommon;

namespace COW;

public class WeaponTermDataManager : SingletonModule<WeaponTermDataManager>
{
	public Dictionary<uint, WeaponTermConfig> m_WeaponTermConfigs;

	protected override void OnInit()
	{
	}

	public WeaponTermConfig GetDataById(uint id)
	{
		return null;
	}

	protected override void OnCleanup()
	{
	}
}
