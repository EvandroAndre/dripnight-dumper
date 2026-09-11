using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCTeamRoundScoreBannerHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1014000;

	public const int PROP_ID_LOCSWITCH = -1014001;

	public const int PROP_ID_FIRSTSCORETITLELOCKEY = -1014002;

	public const int PROP_ID_FIRSTSCOREVALUELOCKEY = -1014003;

	public const int PROP_ID_FIRSTSCOREVALUELOCKEY_PARAMS = -1014004;

	public const int PROP_ID_SECONDSCORETITLELOCKEY = -1014005;

	public const int PROP_ID_SECONDSCOREVALUELOCKEY = -1014006;

	public const int PROP_ID_SECONDSCOREVALUELOCKEY_PARAMS = -1014007;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<bool> OnLocSwitchChangeEvent;

	public Action<string> OnFirstScoreTitleLocKeyChangeEvent;

	public Action<string> OnFirstScoreValueLocKeyChangeEvent;

	public Action<List<object>> OnFirstScoreValueLocKey_ParamsChangeEvent;

	public Action<string> OnSecondScoreTitleLocKeyChangeEvent;

	public Action<string> OnSecondScoreValueLocKeyChangeEvent;

	public Action<List<object>> OnSecondScoreValueLocKey_ParamsChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private bool _003CLocSwitch_003Ek__BackingField;

	private string _003CFirstScoreTitleLocKey_003Ek__BackingField;

	private string _003CFirstScoreValueLocKey_003Ek__BackingField;

	private List<object> _003CFirstScoreValueLocKey_Params_003Ek__BackingField;

	private string _003CSecondScoreTitleLocKey_003Ek__BackingField;

	private string _003CSecondScoreValueLocKey_003Ek__BackingField;

	private List<object> _003CSecondScoreValueLocKey_Params_003Ek__BackingField;

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

	public string FirstScoreTitleLocKey
	{
		get
		{
			return _003CFirstScoreTitleLocKey_003Ek__BackingField;
		}
		private set
		{
			_003CFirstScoreTitleLocKey_003Ek__BackingField = value;
		}
	}

	public string FirstScoreValueLocKey
	{
		get
		{
			return _003CFirstScoreValueLocKey_003Ek__BackingField;
		}
		private set
		{
			_003CFirstScoreValueLocKey_003Ek__BackingField = value;
		}
	}

	public List<object> FirstScoreValueLocKey_Params
	{
		get
		{
			return _003CFirstScoreValueLocKey_Params_003Ek__BackingField;
		}
		private set
		{
			_003CFirstScoreValueLocKey_Params_003Ek__BackingField = value;
		}
	}

	public string SecondScoreTitleLocKey
	{
		get
		{
			return _003CSecondScoreTitleLocKey_003Ek__BackingField;
		}
		private set
		{
			_003CSecondScoreTitleLocKey_003Ek__BackingField = value;
		}
	}

	public string SecondScoreValueLocKey
	{
		get
		{
			return _003CSecondScoreValueLocKey_003Ek__BackingField;
		}
		private set
		{
			_003CSecondScoreValueLocKey_003Ek__BackingField = value;
		}
	}

	public List<object> SecondScoreValueLocKey_Params
	{
		get
		{
			return _003CSecondScoreValueLocKey_Params_003Ek__BackingField;
		}
		private set
		{
			_003CSecondScoreValueLocKey_Params_003Ek__BackingField = value;
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

	public UGCTeamRoundScoreBannerHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
