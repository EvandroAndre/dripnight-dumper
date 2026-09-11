using System.Collections.Generic;
using GCommon;

namespace COW;

public class OccupationSettingManagaer : SingletonModule<OccupationSettingManagaer>
{
	private CSVAsyncDataMap<uint, OccupationSettingData> m_Ob47OccupationSettingData;

	private Dictionary<uint, int> m_WeaponModifyInfo;

	private Dictionary<uint, int> WeaponModifyInfoDict => null;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public override bool NeedResetCleanup()
	{
		return false;
	}

	private void LoadWeaponModifyInfo()
	{
	}

	public int GetWeaponModifyType(uint weaponID, int weaponType)
	{
		return 0;
	}

	public bool _003C_003EiFixBaseProxy_NeedResetCleanup()
	{
		return false;
	}
}
