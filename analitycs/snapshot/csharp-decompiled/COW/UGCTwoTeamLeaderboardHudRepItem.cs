using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCTwoTeamLeaderboardHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1025000;

	public const int PROP_ID_LEFTTEAMINDEX = -1025001;

	public const int PROP_ID_RIGHTTEAMINDEX = -1025002;

	public const int PROP_ID_LEFTTEAMSCORE = -1025003;

	public const int PROP_ID_RIGHTTEAMSCORE = -1025004;

	public const int PROP_ID_PLAYERSCORETYPES = -1025005;

	public const int PROP_ID_LEFTPLAYERARRAY = -1025006;

	public const int PROP_ID_RIGHTPLAYERARRAY = -1025007;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<int> OnLeftTeamIndexChangeEvent;

	public Action<int> OnRightTeamIndexChangeEvent;

	public Action<int> OnLeftTeamScoreChangeEvent;

	public Action<int> OnRightTeamScoreChangeEvent;

	public Action<List<object>> OnPlayerScoreTypesChangeEvent;

	public Action<List<object>> OnLeftPlayerArrayChangeEvent;

	public Action<List<object>> OnRightPlayerArrayChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private int _003CLeftTeamIndex_003Ek__BackingField;

	private int _003CRightTeamIndex_003Ek__BackingField;

	private int _003CLeftTeamScore_003Ek__BackingField;

	private int _003CRightTeamScore_003Ek__BackingField;

	private List<object> _003CPlayerScoreTypes_003Ek__BackingField;

	private List<object> _003CLeftPlayerArray_003Ek__BackingField;

	private List<object> _003CRightPlayerArray_003Ek__BackingField;

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

	public int LeftTeamIndex
	{
		get
		{
			return _003CLeftTeamIndex_003Ek__BackingField;
		}
		private set
		{
			_003CLeftTeamIndex_003Ek__BackingField = value;
		}
	}

	public int RightTeamIndex
	{
		get
		{
			return _003CRightTeamIndex_003Ek__BackingField;
		}
		private set
		{
			_003CRightTeamIndex_003Ek__BackingField = value;
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

	public List<object> PlayerScoreTypes
	{
		get
		{
			return _003CPlayerScoreTypes_003Ek__BackingField;
		}
		private set
		{
			_003CPlayerScoreTypes_003Ek__BackingField = value;
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

	public UGCTwoTeamLeaderboardHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
