using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCLootItemBoxConsumableItemRepItem
{
	public const int PROP_ID_LOOTCONSUMABLEITEM = -136000;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnLootConsumableItemChangeEvent;

	private int _003CLootConsumableItem_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int LootConsumableItem
	{
		get
		{
			return _003CLootConsumableItem_003Ek__BackingField;
		}
		private set
		{
			_003CLootConsumableItem_003Ek__BackingField = value;
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

	public UGCLootItemBoxConsumableItemRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
