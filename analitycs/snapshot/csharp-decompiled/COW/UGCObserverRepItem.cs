using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCObserverRepItem
{
	public const int PROP_ID_CUSTOMCAMERA = -462000;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnCustomCameraChangeEvent;

	private string _003CCustomCamera_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string CustomCamera
	{
		get
		{
			return _003CCustomCamera_003Ek__BackingField;
		}
		private set
		{
			_003CCustomCamera_003Ek__BackingField = value;
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

	public UGCObserverRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
