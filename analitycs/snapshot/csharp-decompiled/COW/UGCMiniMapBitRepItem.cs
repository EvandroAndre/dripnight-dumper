using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCMiniMapBitRepItem
{
	public const int PROP_ID_TARGET = -278000;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnTargetChangeEvent;

	private string _003CTarget_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string Target
	{
		get
		{
			return _003CTarget_003Ek__BackingField;
		}
		private set
		{
			_003CTarget_003Ek__BackingField = value;
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

	public UGCMiniMapBitRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
