using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCTitleBannerHudRepItem
{
	public const int PROP_ID_OPENSTATE = -1043000;

	public const int PROP_ID_LOCSWITCH = -1043001;

	public const int PROP_ID_LOCALPOSITION = -1043002;

	public const int PROP_ID_FONTSIZE = -1043003;

	public const int PROP_ID_COLOR = -1043004;

	public const int PROP_ID_LABELKEY = -1043005;

	public const int PROP_ID_LABELPARAMS = -1043006;

	private UGCEntityDataStore _repDataMgr;

	public Action<bool> OnOpenStateChangeEvent;

	public Action<bool> OnLocSwitchChangeEvent;

	public Action<Vector3> OnLocalPositionChangeEvent;

	public Action<int> OnFontSizeChangeEvent;

	public Action<int> OnColorChangeEvent;

	public Action<string> OnLabelKeyChangeEvent;

	public Action<List<object>> OnLabelParamsChangeEvent;

	private bool _003COpenState_003Ek__BackingField;

	private bool _003CLocSwitch_003Ek__BackingField;

	private Vector3 _003CLocalPosition_003Ek__BackingField;

	private int _003CFontSize_003Ek__BackingField;

	private int _003CColor_003Ek__BackingField;

	private string _003CLabelKey_003Ek__BackingField;

	private List<object> _003CLabelParams_003Ek__BackingField;

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

	public Vector3 LocalPosition
	{
		get
		{
			return _003CLocalPosition_003Ek__BackingField;
		}
		private set
		{
			_003CLocalPosition_003Ek__BackingField = value;
		}
	}

	public int FontSize
	{
		get
		{
			return _003CFontSize_003Ek__BackingField;
		}
		private set
		{
			_003CFontSize_003Ek__BackingField = value;
		}
	}

	public int Color
	{
		get
		{
			return _003CColor_003Ek__BackingField;
		}
		private set
		{
			_003CColor_003Ek__BackingField = value;
		}
	}

	public string LabelKey
	{
		get
		{
			return _003CLabelKey_003Ek__BackingField;
		}
		private set
		{
			_003CLabelKey_003Ek__BackingField = value;
		}
	}

	public List<object> LabelParams
	{
		get
		{
			return _003CLabelParams_003Ek__BackingField;
		}
		private set
		{
			_003CLabelParams_003Ek__BackingField = value;
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

	public UGCTitleBannerHudRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
