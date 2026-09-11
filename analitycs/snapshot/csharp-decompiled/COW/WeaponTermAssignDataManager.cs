using System.Collections.Generic;
using GCommon;

namespace COW;

public class WeaponTermAssignDataManager : SingletonModule<WeaponTermAssignDataManager>
{
	public Dictionary<uint, WeaponTermAssignData> m_WeaponTermAssignDatas;

	protected override void OnInit()
	{
	}

	public WeaponTermAssignData GetDataById(uint id)
	{
		return null;
	}

	protected override void OnCleanup()
	{
	}
}
