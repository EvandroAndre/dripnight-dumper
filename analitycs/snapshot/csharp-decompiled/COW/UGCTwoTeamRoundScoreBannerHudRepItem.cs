using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCTwoTeamRoundScoreBannerHudRepItem
{
	public const int PROP_ID_LOCSWITCH = -1018000;

	public const int PROP_ID_ROUNDNUM = -1018001;

	public const int PROP_ID_LEFTTEAMINDEX = -1018002;

	public const int PROP_ID_LEFTTEAMNAME = -1018003;

	public const int PROP_ID_LEFTTEAMSCORE = -1018004;

	public const int PROP_ID_RIGHTTEAMNAME = -1018005;

	public const int PROP_ID_RIGHTTEAMSCORE = -1018006;

	public const int PROP_ID_OPENSTATE = -1018007;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnLocSwitchChangeEvent;

	public Action<int> OnRoundNumChangeEvent;

	public Action<int> OnLeftTeamIndexChangeEvent;

	public Action<string> OnLeftTeamNameChangeEvent;

	public Action<int> OnLeftTeamScoreChangeEvent;

	public Action<string> OnRightTeamNameChangeEvent;

	public Action<int> OnRightTeamScoreChangeEvent;

	public Action<bool> OnOpenStateChangeEvent;

	private bool _003CLocSwitch_003Ek__BackingField;

	private int _003CRoundNum_003Ek__BackingField;

	private int _003CLeftTeamIndex_003Ek__BackingField;

	private string _003CLeftTeamName_003Ek__BackingField;

	private int _003CLeftTeamScore_003Ek__BackingField;

	private string _003CRightTeamName_003Ek__BackingField;

	private int _003CRightTeamScore_003Ek__BackingField;

	private bool _003COpenState_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

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

	public int RoundNum
	{
		get
		{
			return _003CRoundNum_003Ek__BackingField;
		}
		private set
		{
			_003CRoundNum_003Ek__BackingField = value;
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

	public string LeftTeamName
	{
		get
		{
			return _003CLeftTeamName_003Ek__BackingField;
		}
		private set
		{
			_003CLeftTeamName_003Ek__BackingField = value;
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

	public string RightTeamName
	{
		get
		{
			return _003CRightTeamName_003Ek__BackingField;
		}
		private set
		{
			_003CRightTeamName_003Ek__BackingField = value;
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

	public UGCTwoTeamRoundScoreBannerHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
