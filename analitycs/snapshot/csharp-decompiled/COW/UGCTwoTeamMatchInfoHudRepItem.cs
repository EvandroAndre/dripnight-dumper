using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCTwoTeamMatchInfoHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1023000;

	public const int PROP_ID_SHOWTEAMSCORE = -1023001;

	public const int PROP_ID_LEFTTEAMSCORE = -1023002;

	public const int PROP_ID_RIGHTTEAMSCORE = -1023003;

	public const int PROP_ID_SHOWTEAMMATESTATE = -1023004;

	public const int PROP_ID_LEFTTEAMMATESTATEARRAY = -1023005;

	public const int PROP_ID_RIGHTTEAMMATESTATEARRAY = -1023006;

	public const int PROP_ID_LEFTTEAMMATEFLAGCOUNT = -1023007;

	public const int PROP_ID_RIGHTTEAMMATEFLAGCOUNT = -1023008;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<bool> OnShowTeamScoreChangeEvent;

	public Action<int> OnLeftTeamScoreChangeEvent;

	public Action<int> OnRightTeamScoreChangeEvent;

	public Action<bool> OnShowTeammateStateChangeEvent;

	public Action<List<object>> OnLeftTeammateStateArrayChangeEvent;

	public Action<List<object>> OnRightTeammateStateArrayChangeEvent;

	public Action<int> OnLeftTeammateFlagCountChangeEvent;

	public Action<int> OnRightTeammateFlagCountChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private bool _003CShowTeamScore_003Ek__BackingField;

	private int _003CLeftTeamScore_003Ek__BackingField;

	private int _003CRightTeamScore_003Ek__BackingField;

	private bool _003CShowTeammateState_003Ek__BackingField;

	private List<object> _003CLeftTeammateStateArray_003Ek__BackingField;

	private List<object> _003CRightTeammateStateArray_003Ek__BackingField;

	private int _003CLeftTeammateFlagCount_003Ek__BackingField;

	private int _003CRightTeammateFlagCount_003Ek__BackingField;

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

	public bool ShowTeamScore
	{
		get
		{
			return _003CShowTeamScore_003Ek__BackingField;
		}
		private set
		{
			_003CShowTeamScore_003Ek__BackingField = value;
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

	public bool ShowTeammateState
	{
		get
		{
			return _003CShowTeammateState_003Ek__BackingField;
		}
		private set
		{
			_003CShowTeammateState_003Ek__BackingField = value;
		}
	}

	public List<object> LeftTeammateStateArray
	{
		get
		{
			return _003CLeftTeammateStateArray_003Ek__BackingField;
		}
		private set
		{
			_003CLeftTeammateStateArray_003Ek__BackingField = value;
		}
	}

	public List<object> RightTeammateStateArray
	{
		get
		{
			return _003CRightTeammateStateArray_003Ek__BackingField;
		}
		private set
		{
			_003CRightTeammateStateArray_003Ek__BackingField = value;
		}
	}

	public int LeftTeammateFlagCount
	{
		get
		{
			return _003CLeftTeammateFlagCount_003Ek__BackingField;
		}
		private set
		{
			_003CLeftTeammateFlagCount_003Ek__BackingField = value;
		}
	}

	public int RightTeammateFlagCount
	{
		get
		{
			return _003CRightTeammateFlagCount_003Ek__BackingField;
		}
		private set
		{
			_003CRightTeammateFlagCount_003Ek__BackingField = value;
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

	public UGCTwoTeamMatchInfoHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
