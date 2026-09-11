using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCTeamMatchInfoHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1024000;

	public const int PROP_ID_LOCSWITCH = -1024001;

	public const int PROP_ID_OFFSETPOSITION = -1024002;

	public const int PROP_ID_RANK = -1024003;

	public const int PROP_ID_TEAMCOLOR = -1024004;

	public const int PROP_ID_ICONSPRITENAME = -1024005;

	public const int PROP_ID_SHOWFRAME = -1024006;

	public const int PROP_ID_SCORETEXTKEY = -1024007;

	public const int PROP_ID_SCORETEXTKEY_PARAMS = -1024008;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<bool> OnLocSwitchChangeEvent;

	public Action<Vector3> OnOffsetPositionChangeEvent;

	public Action<int> OnRankChangeEvent;

	public Action<int> OnTeamColorChangeEvent;

	public Action<string> OnIconSpriteNameChangeEvent;

	public Action<bool> OnShowFrameChangeEvent;

	public Action<string> OnScoreTextKeyChangeEvent;

	public Action<List<object>> OnScoreTextKey_ParamsChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private bool _003CLocSwitch_003Ek__BackingField;

	private Vector3 _003COffsetPosition_003Ek__BackingField;

	private int _003CRank_003Ek__BackingField;

	private int _003CTeamColor_003Ek__BackingField;

	private string _003CIconSpriteName_003Ek__BackingField;

	private bool _003CShowFrame_003Ek__BackingField;

	private string _003CScoreTextKey_003Ek__BackingField;

	private List<object> _003CScoreTextKey_Params_003Ek__BackingField;

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

	public bool LocSwitch
	{
		get
		{
			return _003CLocSwitch_003Ek__BackingField;
		}
		private set
		{
			_003CLocSwitch_003Ek__BackingField = value;
		}
	}

	public Vector3 OffsetPosition
	{
		get
		{
			return _003COffsetPosition_003Ek__BackingField;
		}
		private set
		{
			_003COffsetPosition_003Ek__BackingField = value;
		}
	}

	public int Rank
	{
		get
		{
			return _003CRank_003Ek__BackingField;
		}
		private set
		{
			_003CRank_003Ek__BackingField = value;
		}
	}

	public int TeamColor
	{
		get
		{
			return _003CTeamColor_003Ek__BackingField;
		}
		private set
		{
			_003CTeamColor_003Ek__BackingField = value;
		}
	}

	public string IconSpriteName
	{
		get
		{
			return _003CIconSpriteName_003Ek__BackingField;
		}
		private set
		{
			_003CIconSpriteName_003Ek__BackingField = value;
		}
	}

	public bool ShowFrame
	{
		get
		{
			return _003CShowFrame_003Ek__BackingField;
		}
		private set
		{
			_003CShowFrame_003Ek__BackingField = value;
		}
	}

	public string ScoreTextKey
	{
		get
		{
			return _003CScoreTextKey_003Ek__BackingField;
		}
		private set
		{
			_003CScoreTextKey_003Ek__BackingField = value;
		}
	}

	public List<object> ScoreTextKey_Params
	{
		get
		{
			return _003CScoreTextKey_Params_003Ek__BackingField;
		}
		private set
		{
			_003CScoreTextKey_Params_003Ek__BackingField = value;
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

	public UGCTeamMatchInfoHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
