using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCLootItemBoxProjectileRepItem
{
	public const int PROP_ID_LOOTPROJECTILE = -137000;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnLootProjectileChangeEvent;

	private int _003CLootProjectile_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int LootProjectile
	{
		get
		{
			return _003CLootProjectile_003Ek__BackingField;
		}
		private set
		{
			_003CLootProjectile_003Ek__BackingField = value;
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

	public UGCLootItemBoxProjectileRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
