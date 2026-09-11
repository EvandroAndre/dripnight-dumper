using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCPlayablePosFollowRepItem
{
	public const int PROP_ID_SELFENTITY = -212000;

	public const int PROP_ID_TARGETENTITY = -212001;

	public const int PROP_ID_OFFSET = -212002;

	public const int PROP_ID_COORDINATETYPE = -212003;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnSelfEntityChangeEvent;

	public Action<string> OnTargetEntityChangeEvent;

	public Action<Vector3> OnOffsetChangeEvent;

	public Action<int> OnCoordinateTypeChangeEvent;

	private string _003CSelfEntity_003Ek__BackingField;

	private string _003CTargetEntity_003Ek__BackingField;

	private Vector3 _003COffset_003Ek__BackingField;

	private int _003CCoordinateType_003Ek__BackingField;

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

	public UGCPlayablePosFollowRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
