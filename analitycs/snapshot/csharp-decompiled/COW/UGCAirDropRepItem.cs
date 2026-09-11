using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCAirDropRepItem
{
	public const int PROP_ID_DROPITEMS = -356000;

	public const int PROP_ID_STARTDROPTIME = -356001;

	public const int PROP_ID_AIRDROPSTATE = -356002;

	private UGCEntityDataStore _repDataMgr;

	public Action<Dictionary<object, object>> OnDropItemsChangeEvent;

	public Action<int> OnStartDropTimeChangeEvent;

	public Action<int> OnAirDropStateChangeEvent;

	private Dictionary<object, object> _003CDropItems_003Ek__BackingField;

	private int _003CStartDropTime_003Ek__BackingField;

	private int _003CAirDropState_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public Dictionary<object, object> DropItems
	{
		get
		{
			return _003CDropItems_003Ek__BackingField;
		}
		private set
		{
			_003CDropItems_003Ek__BackingField = value;
		}
	}

	public int StartDropTime
	{
		get
		{
			return _003CStartDropTime_003Ek__BackingField;
		}
		private set
		{
			_003CStartDropTime_003Ek__BackingField = value;
		}
	}

	public int AirDropState
	{
		get
		{
			return _003CAirDropState_003Ek__BackingField;
		}
		private set
		{
			_003CAirDropState_003Ek__BackingField = value;
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

	public UGCAirDropRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
