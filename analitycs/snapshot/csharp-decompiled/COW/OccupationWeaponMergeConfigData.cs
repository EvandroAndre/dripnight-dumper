using System.Collections.Generic;
using GCommon;

namespace COW;

public class OccupationWeaponMergeConfigData : SingletonModule<OccupationWeaponMergeConfigData>
{
	private List<OccupationWeaponMerge> m_OccupationWeaponMergeList;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public bool TryGetWeaponName(int id, out string name)
	{
		name = null;
		return false;
	}
}
