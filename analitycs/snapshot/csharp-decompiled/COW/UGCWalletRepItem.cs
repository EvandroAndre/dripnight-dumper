using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCWalletRepItem
{
	public const int PROP_ID_CONTENT = -90000;

	private UGCEntityDataStore _repDataMgr;

	public Action<List<object>> OnContentChangeEvent;

	private List<object> _003CContent_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public List<object> Content
	{
		get
		{
			return _003CContent_003Ek__BackingField;
		}
		private set
		{
			_003CContent_003Ek__BackingField = value;
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

	public UGCWalletRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
