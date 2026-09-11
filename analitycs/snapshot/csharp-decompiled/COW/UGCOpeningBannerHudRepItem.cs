using System;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCOpeningBannerHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1011000;

	public const int PROP_ID_ICONSPRITENAME = -1011001;

	public const int PROP_ID_THEMECOLOR = -1011002;

	public const int PROP_ID_LOCSWITCH = -1011003;

	public const int PROP_ID_TITLETEXT = -1011004;

	public const int PROP_ID_DESCTEXT = -1011005;

	public const int PROP_ID_ICON = -1011006;

	public const int PROP_ID_MAXPROGRESS = -1011007;

	public const int PROP_ID_CURPROGRESS = -1011008;

	public const int PROP_ID_PROGRESSICON = -1011009;

	public const int PROP_ID_PROGRESSICONSPRITENAME = -1011010;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<string> OnIconSpriteNameChangeEvent;

	public Action<int> OnThemeColorChangeEvent;

	public Action<bool> OnLocSwitchChangeEvent;

	public Action<string> OnTitleTextChangeEvent;

	public Action<string> OnDescTextChangeEvent;

	public Action<string> OnIconChangeEvent;

	public Action<int> OnMaxProgressChangeEvent;

	public Action<int> OnCurProgressChangeEvent;

	public Action<string> OnProgressIconChangeEvent;

	public Action<string> OnProgressIconSpriteNameChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private string _003CIconSpriteName_003Ek__BackingField;

	private int _003CThemeColor_003Ek__BackingField;

	private bool _003CLocSwitch_003Ek__BackingField;

	private string _003CTitleText_003Ek__BackingField;

	private string _003CDescText_003Ek__BackingField;

	private string _003CIcon_003Ek__BackingField;

	private int _003CMaxProgress_003Ek__BackingField;

	private int _003CCurProgress_003Ek__BackingField;

	private string _003CProgressIcon_003Ek__BackingField;

	private string _003CProgressIconSpriteName_003Ek__BackingField;

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

	public int ThemeColor
	{
		get
		{
			return _003CThemeColor_003Ek__BackingField;
		}
		private set
		{
			_003CThemeColor_003Ek__BackingField = value;
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

	public string TitleText
	{
		get
		{
			return _003CTitleText_003Ek__BackingField;
		}
		private set
		{
			_003CTitleText_003Ek__BackingField = value;
		}
	}

	public string DescText
	{
		get
		{
			return _003CDescText_003Ek__BackingField;
		}
		private set
		{
			_003CDescText_003Ek__BackingField = value;
		}
	}

	public string Icon
	{
		get
		{
			return _003CIcon_003Ek__BackingField;
		}
		private set
		{
			_003CIcon_003Ek__BackingField = value;
		}
	}

	public int MaxProgress
	{
		get
		{
			return _003CMaxProgress_003Ek__BackingField;
		}
		private set
		{
			_003CMaxProgress_003Ek__BackingField = value;
		}
	}

	public int CurProgress
	{
		get
		{
			return _003CCurProgress_003Ek__BackingField;
		}
		private set
		{
			_003CCurProgress_003Ek__BackingField = value;
		}
	}

	public string ProgressIcon
	{
		get
		{
			return _003CProgressIcon_003Ek__BackingField;
		}
		private set
		{
			_003CProgressIcon_003Ek__BackingField = value;
		}
	}

	public string ProgressIconSpriteName
	{
		get
		{
			return _003CProgressIconSpriteName_003Ek__BackingField;
		}
		private set
		{
			_003CProgressIconSpriteName_003Ek__BackingField = value;
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

	public UGCOpeningBannerHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
