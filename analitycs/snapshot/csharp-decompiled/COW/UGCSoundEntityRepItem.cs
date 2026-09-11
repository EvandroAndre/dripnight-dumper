using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCSoundEntityRepItem
{
	public const int PROP_ID_SOUNDTYPE = -335000;

	public const int PROP_ID_REPEATTIMES = -335001;

	public const int PROP_ID_VOLUME = -335002;

	public const int PROP_ID_MAXDISTANCE = -335003;

	public const int PROP_ID_MINDISTANCE = -335004;

	public const int PROP_ID_IS3D = -335005;

	public const int PROP_ID_PRIORITY = -335006;

	public const int PROP_ID_STARTTIME = -335007;

	public const int PROP_ID_STATE = -335008;

	public const int PROP_ID_PLAYEDTIME = -335009;

	public const int PROP_ID_SPEED = -335010;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnSoundTypeChangeEvent;

	public Action<int> OnRepeatTimesChangeEvent;

	public Action<int> OnVolumeChangeEvent;

	public Action<float> OnMaxDistanceChangeEvent;

	public Action<float> OnMinDistanceChangeEvent;

	public Action<bool> OnIs3DChangeEvent;

	public Action<int> OnPriorityChangeEvent;

	public Action<float> OnStartTimeChangeEvent;

	public Action<int> OnStateChangeEvent;

	public Action<int> OnPlayedTimeChangeEvent;

	public Action<float> OnSpeedChangeEvent;

	private string _003CSoundType_003Ek__BackingField;

	private int _003CRepeatTimes_003Ek__BackingField;

	private int _003CVolume_003Ek__BackingField;

	private float _003CMaxDistance_003Ek__BackingField;

	private float _003CMinDistance_003Ek__BackingField;

	private bool _003CIs3D_003Ek__BackingField;

	private int _003CPriority_003Ek__BackingField;

	private float _003CStartTime_003Ek__BackingField;

	private int _003CState_003Ek__BackingField;

	private int _003CPlayedTime_003Ek__BackingField;

	private float _003CSpeed_003Ek__BackingField;

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

	public int RepeatTimes
	{
		get
		{
			return _003CRepeatTimes_003Ek__BackingField;
		}
		private set
		{
			_003CRepeatTimes_003Ek__BackingField = value;
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

	public float MaxDistance
	{
		get
		{
			return _003CMaxDistance_003Ek__BackingField;
		}
		private set
		{
			_003CMaxDistance_003Ek__BackingField = value;
		}
	}

	public float MinDistance
	{
		get
		{
			return _003CMinDistance_003Ek__BackingField;
		}
		private set
		{
			_003CMinDistance_003Ek__BackingField = value;
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

	public int Priority
	{
		get
		{
			return _003CPriority_003Ek__BackingField;
		}
		private set
		{
			_003CPriority_003Ek__BackingField = value;
		}
	}

	public float StartTime
	{
		get
		{
			return _003CStartTime_003Ek__BackingField;
		}
		private set
		{
			_003CStartTime_003Ek__BackingField = value;
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

	public int PlayedTime
	{
		get
		{
			return _003CPlayedTime_003Ek__BackingField;
		}
		private set
		{
			_003CPlayedTime_003Ek__BackingField = value;
		}
	}

	public float Speed
	{
		get
		{
			return _003CSpeed_003Ek__BackingField;
		}
		private set
		{
			_003CSpeed_003Ek__BackingField = value;
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

	public UGCSoundEntityRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
