using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCItemGeneratorRepItem
{
	public const int PROP_ID_ITEMID = -187000;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnItemIDChangeEvent;

	private int _003CItemID_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int ItemID
	{
		get
		{
			return _003CItemID_003Ek__BackingField;
		}
		private set
		{
			_003CItemID_003Ek__BackingField = value;
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

	public UGCItemGeneratorRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
