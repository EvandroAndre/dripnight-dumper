using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCPresentIconRepItem
{
	public const int PROP_ID_ICONTYPE = -35000;

	public const int PROP_ID_COLOR = -35001;

	public const int PROP_ID_SCALE = -35002;

	public const int PROP_ID_OFFSET = -35003;

	public const int PROP_ID_FOLLOWTARGET = -35004;

	public const int PROP_ID_IGNOREDEPTH = -35005;

	public const int PROP_ID_ALWAYSINSCREEN = -35006;

	public const int PROP_ID_ISBILLBOARD = -35007;

	public const int PROP_ID_ROTATOR = -35008;

	public const int PROP_ID_SCALEVECTOR = -35009;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnIconTypeChangeEvent;

	public Action<int> OnColorChangeEvent;

	public Action<float> OnScaleChangeEvent;

	public Action<Vector3> OnOffsetChangeEvent;

	public Action<string> OnFollowTargetChangeEvent;

	public Action<bool> OnIgnoreDepthChangeEvent;

	public Action<bool> OnAlwaysInScreenChangeEvent;

	public Action<bool> OnIsBillboardChangeEvent;

	public Action<Vector3> OnRotatorChangeEvent;

	public Action<Vector3> OnScaleVectorChangeEvent;

	private string _003CIconType_003Ek__BackingField;

	private int _003CColor_003Ek__BackingField;

	private float _003CScale_003Ek__BackingField;

	private Vector3 _003COffset_003Ek__BackingField;

	private string _003CFollowTarget_003Ek__BackingField;

	private bool _003CIgnoreDepth_003Ek__BackingField;

	private bool _003CAlwaysInScreen_003Ek__BackingField;

	private bool _003CIsBillboard_003Ek__BackingField;

	private Vector3 _003CRotator_003Ek__BackingField;

	private Vector3 _003CScaleVector_003Ek__BackingField;

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

	public float Scale
	{
		get
		{
			return _003CScale_003Ek__BackingField;
		}
		private set
		{
			_003CScale_003Ek__BackingField = value;
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

	public Vector3 Rotator
	{
		get
		{
			return _003CRotator_003Ek__BackingField;
		}
		private set
		{
			_003CRotator_003Ek__BackingField = value;
		}
	}

	public Vector3 ScaleVector
	{
		get
		{
			return _003CScaleVector_003Ek__BackingField;
		}
		private set
		{
			_003CScaleVector_003Ek__BackingField = value;
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

	public UGCPresentIconRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
