using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCSprayGunComponentRepItem
{
	public const int PROP_ID_SPRAYCOLOR = -238000;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnSprayColorChangeEvent;

	private int _003CSprayColor_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int SprayColor
	{
		get
		{
			return _003CSprayColor_003Ek__BackingField;
		}
		private set
		{
			_003CSprayColor_003Ek__BackingField = value;
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

	public UGCSprayGunComponentRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
