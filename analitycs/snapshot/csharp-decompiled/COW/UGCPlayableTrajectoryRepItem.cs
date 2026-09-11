using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCPlayableTrajectoryRepItem
{
	public const int PROP_ID_TARGETENTITY = -210000;

	public const int PROP_ID_INITIALVELOCITY = -210001;

	public const int PROP_ID_ACCELERATION = -210002;

	public const int PROP_ID_MAXDISPLACEMENT = -210003;

	public const int PROP_ID_INITIALWORLDPOS = -210004;

	public const int PROP_ID_STARTTICKCOUNT = -210006;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnTargetEntityChangeEvent;

	public Action<Vector3> OnInitialVelocityChangeEvent;

	public Action<Vector3> OnAccelerationChangeEvent;

	public Action<float> OnMaxDisplacementChangeEvent;

	public Action<Vector3> OnInitialWorldPosChangeEvent;

	public Action<int> OnStartTickCountChangeEvent;

	private string _003CTargetEntity_003Ek__BackingField;

	private Vector3 _003CInitialVelocity_003Ek__BackingField;

	private Vector3 _003CAcceleration_003Ek__BackingField;

	private float _003CMaxDisplacement_003Ek__BackingField;

	private Vector3 _003CInitialWorldPos_003Ek__BackingField;

	private int _003CStartTickCount_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

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

	public float MaxDisplacement
	{
		get
		{
			return _003CMaxDisplacement_003Ek__BackingField;
		}
		private set
		{
			_003CMaxDisplacement_003Ek__BackingField = value;
		}
	}

	public Vector3 InitialWorldPos
	{
		get
		{
			return _003CInitialWorldPos_003Ek__BackingField;
		}
		private set
		{
			_003CInitialWorldPos_003Ek__BackingField = value;
		}
	}

	public int StartTickCount
	{
		get
		{
			return _003CStartTickCount_003Ek__BackingField;
		}
		private set
		{
			_003CStartTickCount_003Ek__BackingField = value;
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

	public UGCPlayableTrajectoryRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
