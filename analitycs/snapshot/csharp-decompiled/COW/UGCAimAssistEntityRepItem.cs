using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCAimAssistEntityRepItem
{
	public const int PROP_ID_AIMASSISTDISTANCE = -321000;

	public const int PROP_ID_AIMASSISTCENTEROFFSET = -321001;

	private UGCEntityDataStore _repDataMgr;

	public Action<float> OnAimAssistDistanceChangeEvent;

	public Action<Vector3> OnAimAssistCenterOffsetChangeEvent;

	private float _003CAimAssistDistance_003Ek__BackingField;

	private Vector3 _003CAimAssistCenterOffset_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public float AimAssistDistance
	{
		get
		{
			return _003CAimAssistDistance_003Ek__BackingField;
		}
		private set
		{
			_003CAimAssistDistance_003Ek__BackingField = value;
		}
	}

	public Vector3 AimAssistCenterOffset
	{
		get
		{
			return _003CAimAssistCenterOffset_003Ek__BackingField;
		}
		private set
		{
			_003CAimAssistCenterOffset_003Ek__BackingField = value;
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

	public UGCAimAssistEntityRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
