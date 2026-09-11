using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;

namespace COW;

public class UGCDirectionRulerHudRepItem
{
	public const int PROP_ID_OPENSTATE = -367000;

	public const int PROP_ID_SHOWTAG = -367001;

	public const int PROP_ID_TARGETICONS = -367002;

	public const int PROP_ID_TARGETICONCOLORS = -367003;

	public const int PROP_ID_STATICICONS = -367004;

	public const int PROP_ID_STATICICONCOLORS = -367005;

	public const int PROP_ID_ICONISALWAYSSHOWN = -367006;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<bool> OnShowTagChangeEvent;

	public Action<Dictionary<object, object>> OnTargetIconsChangeEvent;

	public Action<Dictionary<object, object>> OnTargetIconColorsChangeEvent;

	public Action<Dictionary<object, object>> OnStaticIconsChangeEvent;

	public Action<Dictionary<object, object>> OnStaticIconColorsChangeEvent;

	public Action<bool> OnIconIsAlwaysShownChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private bool _003CShowTag_003Ek__BackingField;

	private Dictionary<object, object> _003CTargetIcons_003Ek__BackingField;

	private Dictionary<object, object> _003CTargetIconColors_003Ek__BackingField;

	private Dictionary<object, object> _003CStaticIcons_003Ek__BackingField;

	private Dictionary<object, object> _003CStaticIconColors_003Ek__BackingField;

	private bool _003CIconIsAlwaysShown_003Ek__BackingField;

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

	public bool ShowTag
	{
		get
		{
			return _003CShowTag_003Ek__BackingField;
		}
		private set
		{
			_003CShowTag_003Ek__BackingField = value;
		}
	}

	public Dictionary<object, object> TargetIcons
	{
		get
		{
			return _003CTargetIcons_003Ek__BackingField;
		}
		private set
		{
			_003CTargetIcons_003Ek__BackingField = value;
		}
	}

	public Dictionary<object, object> TargetIconColors
	{
		get
		{
			return _003CTargetIconColors_003Ek__BackingField;
		}
		private set
		{
			_003CTargetIconColors_003Ek__BackingField = value;
		}
	}

	public Dictionary<object, object> StaticIcons
	{
		get
		{
			return _003CStaticIcons_003Ek__BackingField;
		}
		private set
		{
			_003CStaticIcons_003Ek__BackingField = value;
		}
	}

	public Dictionary<object, object> StaticIconColors
	{
		get
		{
			return _003CStaticIconColors_003Ek__BackingField;
		}
		private set
		{
			_003CStaticIconColors_003Ek__BackingField = value;
		}
	}

	public bool IconIsAlwaysShown
	{
		get
		{
			return _003CIconIsAlwaysShown_003Ek__BackingField;
		}
		private set
		{
			_003CIconIsAlwaysShown_003Ek__BackingField = value;
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

	public UGCDirectionRulerHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
