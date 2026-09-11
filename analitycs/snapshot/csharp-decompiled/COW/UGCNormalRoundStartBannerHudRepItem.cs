using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCNormalRoundStartBannerHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1013000;

	public const int PROP_ID_LOCSWITCH = -1013001;

	public const int PROP_ID_ROUNDNUMLOCKEY = -1013002;

	public const int PROP_ID_ROUNDNUMLOCKEY_PARAMS = -1013003;

	public const int PROP_ID_DESCTEXT = -1013004;

	public const int PROP_ID_THEMECOLOR = -1013005;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<bool> OnLocSwitchChangeEvent;

	public Action<string> OnRoundNumLocKeyChangeEvent;

	public Action<List<object>> OnRoundNumLocKey_ParamsChangeEvent;

	public Action<string> OnDescTextChangeEvent;

	public Action<int> OnThemeColorChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private bool _003CLocSwitch_003Ek__BackingField;

	private string _003CRoundNumLocKey_003Ek__BackingField;

	private List<object> _003CRoundNumLocKey_Params_003Ek__BackingField;

	private string _003CDescText_003Ek__BackingField;

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

	public string RoundNumLocKey
	{
		get
		{
			return _003CRoundNumLocKey_003Ek__BackingField;
		}
		private set
		{
			_003CRoundNumLocKey_003Ek__BackingField = value;
		}
	}

	public List<object> RoundNumLocKey_Params
	{
		get
		{
			return _003CRoundNumLocKey_Params_003Ek__BackingField;
		}
		private set
		{
			_003CRoundNumLocKey_Params_003Ek__BackingField = value;
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

	public UGCNormalRoundStartBannerHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
