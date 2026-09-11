using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCProjectileTrajectoryRepItem
{
	public const int PROP_ID_STARTPOINT = -458000;

	public const int PROP_ID_INITIALVELOCITY = -458001;

	public const int PROP_ID_CUSTOMGRAVITY = -458002;

	public const int PROP_ID_DRAGCOEFFICIENT = -458003;

	public const int PROP_ID_ACCELERATION = -458004;

	public const int PROP_ID_DURATIONTIMEMS = -458005;

	public const int PROP_ID_LAYERMASK = -458006;

	public const int PROP_ID_CUSTOMMATERIAL = -458007;

	public const int PROP_ID_WIDTH = -458008;

	private UGCEntityDataStore _repDataMgr;

	public Action<Vector3> OnStartPointChangeEvent;

	public Action<Vector3> OnInitialVelocityChangeEvent;

	public Action<float> OnCustomGravityChangeEvent;

	public Action<float> OnDragCoefficientChangeEvent;

	public Action<Vector3> OnAccelerationChangeEvent;

	public Action<int> OnDurationTimeMSChangeEvent;

	public Action<List<object>> OnLayerMaskChangeEvent;

	public Action<string> OnCustomMaterialChangeEvent;

	public Action<float> OnWidthChangeEvent;

	private Vector3 _003CStartPoint_003Ek__BackingField;

	private Vector3 _003CInitialVelocity_003Ek__BackingField;

	private float _003CCustomGravity_003Ek__BackingField;

	private float _003CDragCoefficient_003Ek__BackingField;

	private Vector3 _003CAcceleration_003Ek__BackingField;

	private int _003CDurationTimeMS_003Ek__BackingField;

	private List<object> _003CLayerMask_003Ek__BackingField;

	private string _003CCustomMaterial_003Ek__BackingField;

	private float _003CWidth_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public Vector3 StartPoint
	{
		get
		{
			return _003CStartPoint_003Ek__BackingField;
		}
		private set
		{
			_003CStartPoint_003Ek__BackingField = value;
		}
	}

	public Vector3 InitialVelocity
	{
		get
		{
			return _003CInitialVelocity_003Ek__BackingField;
		}
		private set
		{
			_003CInitialVelocity_003Ek__BackingField = value;
		}
	}

	public float CustomGravity
	{
		get
		{
			return _003CCustomGravity_003Ek__BackingField;
		}
		private set
		{
			_003CCustomGravity_003Ek__BackingField = value;
		}
	}

	public float DragCoefficient
	{
		get
		{
			return _003CDragCoefficient_003Ek__BackingField;
		}
		private set
		{
			_003CDragCoefficient_003Ek__BackingField = value;
		}
	}

	public Vector3 Acceleration
	{
		get
		{
			return _003CAcceleration_003Ek__BackingField;
		}
		private set
		{
			_003CAcceleration_003Ek__BackingField = value;
		}
	}

	public int DurationTimeMS
	{
		get
		{
			return _003CDurationTimeMS_003Ek__BackingField;
		}
		private set
		{
			_003CDurationTimeMS_003Ek__BackingField = value;
		}
	}

	public List<object> LayerMask
	{
		get
		{
			return _003CLayerMask_003Ek__BackingField;
		}
		private set
		{
			_003CLayerMask_003Ek__BackingField = value;
		}
	}

	public string CustomMaterial
	{
		get
		{
			return _003CCustomMaterial_003Ek__BackingField;
		}
		private set
		{
			_003CCustomMaterial_003Ek__BackingField = value;
		}
	}

	public float Width
	{
		get
		{
			return _003CWidth_003Ek__BackingField;
		}
		private set
		{
			_003CWidth_003Ek__BackingField = value;
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

	public UGCProjectileTrajectoryRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
