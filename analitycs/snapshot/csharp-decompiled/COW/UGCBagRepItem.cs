using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCBagRepItem
{
	public const int PROP_ID_EXTRABAGCAPACITY = -173000;

	public const int PROP_ID_PRIORITIZEPLAYERSKIN = -173001;

	public const int PROP_ID_SKINID = -173002;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnExtraBagCapacityChangeEvent;

	public Action<bool> OnPrioritizePlayerSkinChangeEvent;

	public Action<int> OnSkinIDChangeEvent;

	private int _003CExtraBagCapacity_003Ek__BackingField;

	private bool _003CPrioritizePlayerSkin_003Ek__BackingField;

	private int _003CSkinID_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int ExtraBagCapacity
	{
		get
		{
			return _003CExtraBagCapacity_003Ek__BackingField;
		}
		private set
		{
			_003CExtraBagCapacity_003Ek__BackingField = value;
		}
	}

	public bool PrioritizePlayerSkin
	{
		get
		{
			return _003CPrioritizePlayerSkin_003Ek__BackingField;
		}
		private set
		{
			_003CPrioritizePlayerSkin_003Ek__BackingField = value;
		}
	}

	public int SkinID
	{
		get
		{
			return _003CSkinID_003Ek__BackingField;
		}
		private set
		{
			_003CSkinID_003Ek__BackingField = value;
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

	public UGCBagRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
