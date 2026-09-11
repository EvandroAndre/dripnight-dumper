using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCTeleportDoorRepItem
{
	public const int PROP_ID_ISAUTOTELEPORT = -57000;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnIsAutoTeleportChangeEvent;

	private bool _003CIsAutoTeleport_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public bool IsAutoTeleport
	{
		get
		{
			return _003CIsAutoTeleport_003Ek__BackingField;
		}
		private set
		{
			_003CIsAutoTeleport_003Ek__BackingField = value;
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

	public UGCTeleportDoorRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
