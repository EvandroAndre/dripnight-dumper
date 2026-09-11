using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCRoundResultShowTimeHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1016000;

	public const int PROP_ID_SHOWTIMETYPE = -1016001;

	public const int PROP_ID_SHOWTWOTEAMSCORE = -1016002;

	public const int PROP_ID_LEFTTEAMSCORE = -1016003;

	public const int PROP_ID_RIGHTTEAMSCORE = -1016004;

	public const int PROP_ID_PHASEENDTIME = -1016005;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<int> OnShowTimeTypeChangeEvent;

	public Action<bool> OnShowTwoTeamScoreChangeEvent;

	public Action<int> OnLeftTeamScoreChangeEvent;

	public Action<int> OnRightTeamScoreChangeEvent;

	public Action<int> OnPhaseEndTimeChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private int _003CShowTimeType_003Ek__BackingField;

	private bool _003CShowTwoTeamScore_003Ek__BackingField;

	private int _003CLeftTeamScore_003Ek__BackingField;

	private int _003CRightTeamScore_003Ek__BackingField;

	private int _003CPhaseEndTime_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public bool OpenState
	{
		get
		{
			return _003COpenState_003Ek__BackingField;
		}
		private set
		{
			_003COpenState_003Ek__BackingField = value;
		}
	}

	public int ShowTimeType
	{
		get
		{
			return _003CShowTimeType_003Ek__BackingField;
		}
		private set
		{
			_003CShowTimeType_003Ek__BackingField = value;
		}
	}

	public bool ShowTwoTeamScore
	{
		get
		{
			return _003CShowTwoTeamScore_003Ek__BackingField;
		}
		private set
		{
			_003CShowTwoTeamScore_003Ek__BackingField = value;
		}
	}

	public int LeftTeamScore
	{
		get
		{
			return _003CLeftTeamScore_003Ek__BackingField;
		}
		private set
		{
			_003CLeftTeamScore_003Ek__BackingField = value;
		}
	}

	public int RightTeamScore
	{
		get
		{
			return _003CRightTeamScore_003Ek__BackingField;
		}
		private set
		{
			_003CRightTeamScore_003Ek__BackingField = value;
		}
	}

	public int PhaseEndTime
	{
		get
		{
			return _003CPhaseEndTime_003Ek__BackingField;
		}
		private set
		{
			_003CPhaseEndTime_003Ek__BackingField = value;
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

	public UGCRoundResultShowTimeHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
