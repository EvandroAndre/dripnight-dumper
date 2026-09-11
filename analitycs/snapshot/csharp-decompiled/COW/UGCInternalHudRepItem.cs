using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCInternalHudRepItem
{
	public const int PROP_ID_DEPTH = -21000;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnDepthChangeEvent;

	private int _003CDepth_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int Depth
	{
		get
		{
			return _003CDepth_003Ek__BackingField;
		}
		private set
		{
			_003CDepth_003Ek__BackingField = value;
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

	public UGCInternalHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
