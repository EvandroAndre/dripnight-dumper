using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCAmmoRepItem
{
	public const int PROP_ID_COUNT = -172000;

	public const int PROP_ID_AMMOTYPE = -172001;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnCountChangeEvent;

	public Action<int> OnAmmoTypeChangeEvent;

	private int _003CCount_003Ek__BackingField;

	private int _003CAmmoType_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int Count
	{
		get
		{
			return _003CCount_003Ek__BackingField;
		}
		private set
		{
			_003CCount_003Ek__BackingField = value;
		}
	}

	public int AmmoType
	{
		get
		{
			return _003CAmmoType_003Ek__BackingField;
		}
		private set
		{
			_003CAmmoType_003Ek__BackingField = value;
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

	public UGCAmmoRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
