using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCCSRoundResultHudRepItem
{
	public const int PROP_ID_LEFTCOLOR = -371000;

	public const int PROP_ID_RIGHTCOLOR = -371001;

	public const int PROP_ID_LEFTSCORE = -371002;

	public const int PROP_ID_RIGHTSCORE = -371003;

	public const int PROP_ID_LEFTSCOREAFTER = -371004;

	public const int PROP_ID_RIGHTSCOREAFTER = -371005;

	private UGCEntityDataStore _repDataMgr;

	public Action<int> OnLeftColorChangeEvent;

	public Action<int> OnRightColorChangeEvent;

	public Action<string> OnLeftScoreChangeEvent;

	public Action<string> OnRightScoreChangeEvent;

	public Action<string> OnLeftScoreAfterChangeEvent;

	public Action<string> OnRightScoreAfterChangeEvent;

	private int _003CLeftColor_003Ek__BackingField;

	private int _003CRightColor_003Ek__BackingField;

	private string _003CLeftScore_003Ek__BackingField;

	private string _003CRightScore_003Ek__BackingField;

	private string _003CLeftScoreAfter_003Ek__BackingField;

	private string _003CRightScoreAfter_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public int LeftColor
	{
		get
		{
			return _003CLeftColor_003Ek__BackingField;
		}
		private set
		{
			_003CLeftColor_003Ek__BackingField = value;
		}
	}

	public int RightColor
	{
		get
		{
			return _003CRightColor_003Ek__BackingField;
		}
		private set
		{
			_003CRightColor_003Ek__BackingField = value;
		}
	}

	public string LeftScore
	{
		get
		{
			return _003CLeftScore_003Ek__BackingField;
		}
		private set
		{
			_003CLeftScore_003Ek__BackingField = value;
		}
	}

	public string RightScore
	{
		get
		{
			return _003CRightScore_003Ek__BackingField;
		}
		private set
		{
			_003CRightScore_003Ek__BackingField = value;
		}
	}

	public string LeftScoreAfter
	{
		get
		{
			return _003CLeftScoreAfter_003Ek__BackingField;
		}
		private set
		{
			_003CLeftScoreAfter_003Ek__BackingField = value;
		}
	}

	public string RightScoreAfter
	{
		get
		{
			return _003CRightScoreAfter_003Ek__BackingField;
		}
		private set
		{
			_003CRightScoreAfter_003Ek__BackingField = value;
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

	public UGCCSRoundResultHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
