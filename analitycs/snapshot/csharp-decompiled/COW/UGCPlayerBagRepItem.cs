using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCPlayerBagRepItem
{
	public const int PROP_ID_OWNER = -315000;

	public const int PROP_ID_MAXCAPACITY = -315001;

	public const int PROP_ID_CURCAPACITY = -315002;

	public const int PROP_ID_ALLITEMGOODSTYPE = -315003;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnOwnerChangeEvent;

	public Action<int> OnMaxCapacityChangeEvent;

	public Action<int> OnCurCapacityChangeEvent;

	public Action<List<object>> OnAllItemGoodsTypeChangeEvent;

	private string _003COwner_003Ek__BackingField;

	private int _003CMaxCapacity_003Ek__BackingField;

	private int _003CCurCapacity_003Ek__BackingField;

	private List<object> _003CAllItemGoodsType_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string Owner
	{
		get
		{
			return _003COwner_003Ek__BackingField;
		}
		private set
		{
			_003COwner_003Ek__BackingField = value;
		}
	}

	public int MaxCapacity
	{
		get
		{
			return _003CMaxCapacity_003Ek__BackingField;
		}
		private set
		{
			_003CMaxCapacity_003Ek__BackingField = value;
		}
	}

	public int CurCapacity
	{
		get
		{
			return _003CCurCapacity_003Ek__BackingField;
		}
		private set
		{
			_003CCurCapacity_003Ek__BackingField = value;
		}
	}

	public List<object> AllItemGoodsType
	{
		get
		{
			return _003CAllItemGoodsType_003Ek__BackingField;
		}
		private set
		{
			_003CAllItemGoodsType_003Ek__BackingField = value;
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

	public UGCPlayerBagRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
