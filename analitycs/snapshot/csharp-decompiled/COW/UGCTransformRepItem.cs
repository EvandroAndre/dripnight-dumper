using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCTransformRepItem
{
	public const int PROP_ID_POSITION = -97000;

	public const int PROP_ID_ROTATION = -97001;

	public const int PROP_ID_SCALE = -97002;

	public const int PROP_ID_PARENT = -97003;

	public const int PROP_ID_ROTATIONQ = -97004;

	public const int PROP_ID_LOCALPOSITION = -97005;

	public const int PROP_ID_LOCALROTATIONQ = -97006;

	public const int PROP_ID_LOCALROTATION = -97007;

	public const int PROP_ID_LOCALSCALE = -97008;

	public const int PROP_ID_UP = -97009;

	public const int PROP_ID_RIGHT = -97010;

	public const int PROP_ID_FORWARD = -97011;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnParentChangeEvent;

	public Action<Vector3> OnLocalPositionChangeEvent;

	public Action<Quaternion> OnLocalRotationQChangeEvent;

	public Action<Vector3> OnLocalScaleChangeEvent;

	public Action<Vector3> OnUpChangeEvent;

	public Action<Vector3> OnRightChangeEvent;

	public Action<Vector3> OnForwardChangeEvent;

	private string _003CParent_003Ek__BackingField;

	private Vector3 _003CLocalPosition_003Ek__BackingField;

	private Quaternion _003CLocalRotationQ_003Ek__BackingField;

	private Vector3 _003CLocalScale_003Ek__BackingField;

	private Vector3 _003CUp_003Ek__BackingField;

	private Vector3 _003CRight_003Ek__BackingField;

	private Vector3 _003CForward_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string Parent
	{
		get
		{
			return _003CParent_003Ek__BackingField;
		}
		private set
		{
			_003CParent_003Ek__BackingField = value;
		}
	}

	public Vector3 LocalPosition
	{
		get
		{
			return _003CLocalPosition_003Ek__BackingField;
		}
		private set
		{
			_003CLocalPosition_003Ek__BackingField = value;
		}
	}

	public Quaternion LocalRotationQ
	{
		get
		{
			return _003CLocalRotationQ_003Ek__BackingField;
		}
		private set
		{
			_003CLocalRotationQ_003Ek__BackingField = value;
		}
	}

	public Vector3 LocalScale
	{
		get
		{
			return _003CLocalScale_003Ek__BackingField;
		}
		private set
		{
			_003CLocalScale_003Ek__BackingField = value;
		}
	}

	public Vector3 Up
	{
		get
		{
			return _003CUp_003Ek__BackingField;
		}
		private set
		{
			_003CUp_003Ek__BackingField = value;
		}
	}

	public Vector3 Right
	{
		get
		{
			return _003CRight_003Ek__BackingField;
		}
		private set
		{
			_003CRight_003Ek__BackingField = value;
		}
	}

	public Vector3 Forward
	{
		get
		{
			return _003CForward_003Ek__BackingField;
		}
		private set
		{
			_003CForward_003Ek__BackingField = value;
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

	public UGCTransformRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
