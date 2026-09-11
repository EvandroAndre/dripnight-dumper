using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCLoopableRepItem
{
	public const int PROP_ID_ISLOOP = -332000;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnIsLoopChangeEvent;

	private int _003CIsLoop_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int IsLoop
	{
		get
		{
			return _003CIsLoop_003Ek__BackingField;
		}
		private set
		{
			_003CIsLoop_003Ek__BackingField = value;
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

	public UGCLoopableRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
