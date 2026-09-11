using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCColliderRepItem
{
	public const int PROP_ID_COLLIDABLE = -165000;

	public const int PROP_ID_ISTRIGGER = -165001;

	public const int PROP_ID_PHYSICALLAYER = -165002;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnCollidableChangeEvent;

	public Action<bool> OnIsTriggerChangeEvent;

	public Action<int> OnPhysicalLayerChangeEvent;

	private bool _003CCollidable_003Ek__BackingField;

	private bool _003CIsTrigger_003Ek__BackingField;

	private int _003CPhysicalLayer_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public bool Collidable
	{
		get
		{
			return _003CCollidable_003Ek__BackingField;
		}
		private set
		{
			_003CCollidable_003Ek__BackingField = value;
		}
	}

	public bool IsTrigger
	{
		get
		{
			return _003CIsTrigger_003Ek__BackingField;
		}
		private set
		{
			_003CIsTrigger_003Ek__BackingField = value;
		}
	}

	public int PhysicalLayer
	{
		get
		{
			return _003CPhysicalLayer_003Ek__BackingField;
		}
		private set
		{
			_003CPhysicalLayer_003Ek__BackingField = value;
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

	public UGCColliderRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
