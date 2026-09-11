using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCIconEntityRepItem
{
	public const int PROP_ID_ICONTYPE = -245000;

	public const int PROP_ID_COLOR = -245001;

	public const int PROP_ID_FOLLOWTARGET = -245002;

	public const int PROP_ID_IGNOREDEPTH = -245003;

	public const int PROP_ID_ALWAYSINSCREEN = -245004;

	public const int PROP_ID_ISBILLBOARD = -245005;

	public const int PROP_ID_RENDERTYPE = -245006;

	public const int PROP_ID_WIDTH = -245007;

	public const int PROP_ID_HEIGHT = -245008;

	public const int PROP_ID_OFFSET = -245009;

	public const int PROP_ID_VISIBLEPLAYERS = -245010;

	public const int PROP_ID_DEPTH = -245011;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnIconTypeChangeEvent;

	public Action<int> OnColorChangeEvent;

	public Action<string> OnFollowTargetChangeEvent;

	public Action<bool> OnIgnoreDepthChangeEvent;

	public Action<bool> OnAlwaysInScreenChangeEvent;

	public Action<bool> OnIsBillboardChangeEvent;

	public Action<int> OnRenderTypeChangeEvent;

	public Action<int> OnWidthChangeEvent;

	public Action<int> OnHeightChangeEvent;

	public Action<Vector3> OnOffsetChangeEvent;

	public Action<List<object>> OnVisiblePlayersChangeEvent;

	public Action<int> OnDepthChangeEvent;

	private string _003CIconType_003Ek__BackingField;

	private int _003CColor_003Ek__BackingField;

	private string _003CFollowTarget_003Ek__BackingField;

	private bool _003CIgnoreDepth_003Ek__BackingField;

	private bool _003CAlwaysInScreen_003Ek__BackingField;

	private bool _003CIsBillboard_003Ek__BackingField;

	private int _003CRenderType_003Ek__BackingField;

	private int _003CWidth_003Ek__BackingField;

	private int _003CHeight_003Ek__BackingField;

	private Vector3 _003COffset_003Ek__BackingField;

	private List<object> _003CVisiblePlayers_003Ek__BackingField;

	private int _003CDepth_003Ek__BackingField;

	private string _003CUGCEntityID_003Ek__BackingField;

	public string IconType
	{
		get
		{
			return _003CIconType_003Ek__BackingField;
		}
		private set
		{
			_003CIconType_003Ek__BackingField = value;
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

	public int RenderType
	{
		get
		{
			return _003CRenderType_003Ek__BackingField;
		}
		private set
		{
			_003CRenderType_003Ek__BackingField = value;
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

	public UGCIconEntityRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
