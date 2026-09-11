using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCLootItemBoxRepItem
{
	public const int PROP_ID_LOOTWEAPON = -60000;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnLootWeaponChangeEvent;

	private int _003CLootWeapon_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int LootWeapon
	{
		get
		{
			return _003CLootWeapon_003Ek__BackingField;
		}
		private set
		{
			_003CLootWeapon_003Ek__BackingField = value;
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

	public UGCLootItemBoxRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
