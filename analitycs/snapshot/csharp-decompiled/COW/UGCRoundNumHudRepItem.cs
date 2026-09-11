using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCRoundNumHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1020000;

	public const int PROP_ID_LOCSWITCH = -1020001;

	public const int PROP_ID_TEXTKEY = -1020002;

	public const int PROP_ID_TEXTKEY_PARAMS = -1020003;

	public const int PROP_ID_THEMECOLOR = -1020004;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<bool> OnLocSwitchChangeEvent;

	public Action<string> OnTextKeyChangeEvent;

	public Action<List<object>> OnTextKey_ParamsChangeEvent;

	public Action<int> OnThemeColorChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private bool _003CLocSwitch_003Ek__BackingField;

	private string _003CTextKey_003Ek__BackingField;

	private List<object> _003CTextKey_Params_003Ek__BackingField;

	private int _003CThemeColor_003Ek__BackingField;

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

	public string TextKey
	{
		get
		{
			return _003CTextKey_003Ek__BackingField;
		}
		private set
		{
			_003CTextKey_003Ek__BackingField = value;
		}
	}

	public List<object> TextKey_Params
	{
		get
		{
			return _003CTextKey_Params_003Ek__BackingField;
		}
		private set
		{
			_003CTextKey_Params_003Ek__BackingField = value;
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

	public UGCRoundNumHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
