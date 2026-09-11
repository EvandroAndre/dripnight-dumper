using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCCustomCurvePathWayPointRepItem
{
	public const int PROP_ID_ROLL = -432000;

	public const int PROP_ID_TANGENT = -432001;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnRollChangeEvent;

	public Action<Vector3> OnTangentChangeEvent;

	private float _003CRoll_003Ek__BackingField;

	private Vector3 _003CTangent_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float Roll
	{
		get
		{
			return _003CRoll_003Ek__BackingField;
		}
		private set
		{
			_003CRoll_003Ek__BackingField = value;
		}
	}

	public Vector3 Tangent
	{
		get
		{
			return _003CTangent_003Ek__BackingField;
		}
		private set
		{
			_003CTangent_003Ek__BackingField = value;
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

	public UGCCustomCurvePathWayPointRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
