using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCBuffGenRepItem
{
	public const int PROP_ID_BUFFGENTYPE = -58000;

	public const int PROP_ID_BUFFGENTIME = -58001;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnBuffGenTypeChangeEvent;

	public Action<int> OnBuffGenTimeChangeEvent;

	private int _003CBuffGenType_003Ek__BackingField;

	private int _003CBuffGenTime_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int BuffGenType
	{
		get
		{
			return _003CBuffGenType_003Ek__BackingField;
		}
		private set
		{
			_003CBuffGenType_003Ek__BackingField = value;
		}
	}

	public int BuffGenTime
	{
		get
		{
			return _003CBuffGenTime_003Ek__BackingField;
		}
		private set
		{
			_003CBuffGenTime_003Ek__BackingField = value;
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

	public UGCBuffGenRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
