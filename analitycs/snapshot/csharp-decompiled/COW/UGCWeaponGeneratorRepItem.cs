using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCWeaponGeneratorRepItem
{
	public const int PROP_ID_WEAPONTYPE = -176000;

	public const int PROP_ID_WEAPONSUBTYPE = -176001;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnWeaponTypeChangeEvent;

	public Action<int> OnWeaponSubTypeChangeEvent;

	private int _003CWeaponType_003Ek__BackingField;

	private int _003CWeaponSubType_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int WeaponType
	{
		get
		{
			return _003CWeaponType_003Ek__BackingField;
		}
		private set
		{
			_003CWeaponType_003Ek__BackingField = value;
		}
	}

	public int WeaponSubType
	{
		get
		{
			return _003CWeaponSubType_003Ek__BackingField;
		}
		private set
		{
			_003CWeaponSubType_003Ek__BackingField = value;
		}
	}

	public string UGCEntityID
	{
		get
		{
			return _003CUGCEntityID_003Ek__BackingField;
		}
		private set
		{
			_003CUGCEntityID_003Ek__BackingField = value;
		}
	}

	public UGCWeaponGeneratorRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
