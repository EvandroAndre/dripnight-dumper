using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCLootItemBoxSoccerRepItem
{
	public const int PROP_ID_LOOTSOCCER = -142000;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnLootSoccerChangeEvent;

	private int _003CLootSoccer_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int LootSoccer
	{
		get
		{
			return _003CLootSoccer_003Ek__BackingField;
		}
		private set
		{
			_003CLootSoccer_003Ek__BackingField = value;
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

	public UGCLootItemBoxSoccerRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
