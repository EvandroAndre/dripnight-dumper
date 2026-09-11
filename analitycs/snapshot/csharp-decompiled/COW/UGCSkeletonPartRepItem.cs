using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCSkeletonPartRepItem
{
	public const int PROP_ID_BONESCALE = -275000;

	public const int PROP_ID_BONEPOSITION = -275001;

	public const int PROP_ID_BONEROTATION = -275002;

	private UGCEntityDataStore _repDataMgr;

	public Action<Vector3> OnBoneScaleChangeEvent;

	public Action<Vector3> OnBonePositionChangeEvent;

	public Action<Vector3> OnBoneRotationChangeEvent;

	private Vector3 _003CBoneScale_003Ek__BackingField;

	private Vector3 _003CBonePosition_003Ek__BackingField;

	private Vector3 _003CBoneRotation_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public Vector3 BoneScale
	{
		get
		{
			return _003CBoneScale_003Ek__BackingField;
		}
		private set
		{
			_003CBoneScale_003Ek__BackingField = value;
		}
	}

	public Vector3 BonePosition
	{
		get
		{
			return _003CBonePosition_003Ek__BackingField;
		}
		private set
		{
			_003CBonePosition_003Ek__BackingField = value;
		}
	}

	public Vector3 BoneRotation
	{
		get
		{
			return _003CBoneRotation_003Ek__BackingField;
		}
		private set
		{
			_003CBoneRotation_003Ek__BackingField = value;
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

	public UGCSkeletonPartRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
