using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCTwoTeamMatchInfoSimpleHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1030000;

	public const int PROP_ID_LEFTTEAMSCORE = -1030001;

	public const int PROP_ID_RIGHTTEAMSCORE = -1030002;

	public const int PROP_ID_LEFTTEAMMATEALIVECOUNT = -1030003;

	public const int PROP_ID_RIGHTTEAMMATEALIVECOUNT = -1030004;

	public const int PROP_ID_LEFTICONSPRITENAME = -1030005;

	public const int PROP_ID_RIGHTICONSPRITENAME = -1030006;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<int> OnLeftTeamScoreChangeEvent;

	public Action<int> OnRightTeamScoreChangeEvent;

	public Action<int> OnLeftTeammateAliveCountChangeEvent;

	public Action<int> OnRightTeammateAliveCountChangeEvent;

	public Action<string> OnLeftIconSpriteNameChangeEvent;

	public Action<string> OnRightIconSpriteNameChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private int _003CLeftTeamScore_003Ek__BackingField;

	private int _003CRightTeamScore_003Ek__BackingField;

	private int _003CLeftTeammateAliveCount_003Ek__BackingField;

	private int _003CRightTeammateAliveCount_003Ek__BackingField;

	private string _003CLeftIconSpriteName_003Ek__BackingField;

	private string _003CRightIconSpriteName_003Ek__BackingField;

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

	public int LeftTeammateAliveCount
	{
		get
		{
			return _003CLeftTeammateAliveCount_003Ek__BackingField;
		}
		private set
		{
			_003CLeftTeammateAliveCount_003Ek__BackingField = value;
		}
	}

	public int RightTeammateAliveCount
	{
		get
		{
			return _003CRightTeammateAliveCount_003Ek__BackingField;
		}
		private set
		{
			_003CRightTeammateAliveCount_003Ek__BackingField = value;
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

	public UGCTwoTeamMatchInfoSimpleHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
