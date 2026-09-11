using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCBatchCombineRenderRepItem
{
	public const int PROP_ID_RESUUID = -366000;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnResUUIDChangeEvent;

	private string _003CResUUID_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string ResUUID
	{
		get
		{
			return _003CResUUID_003Ek__BackingField;
		}
		private set
		{
			_003CResUUID_003Ek__BackingField = value;
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

	public UGCBatchCombineRenderRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
