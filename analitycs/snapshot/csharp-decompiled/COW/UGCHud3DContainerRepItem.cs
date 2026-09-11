using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCHud3DContainerRepItem
{
	public const int PROP_ID_RESOURCEID = -300000;

	public const int PROP_ID_SCALE = -300001;

	public const int PROP_ID_ROTATION = -300002;

	public const int PROP_ID_PREFABENTITY = -300003;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnResourceIDChangeEvent;

	public Action<Vector3> OnScaleChangeEvent;

	public Action<Vector3> OnRotationChangeEvent;

	public Action<string> OnPrefabEntityChangeEvent;

	private string _003CResourceID_003Ek__BackingField;

	private Vector3 _003CScale_003Ek__BackingField;

	private Vector3 _003CRotation_003Ek__BackingField;

	private string _003CPrefabEntity_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string ResourceID
	{
		get
		{
			return _003CResourceID_003Ek__BackingField;
		}
		private set
		{
			_003CResourceID_003Ek__BackingField = value;
		}
	}

	public Vector3 Scale
	{
		get
		{
			return _003CScale_003Ek__BackingField;
		}
		private set
		{
			_003CScale_003Ek__BackingField = value;
		}
	}

	public Vector3 Rotation
	{
		get
		{
			return _003CRotation_003Ek__BackingField;
		}
		private set
		{
			_003CRotation_003Ek__BackingField = value;
		}
	}

	public string PrefabEntity
	{
		get
		{
			return _003CPrefabEntity_003Ek__BackingField;
		}
		private set
		{
			_003CPrefabEntity_003Ek__BackingField = value;
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

	public UGCHud3DContainerRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
