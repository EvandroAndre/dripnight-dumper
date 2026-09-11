using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCSprayRifleRepItem
{
	public const int PROP_ID_INITIALSPEED = -239000;

	public const int PROP_ID_ACCELERATION = -239001;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnInitialSpeedChangeEvent;

	public Action<Vector3> OnAccelerationChangeEvent;

	private float _003CInitialSpeed_003Ek__BackingField;

	private Vector3 _003CAcceleration_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float InitialSpeed
	{
		get
		{
			return _003CInitialSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CInitialSpeed_003Ek__BackingField = value;
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

	public UGCSprayRifleRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
