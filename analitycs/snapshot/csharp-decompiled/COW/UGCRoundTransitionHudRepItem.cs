using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCRoundTransitionHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1033000;

	public const int PROP_ID_TRANSITIONSTAGE = -1033001;

	public const int PROP_ID_LEFTTEAMSCORE = -1033002;

	public const int PROP_ID_RIGHTTEAMSCORE = -1033003;

	public const int PROP_ID_LEFTTEAMNAME = -1033004;

	public const int PROP_ID_RIGHTTEAMNAME = -1033005;

	public const int PROP_ID_LEFTICONSPRITENAME = -1033006;

	public const int PROP_ID_RIGHTICONSPRITENAME = -1033007;

	public const int PROP_ID_RESULTTYPE = -1033008;

	public const int PROP_ID_WINLOC = -1033009;

	public const int PROP_ID_LOSELOC = -1033010;

	public const int PROP_ID_ROUNDINCOMETITLE = -1033011;

	public const int PROP_ID_ROUNDINCOME = -1033012;

	public const int PROP_ID_ROUNDINCOMEDETAILTITLELIST = -1033013;

	public const int PROP_ID_ROUNDINCOMEDETAILLIST = -1033014;

	public const int PROP_ID_MVP = -1033015;

	public const int PROP_ID_NEXTROUNDINDEX = -1033016;

	public const int PROP_ID_ISMATCHPOINT = -1033017;

	public const int PROP_ID_ISLASTROUND = -1033018;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<int> OnTransitionStageChangeEvent;

	public Action<int> OnLeftTeamScoreChangeEvent;

	public Action<int> OnRightTeamScoreChangeEvent;

	public Action<string> OnLeftTeamNameChangeEvent;

	public Action<string> OnRightTeamNameChangeEvent;

	public Action<string> OnLeftIconSpriteNameChangeEvent;

	public Action<string> OnRightIconSpriteNameChangeEvent;

	public Action<int> OnResultTypeChangeEvent;

	public Action<string> OnWinLocChangeEvent;

	public Action<string> OnLoseLocChangeEvent;

	public Action<string> OnRoundIncomeTitleChangeEvent;

	public Action<int> OnRoundIncomeChangeEvent;

	public Action<List<object>> OnRoundIncomeDetailTitleListChangeEvent;

	public Action<List<object>> OnRoundIncomeDetailListChangeEvent;

	public Action<string> OnMVPChangeEvent;

	public Action<int> OnNextRoundIndexChangeEvent;

	public Action<bool> OnIsMatchPointChangeEvent;

	public Action<bool> OnIsLastRoundChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private int _003CTransitionStage_003Ek__BackingField;

	private int _003CLeftTeamScore_003Ek__BackingField;

	private int _003CRightTeamScore_003Ek__BackingField;

	private string _003CLeftTeamName_003Ek__BackingField;

	private string _003CRightTeamName_003Ek__BackingField;

	private string _003CLeftIconSpriteName_003Ek__BackingField;

	private string _003CRightIconSpriteName_003Ek__BackingField;

	private int _003CResultType_003Ek__BackingField;

	private string _003CWinLoc_003Ek__BackingField;

	private string _003CLoseLoc_003Ek__BackingField;

	private string _003CRoundIncomeTitle_003Ek__BackingField;

	private int _003CRoundIncome_003Ek__BackingField;

	private List<object> _003CRoundIncomeDetailTitleList_003Ek__BackingField;

	private List<object> _003CRoundIncomeDetailList_003Ek__BackingField;

	private string _003CMVP_003Ek__BackingField;

	private int _003CNextRoundIndex_003Ek__BackingField;

	private bool _003CIsMatchPoint_003Ek__BackingField;

	private bool _003CIsLastRound_003Ek__BackingField;

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

	public int TransitionStage
	{
		get
		{
			return _003CTransitionStage_003Ek__BackingField;
		}
		private set
		{
			_003CTransitionStage_003Ek__BackingField = value;
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

	public string LeftIconSpriteName
	{
		get
		{
			return _003CLeftIconSpriteName_003Ek__BackingField;
		}
		private set
		{
			_003CLeftIconSpriteName_003Ek__BackingField = value;
		}
	}

	public string RightIconSpriteName
	{
		get
		{
			return _003CRightIconSpriteName_003Ek__BackingField;
		}
		private set
		{
			_003CRightIconSpriteName_003Ek__BackingField = value;
		}
	}

	public int ResultType
	{
		get
		{
			return _003CResultType_003Ek__BackingField;
		}
		private set
		{
			_003CResultType_003Ek__BackingField = value;
		}
	}

	public string WinLoc
	{
		get
		{
			return _003CWinLoc_003Ek__BackingField;
		}
		private set
		{
			_003CWinLoc_003Ek__BackingField = value;
		}
	}

	public string LoseLoc
	{
		get
		{
			return _003CLoseLoc_003Ek__BackingField;
		}
		private set
		{
			_003CLoseLoc_003Ek__BackingField = value;
		}
	}

	public string RoundIncomeTitle
	{
		get
		{
			return _003CRoundIncomeTitle_003Ek__BackingField;
		}
		private set
		{
			_003CRoundIncomeTitle_003Ek__BackingField = value;
		}
	}

	public int RoundIncome
	{
		get
		{
			return _003CRoundIncome_003Ek__BackingField;
		}
		private set
		{
			_003CRoundIncome_003Ek__BackingField = value;
		}
	}

	public List<object> RoundIncomeDetailTitleList
	{
		get
		{
			return _003CRoundIncomeDetailTitleList_003Ek__BackingField;
		}
		private set
		{
			_003CRoundIncomeDetailTitleList_003Ek__BackingField = value;
		}
	}

	public List<object> RoundIncomeDetailList
	{
		get
		{
			return _003CRoundIncomeDetailList_003Ek__BackingField;
		}
		private set
		{
			_003CRoundIncomeDetailList_003Ek__BackingField = value;
		}
	}

	public string MVP
	{
		get
		{
			return _003CMVP_003Ek__BackingField;
		}
		private set
		{
			_003CMVP_003Ek__BackingField = value;
		}
	}

	public int NextRoundIndex
	{
		get
		{
			return _003CNextRoundIndex_003Ek__BackingField;
		}
		private set
		{
			_003CNextRoundIndex_003Ek__BackingField = value;
		}
	}

	public bool IsMatchPoint
	{
		get
		{
			return _003CIsMatchPoint_003Ek__BackingField;
		}
		private set
		{
			_003CIsMatchPoint_003Ek__BackingField = value;
		}
	}

	public bool IsLastRound
	{
		get
		{
			return _003CIsLastRound_003Ek__BackingField;
		}
		private set
		{
			_003CIsLastRound_003Ek__BackingField = value;
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

	public UGCRoundTransitionHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
