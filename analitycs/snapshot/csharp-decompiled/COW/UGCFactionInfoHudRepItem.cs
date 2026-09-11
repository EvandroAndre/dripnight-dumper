using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCFactionInfoHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1028000;

	public const int PROP_ID_LEFTTEAMMATEALIVECOUNT = -1028001;

	public const int PROP_ID_RIGHTTEAMMATEALIVECOUNT = -1028002;

	public const int PROP_ID_LEFTBGCOLOR = -1028003;

	public const int PROP_ID_RIGHTBGCOLOR = -1028004;

	public const int PROP_ID_LEFTICONSPRITENAME = -1028005;

	public const int PROP_ID_RIGHTICONSPRITENAME = -1028006;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<int> OnLeftTeammateAliveCountChangeEvent;

	public Action<int> OnRightTeammateAliveCountChangeEvent;

	public Action<int> OnLeftBgColorChangeEvent;

	public Action<int> OnRightBgColorChangeEvent;

	public Action<string> OnLeftIconSpriteNameChangeEvent;

	public Action<string> OnRightIconSpriteNameChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private int _003CLeftTeammateAliveCount_003Ek__BackingField;

	private int _003CRightTeammateAliveCount_003Ek__BackingField;

	private int _003CLeftBgColor_003Ek__BackingField;

	private int _003CRightBgColor_003Ek__BackingField;

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

	public int LeftBgColor
	{
		get
		{
			return _003CLeftBgColor_003Ek__BackingField;
		}
		private set
		{
			_003CLeftBgColor_003Ek__BackingField = value;
		}
	}

	public int RightBgColor
	{
		get
		{
			return _003CRightBgColor_003Ek__BackingField;
		}
		private set
		{
			_003CRightBgColor_003Ek__BackingField = value;
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

	public UGCFactionInfoHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
