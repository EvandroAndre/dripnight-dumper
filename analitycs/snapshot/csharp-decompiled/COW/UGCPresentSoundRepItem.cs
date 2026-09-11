using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCPresentSoundRepItem
{
	public const int PROP_ID_SOUNDTYPE = -52000;

	public const int PROP_ID_FOLLOWTARGET = -52001;

	public const int PROP_ID_PLAYTIME = -52002;

	public const int PROP_ID_ISLOOP = -52003;

	public const int PROP_ID_VOLUME = -52004;

	public const int PROP_ID_PLAYDISTANCE = -52005;

	public const int PROP_ID_POSITION = -52006;

	public const int PROP_ID_IS3D = -52007;

	public const int PROP_ID_STATE = -52008;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnSoundTypeChangeEvent;

	public Action<string> OnFollowTargetChangeEvent;

	public Action<int> OnPlayTimeChangeEvent;

	public Action<bool> OnIsLoopChangeEvent;

	public Action<int> OnVolumeChangeEvent;

	public Action<float> OnPlayDistanceChangeEvent;

	public Action<Vector3> OnPositionChangeEvent;

	public Action<bool> OnIs3DChangeEvent;

	public Action<int> OnStateChangeEvent;

	private string _003CSoundType_003Ek__BackingField;

	private string _003CFollowTarget_003Ek__BackingField;

	private int _003CPlayTime_003Ek__BackingField;

	private bool _003CIsLoop_003Ek__BackingField;

	private int _003CVolume_003Ek__BackingField;

	private float _003CPlayDistance_003Ek__BackingField;

	private Vector3 _003CPosition_003Ek__BackingField;

	private bool _003CIs3D_003Ek__BackingField;

	private int _003CState_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string SoundType
	{
		get
		{
			return _003CSoundType_003Ek__BackingField;
		}
		private set
		{
			_003CSoundType_003Ek__BackingField = value;
		}
	}

	public string FollowTarget
	{
		get
		{
			return _003CFollowTarget_003Ek__BackingField;
		}
		private set
		{
			_003CFollowTarget_003Ek__BackingField = value;
		}
	}

	public int PlayTime
	{
		get
		{
			return _003CPlayTime_003Ek__BackingField;
		}
		private set
		{
			_003CPlayTime_003Ek__BackingField = value;
		}
	}

	public bool IsLoop
	{
		get
		{
			return _003CIsLoop_003Ek__BackingField;
		}
		private set
		{
			_003CIsLoop_003Ek__BackingField = value;
		}
	}

	public int Volume
	{
		get
		{
			return _003CVolume_003Ek__BackingField;
		}
		private set
		{
			_003CVolume_003Ek__BackingField = value;
		}
	}

	public float PlayDistance
	{
		get
		{
			return _003CPlayDistance_003Ek__BackingField;
		}
		private set
		{
			_003CPlayDistance_003Ek__BackingField = value;
		}
	}

	public Vector3 Position
	{
		get
		{
			return _003CPosition_003Ek__BackingField;
		}
		private set
		{
			_003CPosition_003Ek__BackingField = value;
		}
	}

	public bool Is3D
	{
		get
		{
			return _003CIs3D_003Ek__BackingField;
		}
		private set
		{
			_003CIs3D_003Ek__BackingField = value;
		}
	}

	public int State
	{
		get
		{
			return _003CState_003Ek__BackingField;
		}
		private set
		{
			_003CState_003Ek__BackingField = value;
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

	public UGCPresentSoundRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
