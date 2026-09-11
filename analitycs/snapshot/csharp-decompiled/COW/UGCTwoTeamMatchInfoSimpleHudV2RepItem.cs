using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCTwoTeamMatchInfoSimpleHudV2RepItem
{
	public const int PROP_ID_OPENSTATE = -442000;

	public const int PROP_ID_LEFTSCORE = -442001;

	public const int PROP_ID_RIGHTSCORE = -442002;

	public const int PROP_ID_LEFTALIVECOUNT = -442003;

	public const int PROP_ID_RIGHTALIVECOUNT = -442004;

	public const int PROP_ID_LEFTDEADCOUNT = -442005;

	public const int PROP_ID_RIGHTDEADCOUNT = -442006;

	public const int PROP_ID_LEFTALIVEICON = -442007;

	public const int PROP_ID_RIGHTALIVEICON = -442008;

	public const int PROP_ID_LEFTDEADICON = -442009;

	public const int PROP_ID_RIGHTDEADICON = -442010;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<int> OnLeftScoreChangeEvent;

	public Action<int> OnRightScoreChangeEvent;

	public Action<int> OnLeftAliveCountChangeEvent;

	public Action<int> OnRightAliveCountChangeEvent;

	public Action<int> OnLeftDeadCountChangeEvent;

	public Action<int> OnRightDeadCountChangeEvent;

	public Action<string> OnLeftAliveIconChangeEvent;

	public Action<string> OnRightAliveIconChangeEvent;

	public Action<string> OnLeftDeadIconChangeEvent;

	public Action<string> OnRightDeadIconChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private int _003CLeftScore_003Ek__BackingField;

	private int _003CRightScore_003Ek__BackingField;

	private int _003CLeftAliveCount_003Ek__BackingField;

	private int _003CRightAliveCount_003Ek__BackingField;

	private int _003CLeftDeadCount_003Ek__BackingField;

	private int _003CRightDeadCount_003Ek__BackingField;

	private string _003CLeftAliveIcon_003Ek__BackingField;

	private string _003CRightAliveIcon_003Ek__BackingField;

	private string _003CLeftDeadIcon_003Ek__BackingField;

	private string _003CRightDeadIcon_003Ek__BackingField;

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

	public int LeftScore
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

	public int RightScore
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

	public int LeftAliveCount
	{
		get
		{
			return _003CLeftAliveCount_003Ek__BackingField;
		}
		private set
		{
			_003CLeftAliveCount_003Ek__BackingField = value;
		}
	}

	public int RightAliveCount
	{
		get
		{
			return _003CRightAliveCount_003Ek__BackingField;
		}
		private set
		{
			_003CRightAliveCount_003Ek__BackingField = value;
		}
	}

	public int LeftDeadCount
	{
		get
		{
			return _003CLeftDeadCount_003Ek__BackingField;
		}
		private set
		{
			_003CLeftDeadCount_003Ek__BackingField = value;
		}
	}

	public int RightDeadCount
	{
		get
		{
			return _003CRightDeadCount_003Ek__BackingField;
		}
		private set
		{
			_003CRightDeadCount_003Ek__BackingField = value;
		}
	}

	public string LeftAliveIcon
	{
		get
		{
			return _003CLeftAliveIcon_003Ek__BackingField;
		}
		private set
		{
			_003CLeftAliveIcon_003Ek__BackingField = value;
		}
	}

	public string RightAliveIcon
	{
		get
		{
			return _003CRightAliveIcon_003Ek__BackingField;
		}
		private set
		{
			_003CRightAliveIcon_003Ek__BackingField = value;
		}
	}

	public string LeftDeadIcon
	{
		get
		{
			return _003CLeftDeadIcon_003Ek__BackingField;
		}
		private set
		{
			_003CLeftDeadIcon_003Ek__BackingField = value;
		}
	}

	public string RightDeadIcon
	{
		get
		{
			return _003CRightDeadIcon_003Ek__BackingField;
		}
		private set
		{
			_003CRightDeadIcon_003Ek__BackingField = value;
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

	public UGCTwoTeamMatchInfoSimpleHudV2RepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
