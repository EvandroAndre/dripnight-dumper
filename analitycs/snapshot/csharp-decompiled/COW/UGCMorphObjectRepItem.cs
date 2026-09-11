using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCMorphObjectRepItem
{
	public const int PROP_ID_PLAYER = -101000;

	public const int PROP_ID_TARGETITEMID = -101001;

	public const int PROP_ID_TARGETROTATION = -101002;

	public const int PROP_ID_TARGETSCALE = -101003;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnPlayerChangeEvent;

	public Action<int> OnTargetItemIDChangeEvent;

	public Action<Vector3> OnTargetRotationChangeEvent;

	public Action<Vector3> OnTargetScaleChangeEvent;

	private string _003CPlayer_003Ek__BackingField;

	private int _003CTargetItemID_003Ek__BackingField;

	private Vector3 _003CTargetRotation_003Ek__BackingField;

	private Vector3 _003CTargetScale_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string Player
	{
		get
		{
			return _003CPlayer_003Ek__BackingField;
		}
		private set
		{
			_003CPlayer_003Ek__BackingField = value;
		}
	}

	public int TargetItemID
	{
		get
		{
			return _003CTargetItemID_003Ek__BackingField;
		}
		private set
		{
			_003CTargetItemID_003Ek__BackingField = value;
		}
	}

	public Vector3 TargetRotation
	{
		get
		{
			return _003CTargetRotation_003Ek__BackingField;
		}
		private set
		{
			_003CTargetRotation_003Ek__BackingField = value;
		}
	}

	public Vector3 TargetScale
	{
		get
		{
			return _003CTargetScale_003Ek__BackingField;
		}
		private set
		{
			_003CTargetScale_003Ek__BackingField = value;
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

	public UGCMorphObjectRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
