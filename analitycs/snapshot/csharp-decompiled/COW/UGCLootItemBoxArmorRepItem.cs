using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCLootItemBoxArmorRepItem
{
	public const int PROP_ID_LOOTARMOR = -139000;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnLootArmorChangeEvent;

	private int _003CLootArmor_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int LootArmor
	{
		get
		{
			return _003CLootArmor_003Ek__BackingField;
		}
		private set
		{
			_003CLootArmor_003Ek__BackingField = value;
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

	public UGCLootItemBoxArmorRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
