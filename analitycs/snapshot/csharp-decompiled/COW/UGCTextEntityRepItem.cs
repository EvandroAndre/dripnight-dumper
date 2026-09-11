using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCTextEntityRepItem
{
	public const int PROP_ID_TEXTKEY = -244000;

	public const int PROP_ID_COLOR = -244001;

	public const int PROP_ID_FOLLOWTARGET = -244002;

	public const int PROP_ID_IGNOREDEPTH = -244003;

	public const int PROP_ID_ISBILLBOARD = -244004;

	public const int PROP_ID_ALWAYSINSCREEN = -244005;

	public const int PROP_ID_FONTSTYLE = -244006;

	public const int PROP_ID_FONTTYPE = -244007;

	public const int PROP_ID_FONTSIZE = -244008;

	public const int PROP_ID_OFFSET = -244009;

	public const int PROP_ID_VISIBLEPLAYERS = -244010;

	public const int PROP_ID_DEPTH = -244011;

	public const int PROP_ID_WIDTH = -244012;

	public const int PROP_ID_HEIGHT = -244013;

	public const int PROP_ID_FONDOVERFLOWMOD = -244014;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnTextKeyChangeEvent;

	public Action<int> OnColorChangeEvent;

	public Action<string> OnFollowTargetChangeEvent;

	public Action<bool> OnIgnoreDepthChangeEvent;

	public Action<bool> OnIsBillboardChangeEvent;

	public Action<bool> OnAlwaysInScreenChangeEvent;

	public Action<int> OnFontStyleChangeEvent;

	public Action<string> OnFontTypeChangeEvent;

	public Action<int> OnFontSizeChangeEvent;

	public Action<Vector3> OnOffsetChangeEvent;

	public Action<List<object>> OnVisiblePlayersChangeEvent;

	public Action<int> OnDepthChangeEvent;

	public Action<int> OnWidthChangeEvent;

	public Action<int> OnHeightChangeEvent;

	public Action<int> OnFondOverFlowModChangeEvent;

	private string _003CTextKey_003Ek__BackingField;

	private int _003CColor_003Ek__BackingField;

	private string _003CFollowTarget_003Ek__BackingField;

	private bool _003CIgnoreDepth_003Ek__BackingField;

	private bool _003CIsBillboard_003Ek__BackingField;

	private bool _003CAlwaysInScreen_003Ek__BackingField;

	private int _003CFontStyle_003Ek__BackingField;

	private string _003CFontType_003Ek__BackingField;

	private int _003CFontSize_003Ek__BackingField;

	private Vector3 _003COffset_003Ek__BackingField;

	private List<object> _003CVisiblePlayers_003Ek__BackingField;

	private int _003CDepth_003Ek__BackingField;

	private int _003CWidth_003Ek__BackingField;

	private int _003CHeight_003Ek__BackingField;

	private int _003CFondOverFlowMod_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

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

	public string FollowTarget
	{
		get
		{
			return _003CFollowTarget_003Ek__BackingField;
		}
		private set
		{
			_003CFollowTarget_003Ek__BackingField = value;
		}
	}

	public bool IgnoreDepth
	{
		get
		{
			return _003CIgnoreDepth_003Ek__BackingField;
		}
		private set
		{
			_003CIgnoreDepth_003Ek__BackingField = value;
		}
	}

	public bool IsBillboard
	{
		get
		{
			return _003CIsBillboard_003Ek__BackingField;
		}
		private set
		{
			_003CIsBillboard_003Ek__BackingField = value;
		}
	}

	public bool AlwaysInScreen
	{
		get
		{
			return _003CAlwaysInScreen_003Ek__BackingField;
		}
		private set
		{
			_003CAlwaysInScreen_003Ek__BackingField = value;
		}
	}

	public int FontStyle
	{
		get
		{
			return _003CFontStyle_003Ek__BackingField;
		}
		private set
		{
			_003CFontStyle_003Ek__BackingField = value;
		}
	}

	public string FontType
	{
		get
		{
			return _003CFontType_003Ek__BackingField;
		}
		private set
		{
			_003CFontType_003Ek__BackingField = value;
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

	public Vector3 Offset
	{
		get
		{
			return _003COffset_003Ek__BackingField;
		}
		private set
		{
			_003COffset_003Ek__BackingField = value;
		}
	}

	public List<object> VisiblePlayers
	{
		get
		{
			return _003CVisiblePlayers_003Ek__BackingField;
		}
		private set
		{
			_003CVisiblePlayers_003Ek__BackingField = value;
		}
	}

	public int Depth
	{
		get
		{
			return _003CDepth_003Ek__BackingField;
		}
		private set
		{
			_003CDepth_003Ek__BackingField = value;
		}
	}

	public int Width
	{
		get
		{
			return _003CWidth_003Ek__BackingField;
		}
		private set
		{
			_003CWidth_003Ek__BackingField = value;
		}
	}

	public int Height
	{
		get
		{
			return _003CHeight_003Ek__BackingField;
		}
		private set
		{
			_003CHeight_003Ek__BackingField = value;
		}
	}

	public int FondOverFlowMod
	{
		get
		{
			return _003CFondOverFlowMod_003Ek__BackingField;
		}
		private set
		{
			_003CFondOverFlowMod_003Ek__BackingField = value;
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

	public UGCTextEntityRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
