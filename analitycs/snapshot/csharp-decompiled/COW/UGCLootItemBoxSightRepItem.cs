using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCLootItemBoxSightRepItem
{
	public const int PROP_ID_LOOTSIGHT = -138000;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnLootSightChangeEvent;

	private int _003CLootSight_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int LootSight
	{
		get
		{
			return _003CLootSight_003Ek__BackingField;
		}
		private set
		{
			_003CLootSight_003Ek__BackingField = value;
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

	public UGCLootItemBoxSightRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
