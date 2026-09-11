using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCPlayableLookAtRepItem
{
	public const int PROP_ID_SELFENTITY = -213000;

	public const int PROP_ID_TARGETENTITY = -213001;

	public const int PROP_ID_OFFSET = -213002;

	public const int PROP_ID_COORDINATETYPE = -213003;

	public const int PROP_ID_FORCESYNCVALUE = -213004;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnSelfEntityChangeEvent;

	public Action<string> OnTargetEntityChangeEvent;

	public Action<Vector3> OnOffsetChangeEvent;

	public Action<int> OnCoordinateTypeChangeEvent;

	public Action<Vector3> OnForceSyncValueChangeEvent;

	private string _003CSelfEntity_003Ek__BackingField;

	private string _003CTargetEntity_003Ek__BackingField;

	private Vector3 _003COffset_003Ek__BackingField;

	private int _003CCoordinateType_003Ek__BackingField;

	private Vector3 _003CForceSyncValue_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string SelfEntity
	{
		get
		{
			return _003CSelfEntity_003Ek__BackingField;
		}
		private set
		{
			_003CSelfEntity_003Ek__BackingField = value;
		}
	}

	public string TargetEntity
	{
		get
		{
			return _003CTargetEntity_003Ek__BackingField;
		}
		private set
		{
			_003CTargetEntity_003Ek__BackingField = value;
		}
	}

	public Vector3 Offset
	{
		get
		{
			return _003COffset_003Ek__BackingField;
		}
		private set
		{
			_003COffset_003Ek__BackingField = value;
		}
	}

	public int CoordinateType
	{
		get
		{
			return _003CCoordinateType_003Ek__BackingField;
		}
		private set
		{
			_003CCoordinateType_003Ek__BackingField = value;
		}
	}

	public Vector3 ForceSyncValue
	{
		get
		{
			return _003CForceSyncValue_003Ek__BackingField;
		}
		private set
		{
			_003CForceSyncValue_003Ek__BackingField = value;
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

	public UGCPlayableLookAtRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
