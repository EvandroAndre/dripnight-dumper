using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCTwoTeamLeaderboardHudV2RepItem
{
	public const int PROP_ID_OPENSTATE = -437000;

	public const int PROP_ID_LEFTTEAMSCORE = -437001;

	public const int PROP_ID_RIGHTTEAMSCORE = -437002;

	public const int PROP_ID_LEFTPLAYERARRAY = -437003;

	public const int PROP_ID_RIGHTPLAYERARRAY = -437004;

	public const int PROP_ID_SCORETYPENAMES = -437005;

	public const int PROP_ID_LEFTSCORECONTENT = -437006;

	public const int PROP_ID_RIGHTSCORECONTENT = -437007;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<int> OnLeftTeamScoreChangeEvent;

	public Action<int> OnRightTeamScoreChangeEvent;

	public Action<List<object>> OnLeftPlayerArrayChangeEvent;

	public Action<List<object>> OnRightPlayerArrayChangeEvent;

	public Action<List<object>> OnScoreTypeNamesChangeEvent;

	public Action<List<object>> OnLeftScoreContentChangeEvent;

	public Action<List<object>> OnRightScoreContentChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private int _003CLeftTeamScore_003Ek__BackingField;

	private int _003CRightTeamScore_003Ek__BackingField;

	private List<object> _003CLeftPlayerArray_003Ek__BackingField;

	private List<object> _003CRightPlayerArray_003Ek__BackingField;

	private List<object> _003CScoreTypeNames_003Ek__BackingField;

	private List<object> _003CLeftScoreContent_003Ek__BackingField;

	private List<object> _003CRightScoreContent_003Ek__BackingField;

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

	public List<object> LeftPlayerArray
	{
		get
		{
			return _003CLeftPlayerArray_003Ek__BackingField;
		}
		private set
		{
			_003CLeftPlayerArray_003Ek__BackingField = value;
		}
	}

	public List<object> RightPlayerArray
	{
		get
		{
			return _003CRightPlayerArray_003Ek__BackingField;
		}
		private set
		{
			_003CRightPlayerArray_003Ek__BackingField = value;
		}
	}

	public List<object> ScoreTypeNames
	{
		get
		{
			return _003CScoreTypeNames_003Ek__BackingField;
		}
		private set
		{
			_003CScoreTypeNames_003Ek__BackingField = value;
		}
	}

	public List<object> LeftScoreContent
	{
		get
		{
			return _003CLeftScoreContent_003Ek__BackingField;
		}
		private set
		{
			_003CLeftScoreContent_003Ek__BackingField = value;
		}
	}

	public List<object> RightScoreContent
	{
		get
		{
			return _003CRightScoreContent_003Ek__BackingField;
		}
		private set
		{
			_003CRightScoreContent_003Ek__BackingField = value;
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

	public UGCTwoTeamLeaderboardHudV2RepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
