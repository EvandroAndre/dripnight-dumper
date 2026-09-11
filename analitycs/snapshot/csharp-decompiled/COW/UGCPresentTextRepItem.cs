using System;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW;

public class UGCPresentTextRepItem
{
	public const int PROP_ID_TEXTKEY = -36000;

	public const int PROP_ID_COLOR = -36001;

	public const int PROP_ID_SCALE = -36002;

	public const int PROP_ID_OFFSET = -36003;

	public const int PROP_ID_FOLLOWTARGET = -36004;

	public const int PROP_ID_IGNOREDEPTH = -36005;

	public const int PROP_ID_ISBILLBOARD = -36006;

	public const int PROP_ID_ROTATOR = -36007;

	public const int PROP_ID_SCALEVECTOR = -36008;

	public const int PROP_ID_FONTSIZE = -36009;

	private UGCEntityDataStore _repDataMgr;

	public Action<string> OnTextKeyChangeEvent;

	public Action<int> OnColorChangeEvent;

	public Action<float> OnScaleChangeEvent;

	public Action<Vector3> OnOffsetChangeEvent;

	public Action<string> OnFollowTargetChangeEvent;

	public Action<bool> OnIgnoreDepthChangeEvent;

	public Action<bool> OnIsBillboardChangeEvent;

	public Action<Vector3> OnRotatorChangeEvent;

	public Action<Vector3> OnScaleVectorChangeEvent;

	public Action<int> OnFontSizeChangeEvent;

	private string _003CTextKey_003Ek__BackingField;

	private int _003CColor_003Ek__BackingField;

	private float _003CScale_003Ek__BackingField;

	private Vector3 _003COffset_003Ek__BackingField;

	private string _003CFollowTarget_003Ek__BackingField;

	private bool _003CIgnoreDepth_003Ek__BackingField;

	private bool _003CIsBillboard_003Ek__BackingField;

	private Vector3 _003CRotator_003Ek__BackingField;

	private Vector3 _003CScaleVector_003Ek__BackingField;

	private int _003CFontSize_003Ek__BackingField;

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

	public UGCPresentTextRepItem(string ownerEntityID)
	{
	}

	public void OnDestroy()
	{
	}

	private void OnRepItemChanged(long repDataIndex, UGCSimpleValue newValue)
	{
	}
}
